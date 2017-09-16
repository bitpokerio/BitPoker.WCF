﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePoker.ViewModels
{
    public class WalletViewModel : INotifyPropertyChanged
    {
        private readonly BitPoker.Crypto.IWallet wallet;

        public event PropertyChangedEventHandler PropertyChanged;

        public Decimal Balance { get; }

        public WalletViewModel()
        {
        }

        public WalletViewModel(string words)
        {
        }

        public void Save()
        {

        }

        public void Refresh()
        {

        }

        /// <summary>
        /// Raises the <see cref="PropertyChanged"/> event with the given property name.
        /// </summary>
        /// <param name="propName">The property name which was modified</param>
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
