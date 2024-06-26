﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Prototype
{

    public abstract class CloneablePrototype<T>
    {
        // Shallow copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        // Deep Copy
        public T DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }

    class Person : CloneablePrototype<Person>
    {
        public int Age;
        public Guid Id;
        public string Name;
        public Adress AddressDetails;

        public override string ToString()
        {
            return string.Format(" Name : {0}  " + "Age : {1}  {2} ",
                this.Name, this.Age.ToString(), AddressDetails.ToString());
        }
    }

    public class Adress
    {
        public int DoorNumber { get; set; }
        public int StreetNumber { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return string.Format("AddressDetails : Door : {0}, Street: {1}, ZipCode : {2}," +
                " Country : {3}", this.DoorNumber, this.StreetNumber, this.Zipcode.ToString(),
                this.Country);
        }

    }
}
