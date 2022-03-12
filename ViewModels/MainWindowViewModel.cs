using System;
using System.Collections.Generic;
using System.Linq;
using ReactiveUI;

namespace ComboBoxIssue.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string[] _comboOptions = new string[] { "one", "two", "three" };

        public List<string> ComboOptions => _comboOptions.ToList();

        void ChangeComboOptions()
        {
            this.RaisePropertyChanged(nameof(ComboOptions));
        }

        string _comboItem = "one";
        public string ComboItem
        {
            get => _comboItem;
            set
            {
                Log += $"ComboItem set to {value ?? "null"}{Environment.NewLine}";
                this.RaiseAndSetIfChanged(ref _comboItem!, value);
            }
        }

        string _log = "";
        public string Log
        {
            get => _log;
            set => this.RaiseAndSetIfChanged(ref _log, value);
        }
    }
}
