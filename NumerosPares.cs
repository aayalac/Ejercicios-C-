class NumerosPares
{
    public static void GenerarNumerosPares()
    {
        Console.WriteLine("Ingrese Numero de inicio: ");
        #pragma warning disable CS8604 // Posible argumento de referencia nulo
        int NumeroInicio = int.Parse(Console.ReadLine());
        #pragma warning restore CS8604 // Posible argumento de referencia nulo
        
        int NumeroIndicado = NumeroInicio;

        Console.WriteLine("Ingrese Numero fin: ");
        #pragma warning disable CS8604 // Posible argumento de referencia nulo
        int NumeroFin = int.Parse(Console.ReadLine());        
        #pragma warning restore CS8604 // Posible argumento de referencia nulo

        int Resultado = 0;

        for (int i = NumeroInicio; i <= NumeroFin; i++)
        {
            int numeroEvaluado = i;
            if (numeroEvaluado %2 == 0)
            {
                Resultado = numeroEvaluado + Resultado;
                Console.WriteLine($"Suma parcial: {Resultado}");
            }
        }
        Console.WriteLine($"La suma de pares entre {NumeroIndicado} y {NumeroFin} es {Resultado}");
    }
}