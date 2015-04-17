using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SV_Client.ViewModels
{
    public class vm_GameInterface : UserControl, INotifyPropertyChanged
    {
        // VARIABLES

        private string pr_OwnUsername;
        public string pu_OwnUsername
        {
            get { return pr_OwnUsername; }
            set 
            { 
                pr_OwnUsername = value;
                F_NotifyChanged("pu_OwnUsername");
            }
        }

        private string pr_OpponentUsername;
        public string pu_OpponentUsername
        {
            get { return pr_OpponentUsername; }
            set 
            { 
                pr_OpponentUsername = value;
                F_NotifyChanged("pu_OpponentUsername");
            }
        }

        private string pr_OwnShipsRemaining;
        public string pu_OwnShipsRemaining
        {
            get { return pr_OwnShipsRemaining; }
            set
            { 
                pr_OwnShipsRemaining = value;
                F_NotifyChanged("pu_OwnShipsRemaining");
            }
        }

        private string pr_OpponentShipsRemaining;
        public string pu_OpponentShipsRemaining
        {
            get { return pr_OpponentShipsRemaining; }
            set
            { 
                pr_OpponentShipsRemaining = value;
                F_NotifyChanged("pu_OpponentShipsRemaining");
            }
        }

        // CONSTRUCTORS

        public vm_GameInterface()
        {

            pr_OwnUsername = "Mein Username";
            pr_OwnShipsRemaining = "test10";
            pr_OpponentUsername = "Gegner Username";
            pr_OpponentShipsRemaining = "test9";
        }

        // FUNCTIONS

        public event PropertyChangedEventHandler PropertyChanged;

        public void F_NotifyChanged(string ChangedComponent)
        {
            if( PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(ChangedComponent));
            }
        }
    }
}
