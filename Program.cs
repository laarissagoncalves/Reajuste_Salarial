namespace Reajuste_Salarial{
    class Program{
        public static void Main (string[] args){

            /*Construa um algoritmo que calcule o novo salário para 
            cada um dos funcionários da empresa. Considere que o funcionário 
            deverá receber um reajuste de 15% caso seu salário seja menor que 
            500. Se o salário for maior ou igual a 500, mas menor ou igual a 
            1000, o reajuste deve ser de 10%. Caso o salário seja maior que 
            1000, o reajuste deve ser de 5%. O programa deve parar quando for 
            digitado um salário com valor negativo, ou seja, inválido. Além 
            disso, ao final, o programa deve apresentar quanto será gasto a 
            mais pela empresa com esses aumentos.*/

            double sal, salnovo, emp, emptt;

            Console.WriteLine("Valor do reajuste salarial");
            Console.WriteLine("- Para encerrar digite qualquer número negativo em salário.");
            salnovo = 0;
            emptt = 0;
            do{
                Console.WriteLine("");
                Console.Write("Entre com o valor do salário do funcionário: ");
                sal = double.Parse(Console.ReadLine());
                if (sal > 0){
                    //Reajuste de 15%
                    if (sal < 500){
                        salnovo = (sal * 0.15) + sal;
                        Console.WriteLine("O valor do salário após reajuste de 15% é de R${0:N}.", salnovo);
                    }
                    else
                        //Reajuste de 10%
                        if (sal >= 500 && sal <= 1000){
                            salnovo = (sal * 0.10) + sal;
                            Console.WriteLine("O valor do salário após reajuste de 10% é R${0:N}.", salnovo);                    
                        }
                        else
                            //Reajuste de 5%
                            if (sal > 1000){
                                salnovo = (sal * 0.05) + sal;
                                Console.WriteLine ("O valor do salário após reajuste de 5% é R${0:N}.", salnovo);
                            }
                }
                //Calculo do valor a ser gasto pela empresa com os reajustes
                emp = salnovo - sal;
                emptt = emptt + emp;
                if (sal < 0)
                    Console.WriteLine("");
            } while (sal > 0);
            Console.WriteLine($"O total a ser gasto com os reajustes é R${emptt:N}");
        } 
    }
}
