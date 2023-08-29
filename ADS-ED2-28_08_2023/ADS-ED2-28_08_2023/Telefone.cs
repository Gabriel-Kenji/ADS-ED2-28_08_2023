namespace ADS_ED2_28_08_2023;

public class Telefone
{
    public string tipo;
    public string numero;
    public bool principal;

    public Telefone(string tipo, string numero, bool principal)
    {
        this.tipo = tipo;
        this.numero = numero;
        this.principal = principal;
    }
}