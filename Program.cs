Console.Write("--- Imitando Dory ---\n");

Console.WriteLine("Digite uma mensagem...: ");
string mensagem = Console.ReadLine()!;

string mensagemEmBaleies = mensagem
    .Replace("a", "aaaaaaa")
    .Replace("A", "AAAAAAA")
    .Replace("e", "eeeeeee")
    .Replace("E", "EEEEEEE")
    .Replace("i", "iiiiiii")
    .Replace("I", "IIIIIII")
    .Replace("o", "ooooooo")
    .Replace("O", "OOOOOOO")
    .Replace("u", "uuuuuuu")
    .Replace("U", "UUUUUUU")
;

Console.WriteLine($"\nEm baleiês:\n\n{mensagemEmBaleies}");
