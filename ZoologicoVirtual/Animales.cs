using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoVirtual
{
    public class Leon
    {
        private string nombre { get; set; }
        private int altura { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }

        private string especie = "Leon";

        public Leon(string nombre, int altura, double peso, string sexo, int edad)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Leon(string nombre, string sex)
        {
            this.nombre = nombre;
            this.sexo = sex;
        }

        public void mover()
        {
            Console.WriteLine("Camina!");
        }


        public void comer()
        {
            Console.WriteLine("Come Carne!");
        }

        public void sonar()
        {
            Console.WriteLine("GRRRRRRRR");
        }


        public override string ToString()
        {
            return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;


        }


    }
        class Elefante
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }
            private string especie = "Elefante";


            public Elefante(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }
            public Elefante(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }


            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Hierbas!");
            }

            public void sonar()
            {
                Console.WriteLine("UHHHHHHH");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;

            }




        }



        class Jirafa
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }
            private string especie = "Jirafa";


            public Jirafa(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }

            public Jirafa(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }


            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Hierbas!");
            }

            public void sonar()
            {
                Console.WriteLine("muhhhhhh");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }




        }


        class Tigre
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }

            private string especie = "Tigre";


            public Tigre(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }

            public Tigre(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }


            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Carne!");
            }

            public void sonar()
            {
                Console.WriteLine("GRRRRRRRRNIAAAAAU");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }




        }

        class Mono
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }

            private string especie = "Mono";


            public Mono(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }

            public Mono(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }


            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Hierbas y frutas!");
            }

            public void sonar()
            {
                Console.WriteLine("u u ah ah! quiero banana ");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }






        }


        class Oso
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }

            private string especie = "Oso";


            public Oso(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }

            public Oso(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }


            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Pescado!");
            }

            public void sonar()
            {
                Console.WriteLine("UAAAAAAAAAAH");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }




        }


        class Cocodrilo
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }

            private string especie = "Cocodrilo";


            public Cocodrilo(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }
            public Cocodrilo(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }


            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Carne!");
            }

            public void sonar()
            {
                Console.WriteLine("mmiou!");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }




        }

        class Serpiente
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }

            private string especie = "Serpiente";


            public Serpiente(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }

            public Serpiente(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }



            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come carne");
            }

            public void sonar()
            {
                Console.WriteLine("shshshsh");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }




        }


        class Pinguino
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }

            private string especie = "Pinguino";


            public Pinguino(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }
            public Pinguino(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }


            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Pescado!");
            }

            public void sonar()
            {
                Console.WriteLine("AH AH AH AA");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }


        }


        class Lobo
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }

            private string especie = "Lobo";


            public Lobo(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }

            public Lobo(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }



            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Carne!");
            }

            public void sonar()
            {
                Console.WriteLine("AUUUUUUUU");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }


        }



        class Cebra
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }

            private string especie = "Cebra";


            public Cebra(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }


            public Cebra(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }

            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Hierbas!");
            }

            public void sonar()
            {
                Console.WriteLine("TRRRR");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }




        }


        class Rinoceronte
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }

            private string especie = "Rinoceronte";


            public Rinoceronte(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }

            public Rinoceronte(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }


            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Hierbas!");
            }

            public void sonar()
            {
                Console.WriteLine("MHHHHHH");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }



        }


        class Panda
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }


            private string especie = "Panda";



            public Panda(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }


            public Panda(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }

            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Bambus!");
            }

            public void sonar()
            {
                Console.WriteLine("Kun fu panda");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }




        }


        class PavoReal
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }

            private string especie = "PavoReal";


            public PavoReal(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }

            public PavoReal(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }


            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Maiz!");
            }

            public void sonar()
            {
                Console.WriteLine("GRGRUGURU");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }




        }


        class Tortuga
        {
            private string nombre { get; set; }
            private int altura { get; set; }
            private double peso { get; set; }
            private string sexo { get; set; }
            private int edad { get; set; }

            private string especie = "Tortuga";


            public Tortuga(string nombre, int altura, double peso, string sexo, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.sexo = sexo;
                this.edad = edad;
            }

            public Tortuga(string nombre, string sex)
            {
                this.nombre = nombre;
                this.sexo = sex;
            }


            public void mover()
            {
                Console.WriteLine("Camina!");
            }


            public void comer()
            {
                Console.WriteLine("Come Hojas!");
            }

            public void sonar()
            {
                Console.WriteLine("ah ah ah");
            }


            public override string ToString()
            {
                return "\n Nombre: " + this.nombre + "\n" + "Sexo: " + this.sexo + "\n" + "Especie: " + this.especie;
            }




        }
    
}