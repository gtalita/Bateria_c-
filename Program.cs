namespace Bateria1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r1 = 0, r2 = 0, repetidor = 0;
            Random ram1 = new Random();
            Random ram2 = new Random();

            Celula cel0 = new Celula();
            Celula cel1 = new Celula();
            Celula cel2 = new Celula();
            Celula cel3 = new Celula();

            Console.WriteLine("ANTES DO LOOP:");
            Console.WriteLine();
            Console.WriteLine("Carga da celula 1 = " + cel0.GetCarga());
            Console.WriteLine("Carga da celula 2 = " + cel1.GetCarga());
            Console.WriteLine("Carga da celula 3 = " + cel2.GetCarga());
            Console.WriteLine("Carga da celula 4 = " + cel3.GetCarga());
            Console.WriteLine("Carga total = " + cel0.GetCargaBateria());
            Console.WriteLine();
            Console.WriteLine("======================================================================");
            

            for (int i = 0; i <= 20; i++) 
            {
                r1 = ram1.Next(3);
                r2 = ram2.Next(1);
                switch (r1)
                {
                    case 0:

                        if((r2 == 0) && (cel0.GetCargaBateria() >= 5f) )
                        {
                            cel0.Consumir();
                        }
                        else if ((r2 == 1) && (cel0.GetCargaBateria() <= 95f))
                        {
                            cel0.Carregar();
                        }

                        break;

                    case 1:

                        if ((r2 == 0) && (cel0.GetCargaBateria() >= 5f))
                        {
                            cel1.Consumir();
                        }
                        else if ((r2 == 1) && (cel0.GetCargaBateria() <= 95f))
                        {
                            cel1.Carregar();
                        }

                        break;

                    case 2:

                        if ((r2 == 0) && (cel0.GetCargaBateria() >= 5f))
                        {
                            cel2.Consumir();
                        }
                        else if ((r2 == 1) && (cel0.GetCargaBateria() <= 95f))
                        {
                            cel2.Carregar();
                        }

                        break;

                    case 3:

                        if ((r2 == 0) && (cel0.GetCargaBateria() >= 5f))
                        {
                            cel3.Consumir();
                        }
                        else if ((r2 == 1) && (cel0.GetCargaBateria() <= 95f))
                        {
                            cel3.Carregar();
                        }

                        break;
                }

            
            }

            Console.WriteLine();
            Console.WriteLine("Clique em qualquer tecla para receber os resultados após o loop.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("APÓS O LOOP:");
            Console.WriteLine();
            Console.WriteLine("Carga da celula 1 = " + cel0.GetCarga());
            Console.WriteLine("Carga da celula 2 = " + cel1.GetCarga());
            Console.WriteLine("Carga da celula 3 = " + cel2.GetCarga());
            Console.WriteLine("Carga da celula 4 = " + cel3.GetCarga());
            Console.WriteLine("Carga total = " + cel0.GetCargaBateria());

        }

    }
    
}
