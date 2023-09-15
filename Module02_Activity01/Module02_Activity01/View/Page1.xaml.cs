using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Module02_Activity01.ViewModel;

namespace Module02_Activity01.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            // Add the directive 'using [PROJECT_NAME].View;'
            // Add binding context from View to ViewModel in code-behind to use variables
            BindingContext = new TaskViewModel();
        }
    }
}