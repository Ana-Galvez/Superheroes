using System;
using System.Security.Cryptography.X509Certificates;

namespace Superheroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Superheroe superheroe1 = new Superheroe("Batman", 100, 85, 80);
            Superheroe superheroe2= new Superheroe("Superman", 100, 90, 90);
            superheroe1.MostrarDatos();
            superheroe2.MostrarDatos();
            Console.WriteLine(superheroe1.Competir(superheroe2));
            
        }
    }

    class Superheroe
    {

        private string nombre;
        private int fuerza;
        private int resistencia;
        private int superpoderes;

        public Superheroe(string nombre, int fuerza, int resistencia, int superpoderes)
        {
            setFuerza(fuerza);
            setResistencia(resistencia);
            setSuperpoderes(superpoderes);
            this.nombre = nombre;
            //this.fuerza = fuerza;
            //this.resistencia = resistencia;
            //this.superpoderes = superpoderes;
        }
        
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        private void setFuerza(int fuerza)
        {
            if (fuerza >= 0 && fuerza <= 100) this.fuerza = fuerza;
            else if (fuerza < 0) this.fuerza = 0;
            else this.fuerza = 100;
        }
        private void setResistencia(int resistencia)
        {
            if (resistencia >= 0 && resistencia <= 100) this.resistencia = resistencia;
            else if (resistencia < 0) this.resistencia = 0;
            else this.resistencia = 100;
        } 
        private void setSuperpoderes(int superpoderes)
        {
            if (superpoderes >= 0 && superpoderes <= 100) this.superpoderes = superpoderes;
            else if (superpoderes < 0) this.superpoderes = 0;
            else this.superpoderes = 100;
        }

        public string getNombre()
        {
            return nombre;
        }
        public int getFuerza()
        {
            return fuerza;
        }
        public int getResistencia()
        {
            return resistencia;
        }
        public int getSuperpoderes()
        {
            return superpoderes;
        }

        public string Competir(Superheroe superheroe)
        {
            int contadorGana = 0;
            int contadorPierde = 0;
            if (this.fuerza > superheroe.fuerza) contadorGana++;
            else if (this.fuerza < superheroe.fuerza) contadorPierde++;

            if (this.resistencia > superheroe.resistencia) contadorGana++;
            else if (this.resistencia < superheroe.resistencia) contadorPierde++;

            if (this.superpoderes > superheroe.superpoderes) contadorGana++;
            else if (this.superpoderes < superheroe.superpoderes) contadorPierde++;

            if (contadorGana >= 2) return "TRIUNFO";
            if (contadorPierde >= 2) return "DERROTA";
            return "EMPATE";
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {this.nombre}");
            Console.WriteLine($"Fuerza: {this.fuerza}");
            Console.WriteLine($"Resistencia: {this.resistencia}");
            Console.WriteLine($"Superpoderes: {this.superpoderes}");
        }
    }

}
