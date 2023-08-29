namespace ADS_ED2_28_08_2023;

public class Contato
{
    public string email;
    private string? nome;
    private Data dtNasc;
    private List<Telefone> telefones = new List<Telefone>();

    public Contato(string email, string? nome, Data dtNasc)
    {
        this.email = email;
        this.nome = nome;
        this.dtNasc = dtNasc;
    }

    public int getIdade()
    {
        DateTime hoje = DateTime.Today;
        int idade = hoje.Year - dtNasc.Ano;
        if (hoje.Month < dtNasc.Mes || (hoje.Month == dtNasc.Mes && hoje.Day < dtNasc.Mes))
            idade--;
        return idade;
    }

    public void adicionarTelefone(Telefone t)
    {
        telefones.Add(t);
    }

    public string getTelefonePrincipal()
    { foreach (Telefone telefone in telefones) {
            if (telefone.principal)
                return telefone.numero;
        }
        return "Nenhum telefone principal";
    }

    public override string ToString()
    {
        string telefonePrincipal = getTelefonePrincipal();
        return $"Nome: {nome}\nEmail: {email}\nData de Nascimento: {dtNasc}\nTelefone Principal: {telefonePrincipal}";
    }

    public override bool Equals(object obj)
    {  if (obj == null || GetType() != obj.GetType())
            return false;
        Contato other = (Contato)obj;
        return email == other.email;
    }
}