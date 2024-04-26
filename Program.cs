Console.Clear();
string senha;
 
Console.Write("Olá, usuário. Por favor, digite sua senha: ");
senha = Convert.ToString(Console.ReadLine())!;
 
if (senha != Convert.ToString("1234abcd"))
{
    Console.WriteLine("Acesso negado");
}
else
{
    Console.WriteLine("Acesso permitido");
}
