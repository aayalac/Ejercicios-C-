class NumerosPares
{
    public static void GenerarNumerosPares()
    {
        Console.WriteLine("Ingrese Numero de inicio: ");        
        int NumeroInicio = int.Parse(Console.ReadLine());        
        int NumeroIndicado = NumeroInicio;
        Console.WriteLine("Ingrese Numero fin: ");
        int NumeroFin = int.Parse(Console.ReadLine());
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