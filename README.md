### 📄 README.md — Jogo da Velha CMD

# 🕹️ Jogo da Velha — Terminal
Este projeto implementa o clássico **Jogo da Velha** para dois jogadores, com execução via **terminal (CMD)**. Desenvolvido com foco na prática de lógica de programação e estruturação de código, ele representa meu **primeiro projeto na área de desenvolvimento de software**.

---

## 📌 Objetivo
O principal objetivo deste projeto é consolidar os conhecimentos iniciais em lógica de programação, estrutura de dados e entrada/saída no terminal. Foi também uma oportunidade de aplicar boas práticas na construção de um programa simples, porém funcional e interativo.

---

## ⚙️ Tecnologias Utilizadas
- **Linguagem:** C  
- **Compilador:** GCC (ou compatível)
- **Ambiente:** Windows CMD / Linux Terminal
- **Recursos utilizados:**
  - `stdio.h` para entrada e saída padrão
  - `stdlib.h` para manipulações básicas
  - Funções e estruturas condicionais (`if`, `switch`)
  - Estruturas de repetição (`while`, `for`)
  - Vetores e manipulação de strings

---

## 🧩 Funcionalidades
- Interface baseada em terminal (modo texto)
- Modo de jogo para dois jogadores
- Verificação automática de vitória, empate ou jogadas inválidas
- Reinício automático após término da partida

---

## 🛠️ Como Executar
1. **Clone o repositório:**
git clone https://github.com/seu-usuario/Jvelha01.git
cd Jvelha01

2. **Compile o projeto:**
gcc jogo_da_velha.c -o jogo_da_velha

3. **Execute o programa:**
./jogo_da_velha

> 💡 Caso esteja utilizando o Windows, você pode compilar usando o Dev-C++ ou Code::Blocks, ou usar `gcc` com o terminal do MinGW.

---

## 📁 Estrutura do Projeto
Jvelha01/
├── jogo_da_velha.c     # Código-fonte principal
├── README.md           # Documentação
└── LICENSE             # (opcional)

---

## 💡 Aprendizados
Durante o desenvolvimento deste projeto, aprofundei meus conhecimentos em:
- Estruturação de código em C
- Uso de vetores para representar tabuleiros
- Validação de entrada de usuário
- Controle de fluxo em jogos por turno
- Prática com compilação e execução de programas via terminal
