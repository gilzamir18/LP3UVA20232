﻿
using GameMania.Menus;
using GameMania.Modelos;
using GameMania.Dados;

Dictionary<string, Menu> opcoes = new Dictionary<string, Menu>();
opcoes["1"] = new MenuCadastrarNovoJogo();
opcoes["2"] = new MenuExibirJogosCadastrados();
opcoes["3"] = new MenuExibirDetalhesDoJogo();
opcoes["4"] = new MenuAvaliarJogosCadastrados();
opcoes["0"] = new MenuSair();

void ExibirMensagemBoasVindas()
{
    Console.Clear();
    Console.WriteLine(@"
░██████╗░░█████╗░███╗░░░███╗███████╗███╗░░░███╗░█████╗░███╗░░██╗██╗░█████╗░
██╔════╝░██╔══██╗████╗░████║██╔════╝████╗░████║██╔══██╗████╗░██║██║██╔══██╗
██║░░██╗░███████║██╔████╔██║█████╗░░██╔████╔██║███████║██╔██╗██║██║███████║
██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░██║╚██╔╝██║██╔══██║██║╚████║██║██╔══██║
╚██████╔╝██║░░██║██║░╚═╝░██║███████╗██║░╚═╝░██║██║░░██║██║░╚███║██║██║░░██║
░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝╚═╝░░╚═╝");
    Console.WriteLine("Seja bem-vindo ao GAMEMANIA!");
}


void MenuPrincipal()
{

    while (true)
    {
        ExibirMensagemBoasVindas();
        Console.WriteLine("1 - Cadastrar novo Jogo");
        Console.WriteLine("2 - Exibir jogos cadastrados ");
        Console.WriteLine("3 - Mostrar detalhes dos jogos");
        Console.WriteLine("4 - Avaliar jogo");
        Console.WriteLine("0 - Sair");
        string opcao = Console.ReadLine();
        if (opcoes.ContainsKey(opcao))
        {   
            bool sair = opcoes[opcao].Executar();
            if (sair)
            {
                break;
            }
        }
        else
        {
            Console.WriteLine("Opcao Inválida!. Tente novamente. Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

///MenuPrincipal();
IJogoDAO dao = SQLiteJogoDAO.GetInstance();

Jogo jogo = new Jogo("Forza", "Corrida", "XBox Game Studios", "5");
jogo.AdicionarNota(new Avaliacao(10));
jogo.AdicionarNota(new Avaliacao(5));
jogo.AdicionarNota(new Avaliacao(2));
jogo.AdicionarPlataforma("XBoxLive");
jogo.AdicionarPlataforma("PC");

dao.SalvarJogo(jogo);
