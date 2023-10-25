﻿using GameMania.Menus;

Dictionary<string, Menu> opcoes = new Dictionary<string, Menu>(){
    {"0", new MenuSair()},
    {"1", new MenuCadastrarNovoJogo()},
    {"2", new MenuExibirJogoCadastrado()},
    {"3", new MenuExibirDetalhesDoJogo()},
    {"4", new MenuAvaliarJogosCadastrados()}
};

void ExibirMensagemBoasVindas(){
    Console.Clear();
    Console.WriteLine(@"
 ██████   █████  ███    ███ ███████ ███    ███  █████  ███   ██ ██  █████ 
██       ██   ██ ████  ████ ██      ████  ████ ██   ██ ████  ██ ██ ██   ██
██   ███ ███████ ██ ████ ██ █████   ██ ████ ██ ███████ ██ ██ ██ ██ ███████
██    ██ ██   ██ ██  ██  ██ ██      ██  ██  ██ ██   ██ ██  ████ ██ ██   ██
 ██████  ██   ██ ██      ██ ███████ ██      ██ ██   ██ ██   ███ ██ ██   ██");
}


void MenuPrincipal(){
    string? opcao = "1";
    while (opcao != "0"){
        ExibirMensagemBoasVindas();
        Console.WriteLine(" 0 - Sair");
        Console.WriteLine(" 1 - Cadastrar Novo Jogo");
        Console.WriteLine(" 2 - Listar Jogos Cadastrados ");
        Console.WriteLine(" 3 - Mostrar Detalhe de Jogo");
        Console.WriteLine(" 4 - Avaliar Jogo Disponivel");
        opcao = Console.ReadLine();
        opcao = string.IsNullOrEmpty(opcao)? "":opcao;//Warning
        if (opcoes.ContainsKey(opcao)){   
            opcoes[opcao].Executar();
        }else{
            Console.WriteLine("Opcao Invalida (Pressione qualquer tecla para continuar)");
            Console.ReadKey();
        }
    }
}
MenuPrincipal();
