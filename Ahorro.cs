class ahorro
{
    public string Nombre { get; set; }
    public int NumeroCuenta {  get; set; }
    public string Genero {  get; set; }
    public double Saldo {  get; set; }
}

class ejercicio2
{
    public static void Main(string[] args)
    {
        double saldott = 0,SaldoProm=0,saldongt=0,saldoPs=0,Menor=0,mayor=0,promH=0,promM=0;
        int numc = 0;
        string Nombre = "",nombre2="";
        ahorro[] ahorradores = new ahorro[4];
        ahorradores[0]=new ahorro { Nombre = "Juan", NumeroCuenta = 1, Genero = "Masculino", Saldo = 10000 };
        ahorradores[1] = new ahorro { Nombre = "Alexa", NumeroCuenta = 2, Genero = "Femenino", Saldo = 1000000 };
        ahorradores[2] = new ahorro { Nombre = "Jose", NumeroCuenta = 3, Genero = "Masculino", Saldo = 10000000 };
        ahorradores[3] = new ahorro { Nombre = "Fernanda", NumeroCuenta = 4, Genero = "Femenino", Saldo = -200000 };
         //promedio de saldo
        for(int i = 0; i < ahorradores.Length; i++)
        {
            saldott = saldott + ahorradores[i].Saldo;
        }
        SaldoProm = saldott / ahorradores.Length;
        for(int i = 0;i < ahorradores.Length; i++)
        {
            //*Ahorradores con saldo negativo y Saldo positivo , mayor o igual a 0
            if (ahorradores[i].Saldo < 0)
            {
                saldongt = saldongt + 1;
            }
            else { saldoPs = saldoPs + 1; }

        }
        //Saldo menor y mayor
        Menor = ahorradores[0].Saldo;
        Nombre = ahorradores[0].Nombre;
        mayor = ahorradores[0].Saldo;
        nombre2 = ahorradores[0].Nombre;
        for (int i = 0;i<ahorradores.Length ; i++)
        {
            if (ahorradores[i].Saldo<Menor) {
                Menor = ahorradores[i].Saldo;
                Nombre = ahorradores[i] .Nombre;
            }
            else { if (ahorradores[i].Saldo>mayor)
                {
                    mayor= ahorradores[i].Saldo;

                    nombre2=ahorradores[i].Nombre;
                    numc = ahorradores[i].NumeroCuenta;
                } }
        }
        //promedio de Hombres y de Mujeres
        int conH = 0, conM = 0;
        
        for(int i = 0; i<ahorradores.Length ;i++)
        {
            if (ahorradores[i].Genero.CompareTo("Masculino") ==1){
                conH=conH+1;
            }
            else
            {
                conM=conM+1;
            }
        }
        promH = (conH / ahorradores.Length)*100;
        promM=(conM / ahorradores.Length)*100;

        Console.WriteLine("El saldo Promedio de los ahorradores es : " + SaldoProm + "\n Numero de saldos en negativo : " + saldongt + "\n Numero de Saldos Positivos :" + saldoPs + "\n Saldo Menor :" + Menor + " Nombre :" + Nombre + "\n Saldo Mayor :" + mayor + " Nombre : " + nombre2 + "Numero de Cuenta :" + numc + "\n Promedio de Hombres : " + promH + "\n Promedio de Mujeres :" + promM);




    }
}
