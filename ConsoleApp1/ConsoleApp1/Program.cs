using System;


public abstract class Vehiculo
{

    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public int Kilometraje { get; set; }

    public Vehiculo(string marca, string modelo, int año, int kilometraje)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
        Kilometraje = kilometraje;
    }

    
    public abstract void Encender();
    public abstract void Apagar();
    public abstract void Conducir(int km);
}

// Auto
public class Auto : Vehiculo
{
    
    public int NumeroDePuertas { get; set; }

   
    public Auto(string marca, string modelo, int año, int kilometraje, int numeroDePuertas)
        : base(marca, modelo, año, kilometraje)
    {
        NumeroDePuertas = numeroDePuertas;
    }

    
    public override void Encender()
    {
        Console.WriteLine($"El auto {Marca} {Modelo} está encendido.");
    }

    public override void Apagar()
    {
        Console.WriteLine($"El auto {Marca} {Modelo} está apagado.");
    }

    public override void Conducir(int km)
    {
        Kilometraje += km;
        Console.WriteLine($"El auto {Marca} {Modelo} ha conducido {km} km. Kilometraje total: {Kilometraje} km.");
    }
}

// Motocicleta
public class Motocicleta : Vehiculo
{
    
    public string TipoDeMoto { get; set; }


    public Motocicleta(string marca, string modelo, int año, int kilometraje, string tipoDeMoto)
        : base(marca, modelo, año, kilometraje)
    {
        TipoDeMoto = tipoDeMoto;
    }

    
    public override void Encender()
    {
        Console.WriteLine($"La motocicleta {Marca} {Modelo} está encendida.");
    }

    public override void Apagar()
    {
        Console.WriteLine($"La motocicleta {Marca} {Modelo} está apagada.");
    }

    public override void Conducir(int km)
    {
        Kilometraje += km;
        Console.WriteLine($"La motocicleta {Marca} {Modelo} ha conducido {km} km. Kilometraje total: {Kilometraje} km.");
    }
}

// Camion
public class Camion : Vehiculo
{
 
    public int CapacidadDeCarga { get; set; }

    
    public Camion(string marca, string modelo, int año, int kilometraje, int capacidadDeCarga)
        : base(marca, modelo, año, kilometraje)
    {
        CapacidadDeCarga = capacidadDeCarga;
    }

    public override void Encender()
    {
        Console.WriteLine($"El camión {Marca} {Modelo} está encendido.");
    }

    public override void Apagar()
    {
        Console.WriteLine($"El camión {Marca} {Modelo} está apagado.");
    }

    public override void Conducir(int km)
    {
        Kilometraje += km;
        Console.WriteLine($"El camión {Marca} {Modelo} ha conducido {km} km. Kilometraje total: {Kilometraje} km.");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        
        Auto miAuto = new Auto("Toyota", "Corolla", 2020, 10000, 4);
        Motocicleta miMoto = new Motocicleta("Yamaha", "MT-07", 2019, 5000, "Deportiva");
        Camion miCamion = new Camion("Mercedes-Benz", "Actros", 2018, 20000, 15000);

       
        miAuto.Encender();
        miAuto.Conducir(150);
        miAuto.Apagar();

        miMoto.Encender();
        miMoto.Conducir(100);
        miMoto.Apagar();

        miCamion.Encender();
        miCamion.Conducir(200);
        miCamion.Apagar();
    }
}