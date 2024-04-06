//Variables
bool volver = true;
const double BONO = 0.4;

while (volver)
{
    decimal prestamo = 0, totalPrestamo= 0, prestamo2 = 0, totalPrestamo2 = 0, aporteMensual, aporteMensual2, rendimientoMensual, rendimientoMensual2, aporteTotal = 0, aporteTotal2 = 0, rendimientoTotal = 0, rendimientoTotal2 = 0, bonoMensual = 0, bonoMensual2 = 0, bonoTotal = 0, bonoTotal2 = 0, aporteTotalNeto, aporteTotalNeto2, tasaMensual;
    string continuar;
    int cantidadSocios;
    string prest;
    const decimal MULTA = 20000;



    //Clase random
    Random random = new Random();

    Console.WriteLine("Ingrese la cantidad de socios que desea calcular: ");
    cantidadSocios = Convert.ToInt32(Console.ReadLine());

    if (cantidadSocios == 1 )
    {
        for (int mes = 1; mes <= 12; mes++)
        {
            Console.Write($"Ingrese la cantidad que desea ahorrar en el mes {mes}: ");
            aporteMensual = Convert.ToDecimal(Console.ReadLine());
            aporteTotal += aporteMensual;

            Console.WriteLine("¿Desea realizar algún prestamo? (s/n)");
            prest = Console.ReadLine();

            if(prest == "s")
            {
                Console.WriteLine("¿Qué valor desea prestar?");
                prestamo = Convert.ToDecimal(Console.ReadLine());

                if (prestamo > aporteTotal)
                {
                    Console.WriteLine("Lo sentimos, la cantidad ingresada supera el valor total ahorrado");
                    prestamo = 0;
                }
                else if (prestamo < aporteTotal)
                {
                    Console.WriteLine($"Se le prestará el valor de {0}", prestamo);
                    totalPrestamo += prestamo;
                } 
            }
            else if(prest == "n")
            {
                Console.WriteLine("Usted seleccionó no usar la opción de prestamos");
            }

            tasaMensual = (decimal)random.Next(1, 51) / 10;
            rendimientoMensual = aporteMensual * (tasaMensual / 100);
            if (aporteMensual == 0)
            {
                Console.WriteLine("Usted no aportó nada este mes, se le multará por un valor de $20.000");
                rendimientoMensual = rendimientoMensual - MULTA;
            }
            else
            {
                tasaMensual = (decimal)random.Next(1, 51) / 10;
                rendimientoMensual = aporteMensual * (tasaMensual / 100);
            }

            if (tasaMensual < 3.5M)
            {
                bonoMensual = aporteMensual * (decimal)BONO;
                bonoTotal += bonoMensual;
                bonoMensual = 0;
            }

            aporteTotal += aporteMensual;
            rendimientoTotal += rendimientoMensual;

            Console.Write($"MES {mes}\n" +
                          $"Aportes: {aporteMensual:C}\n" +
                          $"Tasa: {tasaMensual}%\n" +
                          $"Rendimientos: {rendimientoMensual:C}\n" +
                          $"Bono: {bonoMensual:C}\n" +
                          $"Deducción por prestamos: -{totalPrestamo:C}\n" +
                          $"---------------------------------------\n" +
                          $" \n");
        }

        aporteTotalNeto = rendimientoTotal + aporteTotal + bonoTotal - prestamo;

        Console.Write($"Aportes totales: {aporteTotal:C}\n" +
                      $"Rendimientos totales: {rendimientoTotal:C}\n" +
                      $"Bonos totales: {bonoTotal:C}\n" +
                      $"Deducción por préstamos: -{totalPrestamo:C}\n" +
                      "--------------------------------\n" +
                      $"TOTAL NETO: {aporteTotalNeto:C}\n" +
                      $" \n");


        Console.WriteLine("¿Desea ingresar a la natillera para el siguiente año? (s/n)");
        continuar = Console.ReadLine().ToLower();
        if (continuar == "n") volver = false;
    }
    else if (cantidadSocios == 2)
    {
        for (int mes = 1; mes <= 12; mes++)
        {
            Console.Write($"Socio 1, ingrese la cantidad que desea ahorrar en el mes {mes}: ");
            aporteMensual = Convert.ToDecimal(Console.ReadLine());
            aporteTotal += aporteMensual;
            Console.WriteLine("¿Desea realizar algún prestamo? (s/n)");
            prest = Console.ReadLine();

            if (prest == "s")
            {
                Console.WriteLine("¿Qué valor desea prestar?");
                prestamo = Convert.ToDecimal(Console.ReadLine());

                if (prestamo > aporteTotal)
                {
                    Console.WriteLine("Lo sentimos, la cantidad ingresada supera el valor total ahorrado");
                    prestamo = 0;
                }
                else if(prestamo < aporteTotal)
                {
                    Console.WriteLine($"Se le prestará el valor de: " + prestamo);
                    totalPrestamo += prestamo;
                }
                
            }
            else if (prest == "n")
            {
                Console.WriteLine("Usted seleccionó no usar la opción de prestamos");
            }
            tasaMensual = (decimal)random.Next(1, 51) / 10;
            rendimientoMensual = aporteMensual * (tasaMensual / 100);
            if (aporteMensual == 0)
            {
                Console.WriteLine("Usted no aportó nada este mes, se le multará por un valor de $20.000");
                rendimientoMensual = rendimientoMensual - MULTA;
            }
            else
            {
             tasaMensual = (decimal)random.Next(1, 51) / 10;
             rendimientoMensual = aporteMensual * (tasaMensual / 100);
            }

            Console.Write($"Socio 2, ingrese la cantidad que desea ahorrar en el mes {mes}: ");
            aporteMensual2 = Convert.ToDecimal(Console.ReadLine());
            aporteTotal2 += aporteMensual2;
            Console.WriteLine("¿Desea realizar algún prestamo? (s/n)");
            prest = Console.ReadLine();

            if (prest == "s")
            {
                Console.WriteLine("¿Qué valor desea prestar?");
                prestamo2 = Convert.ToDecimal(Console.ReadLine());

                if (prestamo2 > aporteTotal2)
                {
                    Console.WriteLine("Lo sentimos, la cantidad ingresada supera el valor total ahorrado");
                    prestamo2 = 0;
                }
                else if (prestamo2 < aporteTotal2)    
                { 
                    Console.WriteLine($"Se le prestará el valor de: " + prestamo2);
                    totalPrestamo2 += prestamo2;
                }
            }
            else if (prest == "n")
            {
                Console.WriteLine("Usted seleccionó no usar la opción de prestamos");
            }
            rendimientoMensual2 = aporteMensual2 * (tasaMensual / 100);
            if (aporteMensual2 == 0)
            {
                Console.WriteLine("Usted no aportó nada este mes, se le multará por un valor de $20.000");
                rendimientoMensual2 = rendimientoMensual2 - MULTA;
            }
            else
            {
                tasaMensual = (decimal)random.Next(1, 51) / 10;
                rendimientoMensual2 = aporteMensual2 * (tasaMensual / 100);
            }


            if (tasaMensual < 3.5M)
            {
                bonoMensual = aporteMensual * (decimal)BONO;
                bonoTotal += bonoMensual;
                bonoMensual = 0;
                bonoMensual2 = aporteMensual2 * (decimal)BONO;
                bonoTotal2 += bonoMensual2;
                bonoMensual2 = 0;
            }

            
            rendimientoTotal += rendimientoMensual;
            aporteTotal2 += aporteMensual2;
            rendimientoTotal2 += rendimientoMensual2;

            Console.Write("Socio 1:\n" +
                          $"MES {mes}\n" +
                          $"Aportes: {aporteMensual:C}\n" +
                          $"Tasa: {tasaMensual}%\n" +
                          $"Rendimientos: {rendimientoMensual:C}\n" +
                          $"Bono: {bonoMensual:C}\n" +
                          $"---------------------------------------\n" +
                          $" \n");
            Console.Write("Socio 2:\n" +
                          $"MES {mes}\n" +
                          $"Aportes: {aporteMensual2:C}\n" +
                          $"Tasa: {tasaMensual}%\n" +
                          $"Rendimientos: {rendimientoMensual2:C}\n" +
                          $"Bono: {bonoMensual2:C}\n" +
                          $"---------------------------------------\n" +
                          $" \n");
        }

        aporteTotalNeto = rendimientoTotal + aporteTotal + bonoTotal - prestamo;
        aporteTotalNeto2 = rendimientoTotal2 + aporteTotal2 + bonoTotal2 - prestamo2;

        Console.Write("Socio 1: \n" +
                      $"Aportes totales: {aporteTotal:C}\n" +
                      $"Rendimientos totales: {rendimientoTotal:C}\n" +
                      $"Bonos totales: {bonoTotal:C}\n" +
                      $"Deducción por prestamos: -{totalPrestamo:C}\n" +
                      "--------------------------------\n" +
                      $"TOTAL NETO: {aporteTotalNeto:C}\n" +
                      $" \n");
        Console.Write("Socio 2: \n" +
                      $"Aportes totales: {aporteTotal2:C}\n" +
                      $"Rendimientos totales: {rendimientoTotal2:C}\n" +
                      $"Bonos totales: {bonoTotal2:C}\n" +
                      $"Deducción por prestamos: -{totalPrestamo2:C}\n" +
                      "--------------------------------\n" +
                      $"TOTAL NETO: {aporteTotalNeto2:C}\n" +
                      $" \n");


        Console.WriteLine("¿Desea ingresra a la natillera para el siguiente año? (s/n)");
        continuar = Console.ReadLine().ToLower();
        if (continuar == "n") volver = false;
    }
  
}