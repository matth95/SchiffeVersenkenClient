using SV_Client.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SV_Client.ViewModels
{

    public class vm_MainInterface : UserControl, INotifyPropertyChanged
    {
        // VARIABLES

        private static RelayCommand pr_ChangeGUICommand;

        public static RelayCommand pu_ChangeGUICommand
        {
            get { return vm_MainInterface.pr_ChangeGUICommand; }
            set { vm_MainInterface.pr_ChangeGUICommand = value;  }
        }

        private RelayCommand pr_ExitCommand;
        public RelayCommand pu_ExitCommand
        {
            get { return pr_ExitCommand; }
            set { pr_ExitCommand = value; }
        }

        private UserControl pr_ActiveContent;
        public UserControl pu_ActiveContent
        {
            get { return pr_ActiveContent; }
            set 
            { 
                pr_ActiveContent = value;
                F_NotifyChange("pu_ActiveContent");
            }
        }

        private UserControls.uc_StartInterface pr_uc_StartContent;
        private UserControls.uc_GameInterface pr_uc_GameContent;

        // CONSTRUCTORS

        public vm_MainInterface()
        {
            pu_ActiveContent = new UserControl();
            pr_uc_StartContent = new UserControls.uc_StartInterface();
            pr_uc_GameContent = new UserControls.uc_GameInterface();

            pr_ActiveContent = pr_uc_StartContent;

            pr_ChangeGUICommand = new RelayCommand(param => F_GameStart());
            pr_ExitCommand = new RelayCommand(param => F_ExitProgram());
        }

        // FUNCTIONS

        public event PropertyChangedEventHandler PropertyChanged;

        public void F_NotifyChange(string ChangedComponent)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(ChangedComponent));
            }
        }

        private void F_GameStart()
        {
            pu_ActiveContent = pr_uc_GameContent;   
        }

        private void F_ExitProgram()
        {
            Application.Current.Shutdown();
        }
    }
}
