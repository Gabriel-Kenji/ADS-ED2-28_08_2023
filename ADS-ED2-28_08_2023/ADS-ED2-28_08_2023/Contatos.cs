namespace ADS_ED2_28_08_2023;

public class Contatos
{
    private List<Contato> agenda = new List<Contato>();

    public bool adicionar(Contato c)
    {if (!agenda.Contains(c))
        {
            agenda.Add(c);
            return true;
        }
        return false;
    }

    public Contato pesquisar(string email)
    {
        return agenda.Find(c => c.email == email);
    }

    public bool alterar(Contato contatoModificado)
    { int index = agenda.FindIndex(item => item.email == contatoModificado.email);
        if (index != -1)
        {
            agenda[index] = contatoModificado;
            return true;
        }
        return false;
    }

    public bool remover(Contato c)
    { return agenda.Remove(c);
    }

    public void listar()
    {
        foreach (Contato c in agenda)
        {
            Console.WriteLine(c);
            Console.WriteLine();
        }
    }
}