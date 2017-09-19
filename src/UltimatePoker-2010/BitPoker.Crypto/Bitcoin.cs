﻿using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BitPoker.Crypto
{
    public class Bitcoin : IWallet
    {
        //TODO: SECURE STRING
        private readonly ExtKey _privateKey;

        public String Address { get; private set; }

        public String PublicKey { get; private set; }

        public Bitcoin(String words)
        {
            Mnemonic mnemo = new Mnemonic(words, Wordlist.English);
            _privateKey = mnemo.DeriveExtKey("password");

            Address =_privateKey.Neuter().PubKey.GetAddress(Network.TestNet).ToString();
        }

        //public Bitcoin()
        //{
        //    _publicKeys = new List<string>();
        //}

        public void NewAddress()
        {
        
        }

        public void NewAddress(String wifKey)
        {
            throw new NotImplementedException();
        }

        public void NewAddress(String[] words)
        {
            throw new NotImplementedException();
        }

        public String CreateMultiSig(String[] publicKeys, int m)
        {
            throw new NotImplementedException();
        }

        public byte[] GetRandom(int n)
        {
            throw new NotImplementedException();
        }
    }
}
