using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HotelSystem.Annotations;

namespace HotelSystem.Model
{
    public class Client : Person
    {
        private string _account;
        private DateTime? _datastart;
        private DateTime? _datastop;
        private Room _room;
        

        public string Account
        {
            get => _account;
            set
            {
                if (value == _account) return;
                _account = value;
                OnPropertyChanged();
            }
        }

        public DateTime? DataStart
        {
            get => _datastart;
            set
            {
                if (value.Equals(_datastart)) return;
                _datastart = value;
                OnPropertyChanged();
            }
        }

        public DateTime? DataStop
        {
            get => _datastop;
            set
            {
                if (value.Equals(_datastop)) return;
                _datastop = value;
                OnPropertyChanged();
            }
        }

        public virtual Room Room
        {
            get => _room;
            set
            {
                if (Equals(value, _room)) return;
                _room = value;
                OnPropertyChanged();
            }
        }
    }
}