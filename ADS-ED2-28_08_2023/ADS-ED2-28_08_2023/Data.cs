namespace ADS_ED2_28_08_2023;

public class Data
{
    private int dia;
    private int mes;
    private int ano;

    public Data(){}
    
    public int Dia
    {
        get => dia;
        set => dia = value;
    }

    public int Mes
    {
        get => mes;
        set => mes = value;
    }

    public int Ano
    {
        get => ano;
        set => ano = value;
    }

    public void setData(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }

    public override string ToString()
    {
        return this.dia + "/" + this.mes + "/" + this.ano;
    }
}