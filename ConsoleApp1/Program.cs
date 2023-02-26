
using System.Buffers.Text;

public class repaso{
    public void ejercicio1(){
        

        Console.WriteLine("Escribe tu nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("hola amigo " + nombre);
        Console.ReadKey();  
    }
    public void ejercicio2() {
        Console.WriteLine("ingresa la base");
        int basse = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingresa la altura");
        double altura = Convert.ToInt32(Console.ReadLine());
        double perimetro = 2 * (altura + basse);
        double area = basse* altura;
        Console.WriteLine("Perimetro = " + perimetro + " y el area es = "+ area);
        Console.ReadKey();
    }
    public void ejercicio3() {   
        Console.WriteLine("ingresa a");
        double cat1 = Convert.ToInt32(Console.ReadLine());
        cat1 = Math.Pow(cat1, 2);
        Console.WriteLine("ingresa b");
        double cat2 = Convert.ToInt32(Console.ReadLine());
        cat2 = Math.Pow(cat2, 2);
        double hipo = Math.Sqrt(cat1 + cat2);
        Console.WriteLine("Hipotenusa es " + hipo);
        Console.ReadKey();
    }
    public void ejercicio4(){
        Console.WriteLine("ingresa el numero 1");
        double numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingresa el numero 1");
        double numero2 = Convert.ToInt32(Console.ReadLine());

        double suma = numero1 + numero2;
        double resta = numero1 - numero2;
        double multi = numero1 * numero2;
        double division = numero1 / numero2;

        Console.WriteLine("la suma es = " + suma + " resta = " + resta + " multipliacion = " + multi + " division = " + division);
        Console.ReadKey();
    }
    public void ejercicio5() {
        Console.WriteLine("ingresa los grados Farenheit");
        double grados = Convert.ToInt32(Console.ReadLine());
        double convercion = (grados - 32) * 5 / 9;
        Console.WriteLine("los grados celcius son = " + convercion);
        Console.ReadKey();
    }
    public void ejercicio6(){
        Console.WriteLine("escribe un numero");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("escribe un numero 2");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("escribe un numero 3");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("escribe un numero 4");
        int num4 = Convert.ToInt32(Console.ReadLine());
        int media = (num1 + num2 + num3 + num4) / 3;
        Console.WriteLine("la media es = " + media);
        Console.ReadKey();
    }
    public void ejercicio7() {
        Console.WriteLine("ingresa los minutos");
        int minutos = Convert.ToInt32(Console.ReadLine());
        int conver = minutos / 60;
        int min_rest = minutos % 60;

        Console.WriteLine("Corresponden a " + conver + " horas "+ " y " + min_rest + " minutos");
        Console.ReadKey();
    }
    public void ejercicio8() {
        int ingreso = 15000;
        Console.WriteLine("venta 1");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("venta 2");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("venta 3");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int com = (num1 + num2 + num3) / 10;
        int total = com + ingreso;
        Console.WriteLine("comisiones = " + com + " total mes + comisiones = "+ total);
        Console.ReadKey ();

    }   
    public void ejercicio9() {
        Console.WriteLine("producto 1");
        double comp1 = Convert.ToInt32(Console.ReadLine());     
        Console.WriteLine("producto 2");
        double comp2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("producto 3");
        double comp3 = Convert.ToInt32(Console.ReadLine());    
        double total = comp1 + comp2 + comp3;
        double desc = total *.15;
        double t = total - desc;
        Console.WriteLine("Total de la compra es = " + total + " y el descuento es = " + desc + " total a pagar  =  " +  t);
        Console.ReadKey();
    }
    public void ejercicio10() {
        double cal1 = 9;
        double cal2 = 8;
        double cal3 = 7;
        Console.WriteLine("Calificacion de tu examen");
        double examen = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Calificacion de tu trabajo final");
        double traf = Convert.ToInt32(Console.ReadLine());
        double promedio = (cal1 + cal2 + cal3) / 3;   
        double parcial = promedio * .55;
        double examenes = examen * .30;
        double trabajoF = traf * .15;
        double CF = parcial + examenes + trabajoF;
        Console.WriteLine("Tu calificacion final es " + CF);
        Console.ReadKey();


    }


    
    static void Main(String[] args){
        repaso obj = new repaso();
        obj.ejercicio10();
        
   


    }
}