using SV_Client.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SV_Client.ViewModels
{
    public class vm_StartInterface
    {
        // VARIABLEN
        
        private RelayCommand pr_GameStartCommand;
        public RelayCommand pu_GameStartCommand
        {
            get { return pr_GameStartCommand; }
            set { pr_GameStartCommand = value; }
        }

        private RelayCommand pr_RankingCommand;
        public RelayCommand pu_RankingCommand
        {
            get { return pr_RankingCommand; }
            set { pr_RankingCommand = value; }
        }

        private RelayCommand pr_OptionCommand;
        public RelayCommand pu_OptionCommand
        {
            get { return pr_OptionCommand; }
            set { pr_OptionCommand = value; }
        }

        private RelayCommand pr_ExitCommand;
        public RelayCommand pu_ExitCommand
        {
            get { return pr_ExitCommand; }
            set { pr_ExitCommand = value; }
        }

        private RelayCommand pr_RefreshCommand;
        public RelayCommand pu_RefreshCommand
        {
            get { return pr_RefreshCommand; }
            set { pr_RefreshCommand = value; }
        }

        private RelayCommand pr_JoinCommand;
        public RelayCommand pu_JoinCommand
        {
            get { return pr_JoinCommand; }
            set { pr_JoinCommand = value; }
        }

        private RelayCommand pr_ChangeGUICommand;

        public RelayCommand pu_ChangeGUICommand
        {
            get { return pr_ChangeGUICommand; }
            set { pr_ChangeGUICommand = value; }
        }

        // KONSTRUKTOR

        public vm_StartInterface()
        {
            pr_GameStartCommand = new RelayCommand(param => F_StartGame());
            pr_RankingCommand = new RelayCommand(param => F_ShowRanking());
            pr_OptionCommand = new RelayCommand(param => F_ShowOptions());
            pr_ExitCommand = new RelayCommand(param => F_ExitProgram());
            pr_RefreshCommand = new RelayCommand(param => F_RefreshHosts());
            pr_JoinCommand = new RelayCommand(param => F_JoinGame());
            pr_ChangeGUICommand = new RelayCommand(param => F_ChangeGUI(this));
        }

        // FUNKTIONEN
        private void F_ChangeGUI(object source)
        {
            ViewModels.vm_MainInterface.pu_ChangeGUICommand.Execute(source);
        }

        private void F_StartGame()
        {
            MessageBox.Show("Start Game");
        }

        private void F_ShowRanking()
        {
            MessageBox.Show("Ranking");
        }

        private void F_ShowOptions()
        {
            MessageBox.Show("Options");
        }

        private void F_ExitProgram()
        {
            Application.Current.Shutdown();
        }

        private void F_RefreshHosts()
        {
            MessageBox.Show("Refresh");
        }

        private void F_JoinGame()
        {
            MessageBox.Show("Join");
        }

    }
}