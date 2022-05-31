using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HotelSystem.Annotations;

namespace HotelSystem.Model
{
    public class Person : INotifyPropertyChanged
    {
        private int _personId;
        private string _firstName;
        private string _lastName;
        private string _birthdate;
        private string _passport;

        public int PersonId
        {
            get => _personId;
            set
            {
                if (value == _personId) return;
                _personId = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value == _firstName) return;
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value == _lastName) return;
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public string Birthdate
        {
            get => _birthdate;
            set
            {
                if (value == _birthdate) return;
                _birthdate = value;
                OnPropertyChanged();
            }
        }

        public string Passport
        {
            get => _passport;
            set
            {
                if (value == _passport) return;
                _passport = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}