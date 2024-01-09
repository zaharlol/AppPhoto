using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;
using Xamarin.Forms;

namespace AppPhoto.Models
{
    internal class PinCode
    {
        public string Pin {  get; set; }

        public PinCode(string _pin)
        {
            Pin = _pin;
        }
    }
}