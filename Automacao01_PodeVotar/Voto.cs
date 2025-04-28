namespace Automacao01_PodeVotar;

public class Voto
{
    public string podeVotar(int idade)
    {
        if (idade < 16) return "Não pode votar!";
        if (idade >= 18) return "Pode votar!";
        return "Voto opcional!";
    }
}

