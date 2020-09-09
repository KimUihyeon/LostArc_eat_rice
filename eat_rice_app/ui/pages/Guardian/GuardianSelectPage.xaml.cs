using eat_rice_app.ui.components;
using eat_rice_app.util;
using eat_rice_model.entity.common;
using eat_rice_service.masterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace eat_rice_app.ui.pages.Guardian
{
    /// <summary>
    /// GuardianSelectPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GuardianSelectPage : UserControl
    {
        private MasterService masterService = new MasterService();

        public GuardianSelectPage()
        {
            InitializeComponent();

            this.Loaded += GuardianSelectPage_Loaded;
        }

        private void test(Object ob)
        {
            var data = (ob as Subjugation);
            MessageBox.Show(data.Name);
        }

        private void GuardianSelectPage_Loaded(object sender, RoutedEventArgs e)
        {
            var tireGroupByList = this.masterService.GetSubjugationHomeworks().GroupBy(t=>t.Tire).ToList();
            foreach (var data in tireGroupByList)
            {
                TabItem item = new TabItem() { Header = "티어 " + data.Key };
                item.Content = new GuardianListComponent(data.ToList(), test);
                tb.Items.Add(item);
            }
        }
    }
}
