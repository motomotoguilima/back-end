public class Program
{
    public static void Main()
    {
        //o try serve para tratar um erro e não parar a execução do programa
        //se ocorrer qualquer erro dentro do bloco try o sistema interrompe a execução do bloco e vai para catch
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($" voce digito o nº {numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"o resultado é : {resultado}");

        }
        //tratando exceção de overflow (estouro do campo)
        catch(OverflowException)
        {
            Console.WriteLine("este numero inteiro e maior que o suportado");
        }
        catch (FormatException)
        {
            Console.WriteLine("erro: digite um numero inteiro");
        }
        //catch é o tratamento do erro, normalmente colocamos as mensagens de acordo com o tipo de erro,para melhorar compreensão do usuario
        catch (Exception ex)
        {
            Console.WriteLine($" ocorreu um erro : {ex.Message}");
        }
        //o finally e um bloco executado independentemente se ocorrer erro ou não 
        finally
        {
            Console.WriteLine("entrando no finally");
        }


    }
}

