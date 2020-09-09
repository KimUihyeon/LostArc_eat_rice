using eat_rice_app.ui.components.Guardian;
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

namespace eat_rice_app.ui.components
{
    /// <summary>
    /// GuardianTabComponent.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GuardianListComponent : UserControl
    {
        public GuardianListComponent(List<Subjugation> subjugations, Action<object> selectedCallBack)
        {
            InitializeComponent();

            /*
             * ui
             */

            foreach (Subjugation Subjugation in subjugations)
                sp_GuardianList.Children.Add(new GuardianItemComponent(Subjugation) { selectedEvent = selectedCallBack });
        }
    }
}
