// See https://aka.ms/new-console-template for more information
bool fin == false;
while(fin == false){
Console.WriteLine("Ingrese la edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        if(edad > 0){
            string TipoDePersona = "";
            switch(edad){
                case (edad <= 3 && edad >= 0):
                Console.WriteLine("recien nacido");
                case (edad <= 9 && edad >= 4):
                Console.WriteLine("infante");
                case (edad <= 12 && edad >= 10):
                Console.WriteLine("puberto");
                case (edad <= 19 && edad >= 13):
                Console.WriteLine("adolescente");
                case (edad <= 29 && edad >= 20):
                Console.WriteLine("joven");
                case (edad <= 49 && edad >= 30):
                Console.WriteLine("adulto");
                case (edad <= 59 && edad >= 50):
                Console.WriteLine("adulto mayor");
                case (edad >= 60):
                Console.WriteLine("anciano");
            }
            else {
                Console.WriteLine("Ingrese un número válido");
            }
        }
        Console.WriteLine("Desea calcular otro rango de edad? - si : 1    -no : 2");
        int continuar = Convert.To.Int32(Console.ReadLine());
        if(continuar == 2){
            fin = true;
        }
}
        

