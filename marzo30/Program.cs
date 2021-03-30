using marzo30.modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marzo30
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto="20";
            string texto2="30";

            Debug.WriteLine(texto+texto2);

            // convertir un valor.
            // texto en un numero (puede fallar)
            int numero1=Convert.ToInt32(texto);
            int numero2=Int32.Parse(texto2);
            Debug.WriteLine(numero1+numero2);


            // numero a texto (no falla)
            texto=numero1.ToString();
            texto2=numero2.ToString();

            // primitivo
            object numero3=20;
            Debug.WriteLine(numero3);

            // CAST! no hace conversion           
            int numero=20;

            object obj=new Clase1();
            ((Clase1)obj).CampoComun="2";
            ((Clase1)obj).Campo1="22";
            obj="22";
            obj=new Clase2();
            // 20.2
            // 20.2f
            // 20.2d
            ((Clase1)obj).Campo1="22";

        }
    }
}
