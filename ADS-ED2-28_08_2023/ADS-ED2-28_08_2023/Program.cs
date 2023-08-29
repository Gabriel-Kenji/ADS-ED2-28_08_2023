using ADS_ED2_28_08_2023;

Contatos agenda = new Contatos();

while (true)
{
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("                 0 - Sair");
    Console.WriteLine("                 1 - Adicionar contato");
    Console.WriteLine("                 2 - Adicionar telefone no contato");
    Console.WriteLine("                 3 - Pesquisar contato");
    Console.WriteLine("                 4 - Alterar contato");
    Console.WriteLine("                 5 - Remover contato");
    Console.WriteLine("                 6 - Listar contatos");
    Console.WriteLine("-------------------------------------------------------------");
    Console.Write("Digite uma opção desejada: ");

    int opcao = Convert.ToInt32(Console.ReadLine());
    
    switch (opcao)
    {
        case 0:
            Console.WriteLine("Saindo...");
            return;
        case 1:
            Console.Write("Nome do contato: ");
            string nome = Console.ReadLine();
            Console.Write("Email do contato: ");
            string email = Console.ReadLine();
            Console.Write("Dia de nascimento: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mês de nascimento: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ano de nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Data dataNasc = new Data();
            dataNasc.setData(dia, mes, ano);
            Contato novoContato = new Contato(email, nome, dataNasc);
            agenda.adicionar(novoContato);
            Console.WriteLine("Contato adicionado com sucesso!");
            break;

        case 2:
            Console.Write("Email do contato: ");
            string emailPesquisa = Console.ReadLine();
            Contato contatoEncontrado = agenda.pesquisar(emailPesquisa);
            if (contatoEncontrado != null)
            {
                Console.Write("Tipo do telefone: ");
                string tipoTelefone = Console.ReadLine();
                Console.Write("Número do telefone: ");
                string numeroTelefone = Console.ReadLine();
                Console.Write("Telefone principal (S/N): ");
                bool principal = Console.ReadLine().ToUpper() == "S";

                Telefone novoTelefone = new Telefone(tipoTelefone, numeroTelefone, principal);
                contatoEncontrado.adicionarTelefone(novoTelefone);
                Console.WriteLine("Telefone adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }

            break;

        case 3:
            Console.Write("Email do contato: ");
            string emailPesquisa2 = Console.ReadLine();
            Contato contatoPesquisado = agenda.pesquisar(emailPesquisa2);
            if (contatoPesquisado != null)
            {
                Console.WriteLine(contatoPesquisado);
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }

            break;

        case 4:
            Console.Write("Email do contato: ");
            string emailPesquisa3 = Console.ReadLine();
            Contato contatoEncontrado2 = agenda.pesquisar(emailPesquisa3);
            if (contatoEncontrado2 != null)
            {
                Console.Write("Novo nome do contato: ");
                string? novoNome = Console.ReadLine();
                Console.Write("Nova data de nascimento:\nDia: ");
                int novoDia = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mês: ");
                int novoMes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ano: ");
                int novoAno = Convert.ToInt32(Console.ReadLine());

                Data novaDataNasc = new Data();
                novaDataNasc.setData(novoDia, novoMes, novoAno);
                Contato contatoModificado = new Contato(contatoEncontrado2.email, novoNome, novaDataNasc);
                if (agenda.alterar(contatoModificado))
                {
                    Console.WriteLine("Contato alterado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Falha ao alterar contato.");
                }
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }

            break;

        case 5:
            Console.Write("Email do contato: ");
            string emailPesquisa4 = Console.ReadLine();
            Contato contatoRemover = agenda.pesquisar(emailPesquisa4);
            if (contatoRemover != null)
            {
                agenda.remover(contatoRemover);
                Console.WriteLine("Contato removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }

            break;

        case 6:
            agenda.listar();
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
