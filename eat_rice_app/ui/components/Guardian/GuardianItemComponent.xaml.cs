using eat_rice_model.entity.common;
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

namespace eat_rice_app.ui.components.Guardian
{
    /// <summary>
    /// GuardianItemComponent.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GuardianItemComponent : UserControl
    {
        public Subjugation subjugation { set; get; }

        public Action<object> selectedEvent { set; get; }

        public GuardianItemComponent(Subjugation subjugation)
        {
            InitializeComponent();
            this.subjugation = subjugation;
            this.DataContext = this.subjugation;
        }

        private void Selected_Guardian_Click(object sender, RoutedEventArgs e)
        {
            selectedEvent(subjugation);
        }
    }
}
