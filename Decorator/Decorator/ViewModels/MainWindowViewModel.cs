using System.ComponentModel;
using System.Dynamic;
using System.Windows;
using Decorator.Models;
using Prism.Commands;
using Prism.Mvvm;

namespace Decorator.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private ICharacter guy;
        private int _str;
        private int _dex;
        private int _int;
        private int _level;


        public int Str
        {
            get => _str;
            set => SetProperty(ref _str, value);
        }

        public int Dex
        {
            get => _dex;
            set => SetProperty(ref _dex, value);
        }

        public int @Int
        {
            get => _int;
            set => SetProperty(ref _int, value);
        }

        public int Level
        {
            get => _level;
            set => SetProperty(ref _level, value);
        }




        private string _title = "SWD Decorator Pattern";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            ExecuteHuman();

        }

        #region Commands

        private DelegateCommand _pathCommand;
        public DelegateCommand PathCommand =>
            _pathCommand ?? (_pathCommand = new DelegateCommand(ExecutePath));

        private DelegateCommand _humCommand;
        public DelegateCommand HumCommand =>
            _humCommand ?? (_humCommand = new DelegateCommand(ExecuteHuman));

        private DelegateCommand _orcCommand;
        public DelegateCommand OrcCommand =>
            _orcCommand ?? (_orcCommand = new DelegateCommand(ExecuteOrc));

        private DelegateCommand _strCommand;
        public DelegateCommand StrCommand =>
            _strCommand ?? (_strCommand = new DelegateCommand(ExecuteStrUp));

        private DelegateCommand _dexCommand;
        public DelegateCommand DexCommand =>
            _dexCommand ?? (_dexCommand = new DelegateCommand(ExecuteDexUp));

        private DelegateCommand _intCommand;
        public DelegateCommand IntCommand =>
            _intCommand ?? (_intCommand = new DelegateCommand(ExecuteIntUp));


        #endregion

        #region CommandFunctions

        void ExecuteHuman()
        {
            guy = new Human();
            Str = guy.GetStrength();
            Dex = guy.GetDexterity();
            Int = guy.GetIntelligence();
            Level = guy.GetLevel();
        }

        void ExecuteOrc()
        {
            guy = new Orc();
            Str = guy.GetStrength();
            Dex = guy.GetDexterity();
            Int = guy.GetIntelligence();
            Level = guy.GetLevel();


        }

        void ExecuteStrUp()
        {
            guy = new StrUp(guy);
            Str = guy.GetStrength();
            Level = guy.GetLevel();


        }

        void ExecuteDexUp()
        {
            guy = new DexUp(guy);
            Dex = guy.GetDexterity();
            Level = guy.GetLevel();



        }

        void ExecuteIntUp()
        {
            guy = new IntUp(guy);
            Int = guy.GetIntelligence();
            Level = guy.GetLevel();


        }

        void ExecutePath()
        {
            MessageBox.Show(guy.GetPath());
        }

        #endregion
    }
}
