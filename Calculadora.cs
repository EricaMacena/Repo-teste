using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operadores_e_Trigonometria
{
    public class Calculadora
    {
        
    public void Somar( int x, int y)
    {
        //dentro de chaves mostra o valor  da  variavel
         Console.WriteLine($"{x} + {y} = {x+y}");
    }


     public void Dividir( int x, int y)
    {
       
         Console.WriteLine($"{x} / {y} = {x/y}");
    }



     public void Potencia( int x, int y)
    {
       //A classe Math tem varias operações de matematica

       //Vamos usar o metodo potencia dessa classe Math
        double pot = Math.Pow(x,  y);
         Console.WriteLine($"{x}^{y} = {pot}");
    }


     //Para Calcular usando o metodo  cos, tan e sen da classe math precisa 
     //deixar o angulo em radianos antes
     public void Coseno(double angulo)
     {
        double radiano = angulo * Math.PI / 180;
    
        //agora calcule o coseno do angulo(que esta em radiano)
        double coseno = Math.Cos(radiano);
        Console.WriteLine($"COSENO DE {angulo} = {coseno}");
     }


      public void Tangente(double angulo)
     {
        double radiano = angulo* Math.PI/180;
        double tangente = Math.Cos(radiano);
        Console.WriteLine($"Tangente de {angulo} = {tangente}");
     }


       public void Seno(double angulo)
     {
        double radiano = angulo* Math.PI/180;
        double sin = Math.Sin(radiano);
        Console.WriteLine($"Seno de {angulo} = {Math.Round(sin,4)}");
     }
    

     public void Raizuadrada(double x)
     {
        double raiz = Math.Sqrt(x);
        Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
     }









    }
}