using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InViewChange.ViewModels
{
    public class BlueViewModel : BaseViewModel
    {
        //Relay command to call 'ToRed' function
        public ICommand ChangeToRed
        {
            get { return new RelayCommand(ToRed); }
        }

        //Requires MainViewModel for BaseViewModel
        public BlueViewModel(MainViewModel main) : base(main)
        {

        }

        //Calling BaseViewModel function. Passed BaseViewModel Type
        public void ToRed(object param)
        {
            Navigate<RedViewModel>();
        }
    }
}
