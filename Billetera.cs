using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularMVCProject.Models
{
    public class Billetera
    {
        //Campos
        private double saldo;        

        //Constructor
        public Billetera()
        {
            this.saldo = 0;
            //this.fotoDni = null;
        }

        // Define propiedad: public int MyProperty { get; set; }
        public double Saldo { get => saldo; set => saldo = value; }

    }
}