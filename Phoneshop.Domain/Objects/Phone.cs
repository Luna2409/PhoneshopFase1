﻿namespace Phoneshop.Domain.Objects
{
    public class Phone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public double PriceWithTax { get; set; }
        public double PriceWithoutTax { get; set; }
        public int Stock { get; set; }

        private string _fullName = "";
        public string FullName 
        { 
            get { return _fullName = $"{Brand} - {Type}"; } 
        }
    }
}
