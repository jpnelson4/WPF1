﻿//James Nelson
//Connor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        public EntryForm()
        {
            Name = "";
            Address = "";
            ZipCode = 0;
        }

        public EntryForm(string name, string address, int zipCode)
        {
            this.Name=name;
            this.Address=address;
            this.ZipCode=zipCode;
        }
        public override string ToString() 
        {
            return $"Name: {Name}, Address: {Address}, ZipCode: {ZipCode}";
        }

    }
}
