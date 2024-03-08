using System.Collections.Concurrent;
public class Trabajo() {
    public static void Main(string[] args)
    {

        Cajero();
    }
    public static void Cajero() {
        string Usuario, Cont;
        double c=0;
        int num1 = 0, Num2 = 0, Num3 = 0, num4 = 0, Monto, mod = 0;


             while (c == 0) {
                Console.WriteLine("Bienvenido");
        Console.WriteLine("Ingrese El Usuario :");
           
                Usuario = Console.ReadLine();
                Console.WriteLine("Ingrese La Contraseña :");
                Cont = Console.ReadLine();

            if (Usuario == "Sebas99" && Cont == "1234")
            {
                Console.WriteLine("Ingrese el Monto que desea Retirar (Maximo 600.000$ :)");
                Monto = Convert.ToInt32(Console.ReadLine());
                num1 = Monto / 50000;
                mod = Monto % 50000;
                if (mod != 0)
                {
                    Num2 = mod / 20000;
                    mod = mod % 20000;



                    if (mod != 0)
                    {
                        Num3 = mod / 10000;
                        mod = mod % 10000;

                    
                    
            
                        if (mod != 0)
                        {
                            num4 = mod / 5000;
                            mod = mod % 5000;

                        }
                        
                        
                            if ((mod < 4999) && (mod > 2500))
                            {
                                Monto = 5000;
                        }
                        else {
                            Monto = 0;
                                }
                        
                    }
                }
                Console.WriteLine("Billetes de 50.000= " + num1 + "Billetes de 20.000 = " + Num2 + "Billetes de 10000= " + Num3 + "Billetes de 5000 = " + num4);
                Console.WriteLine("Saldo Restante ="+Monto);
                c = 1;
            }

            else
            {
                Console.WriteLine("Usuario O Contraseña Invalidos");
            }
    }
    }
}
