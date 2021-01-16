using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace AngularMVCProject.Models
{
    public class GestorBilletera
    {
        //Campos
        private double saldo;

        //Constructor
        public GestorBilletera()
        {
            this.saldo = 0;
        }


        //Metodos, funciones de la 'Persona' por medio de la clase 'GestorBilletera'.

        /*  
        *  Ingresa monto a la billetera y lo actualiza.
        *  @Param monto, monto a sumar en la billetera
        *  @return void.
        */
        public void IngresarSaldo(double monto)
        {
            try
            {
                if (monto <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception fail)
            {
                Console.WriteLine("El numero a ingresar debe ser mayor a 0");
            }

            saldo += monto;
            Console.WriteLine("Su saldo actual es: " + this.saldo);
        }

        /*
         * Verifica saldo.
         * @Param sin parametros
         * @return false si no tiene, true si tiene saldo.
         */
        public bool SaldoIsOk()
        {
            if (saldo <= 0)
            {
                Console.WriteLine("ud no tiene saldo o debe (pague su deuda Sr!!)");
                return false;
            }
            else
            {
                Console.WriteLine("Su saldo es de: $" + this.saldo);
                return true;
            }

            Console.WriteLine("el endpoint funciona!");
            //return "Metodo funcionano";
        }

        /*
        *  Retira dinero de la billetera. Si el monto a retirar es mayor al que se tiene,
        *  lanza excepcion. 
        *  @Param monto, es el monto a retirar
        *  @return monto, es el monto a retirar. Se resta el saldo de la persona.
        */
        public double RetirarDinero(double monto)
        {
            if (!(SaldoIsOk()))
            {
                Console.WriteLine("Ud. no tiene suficiente dinero para retirar.");
                return 0;
            }
            if (monto > this.saldo)
            {
                Console.WriteLine("No se ha podido realizar la transaccion, el monto es mayor al saldo que ud. tiene.");
                return 0;
            }

            this.saldo -= monto;
            return monto;
        }

        /*
        * Muestra el saldo actual de la persona.
        * @Param sin parametros.
        * @return saldo, devuelve el saldo actual de la persona.
        */
        public double mostrarSaldo()
        {
            return this.saldo;
        }

        /*
        * Recibe y guarda la foto del dni de la persona.
        * @Param fotoDelDni, es la foto de dni a recibir y guardar
        * @return true si pudo guardar, false caso contrario. 
        * @thrwos Exception si no es del tipo a almacenar.
        */
        /*public bool recibirFotoDni(tipoDeDato fotoDelDni)
        {
            if (tipoDeDato.Equals(fotoDelDni))
            {
                this.fotoDni = fotoDelDni;
                return true;
            }

            throw new Exception("La foto a guardar es del tipo incorrecto. El tipo de dato" +
                                "  almacenar es TipoDeDato.");
            return false;
        }*/
    }

}
