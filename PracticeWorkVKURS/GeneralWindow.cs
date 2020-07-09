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

            Start();
            LoadlistViewBanks();
        }
        private ExchangeRates exchangeRates = new ExchangeRates();
        private string _bankCitySelected = "Все";
        private string _currencySelected = "Все";

        private void Start()
        {
            exchangeRates.RefreshData();
            LoadlistViewBanks();
        }
        private void LoadlistViewBanks() //Обновление списка банков
        {
            listViewBanks.Items.Clear();
            List<string[]> ls_banks = exchangeRates.BanksData();
            exchangeRates.ExceptThenThatInLine(ls_banks, _bankCitySelected);
            foreach (var it in ls_banks)
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
                List<string[]> ls_curriencies = exchangeRates.CurrenciesData(tmp_index);
                exchangeRates.ExceptThenThatInLine(ls_curriencies, _currencySelected);
                foreach (var it in ls_curriencies)
                {
                    ListViewItem oneItem = new ListViewItem(it);
                    listViewCurrencies.Items.Add(oneItem);
                }
            }
            else
            {
                string[] str = { "...", "...", "..." };
                ListViewItem oneItem = new ListViewItem(str);
                listViewCurrencies.Items.Add(oneItem);
            }
            
        }

        private void comboBoxBanksCitySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bankCitySelected = comboBoxBanksCitySelector.SelectedItem.ToString();
        }

        private void comboBoxCurrencySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currencySelected = comboBoxCurrencySelector.SelectedItem.ToString();
        }
    }
}
