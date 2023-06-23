// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Movimiento movimiento = new Movimiento();

        string continuar;

        do
        {
            Console.WriteLine("Selecciona el tipo de movimiento:");
            Console.WriteLine("1. Movimiento rectilíneo uniforme (MRU)");
            Console.WriteLine("2. Movimiento rectilíneo uniformemente acelerado (MRUV)");
            Console.WriteLine("3. Movimiento Circular Uniforme (MCU)");
            Console.WriteLine("4. Movimiento Parabólico (MP)");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    movimiento.MRU();
                    break;
                case 2:
                    movimiento.MRUV();
                    break;
                case 3:
                    movimiento.MCU();
                    break;
                case 4:
                    movimiento.MP();
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.Write("¿Deseas realizar un nuevo ejercicio? (si o no): ");
            continuar = Console.ReadLine();
        } while (continuar == "si" || continuar == "Si");
    }
}

public class Movimiento
{
    public void MRU()
    {
        Console.WriteLine("Selecciona la opcion que quieras calcular:");
        Console.WriteLine("1. Distancia");
        Console.WriteLine("2. Velocidad");
        Console.WriteLine("3. Tiempo");
        int opcion2 = int.Parse(Console.ReadLine());
        switch (opcion2)
        {
            case 1:
                CalcularDistanciaMRU();
                break;
            case 2:
                CalcularVelocidad();
                break;
            case 3:
                CalcularTiempoMRU();
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }

    public void MRUV()
    {
        Console.WriteLine("Selecciona la opcion que quieras calcular:");
        Console.WriteLine("1. Velocidad final (v)");
        Console.WriteLine("2. Distancia (x)");
        Console.WriteLine("3. Aceleracion (a)");
        Console.WriteLine("4. Tiempo (t)");
        int opcion2= int.Parse(Console.ReadLine());
        switch (opcion2)
        {
            case 1:
                CalcularVelocidadFinal();
                break;
            case 2:
                CalcularDistancia();
                break;
            case 3:
                CalcularAceleracion();
                break;
            case 4:
                CalcularTiempoMRUV();
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }

    public void MCU()
    {
        Console.WriteLine("Selecciona la opción que quieras calcular:");
        Console.WriteLine("1. Velocidad Angular");
        Console.WriteLine("2. Tiempo");
        int opcion2 = int.Parse(Console.ReadLine());

        switch (opcion2)
        {
            case 1:
                CalcularVelocidadAngular();
                break;
            case 2:
                CalcularTiempo();
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }

    public void MP()
    {
        Console.WriteLine("Selecciona la opción que quieras calcular:");
        Console.WriteLine("1. Alcance horizontal");
        Console.WriteLine("2. Altura máxima");
        int opcion2 = int.Parse(Console.ReadLine());

        switch (opcion2)
        {
            case 1:
                CalcularAlcanceHorizontal();
                break;
            case 2:
                CalcularAlturaMaxima();
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }

    public void CalcularDistanciaMRU()
    {
        Console.Write("Ingresa la velocidad en m/s: ");
        float v = float.Parse(Console.ReadLine());
        Console.Write("Ingresa el tiempo en s: ");
        float t = float.Parse(Console.ReadLine());
        Console.WriteLine("La distancia es: " + mruD(v,t) + " m.");
    }
    public float mruD(float v, float t){
        return v*t;
    }
    public void CalcularVelocidad()
    {
        Console.Write("Ingresa la distancia en m: ");
        float d = float.Parse(Console.ReadLine());
        Console.Write("Ingresa el tiempo en s: ");
        float t = float.Parse(Console.ReadLine());
        Console.WriteLine("La velocidad es: " + mruV(d,t) + " m/s.");           
    }
    public float mruV(float d, float t){
        return d/t;
    }
    public void CalcularTiempoMRU()
    {
        Console.Write("Ingresa la distancia en m: ");
        float d = float.Parse(Console.ReadLine());
        Console.Write("Ingresa la velocidad en m/s: ");
        float v = float.Parse(Console.ReadLine());
        Console.WriteLine("El tiempo es: " + mruT(d,v) + " s.");
    }
    public float mruT(float d, float v){
        return d/v;
    }
    public void CalcularVelocidadFinal()
    {
        Console.Write("Ingresa la velocidad inicial en m/s: ");
        float v0 = float.Parse(Console.ReadLine());
        Console.Write("Ingresa la aceleracion en m/s^2: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Ingresa el tiempo en s: ");
        float t = float.Parse(Console.ReadLine());
        Console.WriteLine("La velocidad final es: " + mruvVF(v0, a, t) + " m/s.");
    }
    public float mruvVF(float v0, float a, float t){
        return v0 + a * t;
    }
    public void CalcularDistancia()
    {
        Console.Write("Ingresa la velocidad inicial en m/s: ");
        float v0 = float.Parse(Console.ReadLine());
        Console.Write("Ingresa la aceleracion en m/s^2: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Ingresa el tiempo en s: ");
        float t = float.Parse(Console.ReadLine());
        Console.WriteLine("La distancia es: " + mruvD(v0, a, t) + " m.");
    }
        public float mruvD(float v0, float a, float t){
        return v0 * t + 0.5F * a * (t * t);
    }
    public void CalcularAceleracion()
    {
        Console.Write("Ingresa la velocidad final en m/s: ");
        float v = float.Parse(Console.ReadLine());
        Console.Write("Ingresa la velocidad inicial en m/s: ");
        float v0 = float.Parse(Console.ReadLine());
        Console.Write("Ingresa la distancia en m: ");
        float d = float.Parse(Console.ReadLine());
        Console.WriteLine("La aceleracion es: " + mruvA(v0, v, d) + " m/s^2.");
    }
        public float mruvA(float v0, float v, float d){
        return (v * v - v0 * v0) / (2 * d);
    }
    public void CalcularTiempoMRUV()
    {
        Console.Write("Ingresa la velocidad final en m/s: ");
        float v = float.Parse(Console.ReadLine());
        Console.Write("Ingresa la velocidad inicial en m/s: ");
        float v0 = float.Parse(Console.ReadLine());
        Console.Write("Ingresa la aceleracion en m/s^2: ");
        float a = float.Parse(Console.ReadLine());
            if (a != 0){
            Console.WriteLine("El tiempo es: " + mruvT(v0, v, a) + " s.");
            }
            else{
             Console.WriteLine("Aceleracion no puede ser cero cuando se calcula el tiempo.");
            }
    }
        public float mruvT(float v0, float v, float a){
        return  (v - v0) / a;
    }
    public void CalcularVelocidadAngular()
    {
        Console.Write("Ingresa el radio en metros: ");
        float r = float.Parse(Console.ReadLine());
        if (r < 0)
        {
            Console.WriteLine("Error: El radio no puede ser negativo.");
            return;
        }
        Console.Write("Ingresa el tiempo en segundos: ");
        float t = float.Parse(Console.ReadLine());
        if (t < 0)
        {
            Console.WriteLine("Error: El tiempo no puede ser negativo.");
            return;
        }
        Console.WriteLine("La velocidad angular es: " + mcuW(r,t) + " rad/s.");
    }
        public float mcuW(float r, float t){
        return  2 * (float)Math.PI * r / t;
    }

    public void CalcularTiempo()
    {
        Console.Write("Ingresa el radio en metros: ");
        float r = float.Parse(Console.ReadLine());
        if (r < 0)
        {
            Console.WriteLine("Error: El radio no puede ser negativo.");
            return;
        }
        Console.Write("Ingresa la velocidad angular en rad/s: ");
        float v = float.Parse(Console.ReadLine());
        if (v < 0)
        {
            Console.WriteLine("Error: La velocidad angular no puede ser negativa.");
            return;
        }
        Console.WriteLine("El tiempo es: " + mcuT(r,v) + " s.");
    }
        public float mcuT(float r, float v){
        return  2 * (float)Math.PI * r / v;
    }
    public void CalcularAlcanceHorizontal()
    {
        Console.Write("Ingresa la velocidad inicial en m/s: ");
        float v0 = float.Parse(Console.ReadLine());
        if (v0 < 0)
        {
            Console.WriteLine("Error: La velocidad inicial no puede ser negativa.");
            return;
        }
        Console.Write("Ingresa el ángulo de lanzamiento en grados: ");
        float theta = float.Parse(Console.ReadLine());
        if (theta < 0 || theta > 90)
        {
            Console.WriteLine("Error: El ángulo de lanzamiento debe estar entre 0 y 90 grados.");
            return;
        }
        Console.WriteLine("El alcance horizontal es: " + mpAH(v0, theta) + " m.");
    }
        public float mpAH(float v0, float theta){
        return  ((float)Math.Pow(v0, 2) * (float)Math.Sin(2 * theta)) / 9.81F;
    }

    public void CalcularAlturaMaxima()
    {
        Console.Write("Ingresa la velocidad inicial en m/s: ");
        float v0 = float.Parse(Console.ReadLine());
        if (v0 < 0)
        {
            Console.WriteLine("Error: La velocidad inicial no puede ser negativa.");
            return;
        }
        Console.Write("Ingresa el ángulo de lanzamiento en grados: ");
        float theta = float.Parse(Console.ReadLine());
        if (theta < 0 || theta > 90)
        {
            Console.WriteLine("Error: El ángulo de lanzamiento debe estar entre 0 y 90 grados.");
            return;
        }
        Console.WriteLine("La altura máxima es: " + mpAM(v0, theta) + " m.");
    }
        public float mpAM(float v0, float theta){
        return  ((float)Math.Pow(v0, 2) * (float)Math.Pow(Math.Sin(theta), 2)) / (2 * 9.81F);
    }
}

