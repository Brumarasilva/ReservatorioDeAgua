
using System.Collections;

//string A="", B= "", C="";
Console.WriteLine("Insira a condição A: ");
string A = Console.ReadLine();
Console.WriteLine("Insira a condição B: ");
string B = Console.ReadLine();
Console.WriteLine("Insira a condição C: ");
string C = Console.ReadLine();

if( A == "0" && B == "0" && C == "0")
{
Console.WriteLine("eletroválvula S2 e S1 está desligada! Favor ligar eletroválvula S2.");
}

else if(A == "0" && B == "0" && C == "1")

{
Console.WriteLine("Ligar a eletroválvula S2 e desligar a eletroválvula S1.");
}

else if(A == "0" && B == "1" && C == "0")

{
Console.WriteLine("Erro! Acionar o técnico responsável. Desligar eletroválvula S1, S2.");
}

else if(A == "0" && B == "1" && C == "1")

{
Console.WriteLine("Erro! Acionar o técnico responsável. Desligar eletroválvula S1, S2.");
}

else if(A == "1" && B == "0" && C == "0")

{
Console.WriteLine("Ligar eltroválvula S2 e S1.");
}

else if(A == "1" && B == "0" && C == "1")

{
Console.WriteLine("Ligar eletroválvula S2 pra terminar de encher. Desligar a eletroválvula S1, que está cheia.");
}

else if(A == "1" && B == "1" && C == "0")

{
Console.WriteLine("Desligar eletroválvula S2, pois já está cheia. Ligar S1 que está vazia.");
}

else if(A == "1" && B == "1" && C == "1")

{
Console.WriteLine("Desligar eletroválvula S2, S1.");
}







    

