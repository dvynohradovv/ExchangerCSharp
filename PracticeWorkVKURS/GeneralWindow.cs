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
    public partial class GeneralWindow : Form
    {
        public GeneralWindow()
        {
            InitializeComponent();

            Start();
            LoadlistViewBanks();
        }

        private ExchangeRates exchangeRates = new ExchangeRates();
        private void Start()
        {
            exchangeRates.RefreshData();
            LoadlistViewBanks();

        }
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
                foreach (var it in exchangeRates.CurrenciesData(tmp_index))
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
    }
}
