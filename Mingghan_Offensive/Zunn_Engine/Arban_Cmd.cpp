#include <iostream>

// O bloco extern "C" garante que o nome da função não seja alterado pelo compilador.
// __declspec(dllexport) torna a função visível para o Orquestrador C#.
extern "C" {
    __declspec(dllexport) void ExecuteHordaCommand() {
        std::cout << "[Zunn_Core] Conexao Estabelecida: Motor Ofensivo em Standby..." << std::endl;
        std::cout << "[Zunn_Core] Aguardando coordenadas de Arban_Cmd via Mnemios..." << std::endl;
    }
}
