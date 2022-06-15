using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MainViewModel:ViewModelBase
    {

        public MainViewModel()
        {
            _Age = 1;
        }

        private int _Age;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; RaisePropertyChanged(nameof(Age)); }
        }


        private int _Height;

        public int Height
        {
            get { return _Height; }
            set { _Height = value;RaisePropertyChanged(); }
        }

    }
}
