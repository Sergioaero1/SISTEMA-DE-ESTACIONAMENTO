# 🚗 DIO - Trilha .NET: Fundamentos  
🔗 [www.dio.me](https://www.dio.me)

## 💡 Desafio de Projeto: Sistema de Estacionamento

Este projeto faz parte da trilha de Fundamentos .NET da DIO. O objetivo é aplicar os conhecimentos adquiridos para desenvolver um sistema funcional de gerenciamento de veículos em um estacionamento.

---

## 📦 Contexto

Você foi contratado para desenvolver um sistema de controle de estacionamento. Ele deve permitir:

- ✅ Adicionar veículos
- ✅ Remover veículos (calculando o valor a ser pago)
- ✅ Listar os veículos estacionados

---

## 🧠 Proposta Técnica

Implemente a classe `Estacionamento` conforme o diagrama abaixo:  
📎 *[Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)*

### 🧱 Estrutura da Classe

| Variável       | Tipo     | Descrição                                                  |
|----------------|----------|-------------------------------------------------------------|
| `precoInicial` | `decimal`| Valor fixo cobrado ao estacionar                           |
| `precoPorHora` | `decimal`| Valor cobrado por hora de permanência                      |
| `veiculos`     | `List<string>` | Lista contendo as placas dos veículos estacionados |

### 🔧 Métodos

- `AdicionarVeiculo()`  
  Recebe a placa do veículo e adiciona à lista.

- `RemoverVeiculo()`  
  Verifica se o veículo está estacionado, solicita a quantidade de horas e calcula o valor total:  
  **`valorTotal = precoInicial + (precoPorHora * horas)`**

- `ListarVeiculos()`  
  Exibe todos os veículos estacionados ou uma mensagem informando que não há veículos.

---

## 🖥️ Menu Interativo

O sistema deve apresentar as seguintes opções ao usuário:

- Cadastrar veículo
- Remover veículo
- Listar veículos
- Encerrar


---

## 🛠️ Solução

O código base está parcialmente implementado. Procure pelas marcações `// TODO` e complete as funcionalidades conforme as regras acima.

---

## 🚀 Tecnologias Utilizadas

- .NET 6+
- C#
- Programação Orientada a Objetos (POO)
- Console Application

---

## 🧪 Teste e Validação

Após implementar, execute o programa e teste todos os cenários:

- Inserção de múltiplos veículos
- Remoção com cálculo correto
- Listagem com e sem veículos

---

## 🤝 Contribuição

Sinta-se à vontade para abrir issues, propor melhorias ou enviar pull requests. Vamos construir juntos!

---

## 🧭 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

Engenheiro: [SERGIOAERO](https://github.com/SERGIOAERO)

