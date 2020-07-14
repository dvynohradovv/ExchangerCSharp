using PracticeWorkVKURS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWorkVKURS
{
    //1. Компановка и полировка -  я 
    //2. Парсер - Влад
    //3. Сериализация - Саша
    //4. Формы - Глеб
    //5. Классовое взаимодействие - Тимур
    public partial class GeneralWindow : Form
    {
        public GeneralWindow()
        {
            InitializeComponent();

            RefreshData();
        }
        private ExchangeRates exchangeRates = new ExchangeRates();
        private bool InternetAccess;

        private void RefreshData()
        {
            if(exchangeRates.RefreshData())
            {
                buttonInternetStatus.Text = "Подключено";
            }
            else
            {
                buttonInternetStatus.Text = "Нет подключения";
            }
            labelCurrentDateData.Text = exchangeRates.DateData();
            ComboBoxBanksCitySelectorRefresh();
            ComboBoxCurrencySelectorRefresh();
            LoadlistViewBanks();

        }
        private void buttonFindBanks_Click(object sender, EventArgs e)//Обновить банки
        {
            exchangeRates.buyCheckBoxIsActive = checkBoxBuy.Checked;
            exchangeRates.sellCheckBoxIsActive = checkBoxSell.Checked;

            string tmp_from = textBoxFrom.Text;
            string tmp_to = textBoxTo.Text;
            if (tmp_from.Length == 0) tmp_from = "0";
            if (tmp_to.Length == 0) tmp_to = "100000";
            string message = "";
            double from = 0.0;
            double to = 10000.0;
            if (tmp_from == "от" || double.TryParse(tmp_from, out from))
            {
                exchangeRates.currencyValueFrom = from;
            }
            else
            {
                message = "Некорректный ввод параметра 'от'\n";
            }

            if (tmp_to == "до" || double.TryParse(tmp_to, out to))
            {
                exchangeRates.currencyValueTo = to;
                listViewCurrencies.Items.Clear();
                LoadlistViewBanks();
            }
            else
            {
                message += "Некорректный ввод параметра 'до' ";
                MessageBox.Show(message);
            }


        }
        //combo box города
        private void comboBoxBanksCitySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            exchangeRates.onlyWithThatCity = comboBoxBanksCitySelector.SelectedItem.ToString();
            //LoadlistViewBanks();
        }
        private void ComboBoxBanksCitySelectorRefresh()
        {
            comboBoxBanksCitySelector.Items.Clear();
            comboBoxBanksCitySelector.Items.Add("Все города");
            comboBoxBanksCitySelector.Items.AddRange(exchangeRates.Cities().ToArray());
        }

        //comboBox валюты
        private void comboBoxCurrencySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            exchangeRates.onlyWithThatCurrency = comboBoxCurrencySelector.SelectedItem.ToString();
            //LoadlistViewBanks();
        }
        private void ComboBoxCurrencySelectorRefresh()
        {
            comboBoxCurrencySelector.Items.Clear();
            comboBoxCurrencySelector.Items.Add("Все валюты");
            comboBoxCurrencySelector.Items.AddRange(exchangeRates.Currencies().ToArray());
        }

        //ListBox
        private void LoadlistViewBanks() //Обновление списка банков
        {
            listViewBanks.Items.Clear();
            foreach (var it in exchangeRates.BanksData())
            {
                ListViewItem oneItem = new ListViewItem(it);
                listViewBanks.Items.Add(oneItem);
            }
        }
        private void listViewBanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewCurrencies.Items.Clear();
            if (listViewBanks.SelectedItems.Count != 0)
            {
                int tmp_index = Convert.ToInt32(listViewBanks.FocusedItem.SubItems[0].Text);
                foreach (var it in exchangeRates.BuySell(tmp_index))
                {
                    ListViewItem oneItem = new ListViewItem(it);
                    listViewCurrencies.Items.Add(oneItem);
                }
            }
            else
            {
                string[] str = { "...", "...", "...", "..." };
                ListViewItem oneItem = new ListViewItem(str);
                listViewCurrencies.Items.Add(oneItem);
            }
        }

        //ToolMenuStrip
        
        private void обновитьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)//меню обновить
        {
            RefreshData();
        }
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)//меню выйти
        {
            Close();
        }
    }
}
