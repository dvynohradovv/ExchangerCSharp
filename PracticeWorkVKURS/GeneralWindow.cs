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
            RefreshData();

            LoadlistViewBanks();

        }

        private (List<string[]> ls_banksData, SortedDictionary<int, List<string[]>> dic_currencyData) _FullData;
        private void RefreshData()
        {
            var fullInfo = DataParseFromXml.GetBanksAndCurrenciesData();
            _FullData.ls_banksData = fullInfo.ls_banksData;
            _FullData.dic_currencyData = fullInfo.dic_currencyData;
        }
        private void LoadlistViewBanks() //Обновление списка банков
        {
            listViewBanks.Items.Clear();
            foreach (var it in _FullData.ls_banksData)
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
                foreach (var it in _FullData.dic_currencyData[tmp_index])
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
