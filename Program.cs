using Curso_C_;
using Curso_C_.Paradigmas;
using Curso_C_.ParadigmasOO;
using GerenciamentoBar;
using System;
using System.Collections.Generic;
using System.Text.Json;

/*namespace BibliotecaVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialização de objetos
            Biblioteca biblioteca = new Biblioteca();
            Garagem garagem = new Garagem();
            Usuario usuario = new Usuario("João Silva", "12345678900");
            Cliente cliente = new Cliente("Maria Oliveira", "98765432100");

            // Loop do menu principal
            int opcao = 0;
            do
            {
                Console.Clear(); // Limpa a tela para uma melhor organização visual
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Sistema de Gerenciamento de Veículos");
                Console.WriteLine("0. Sair");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca(biblioteca, usuario);
                        break;
                    case 2:
                        MenuVeiculos(garagem, cliente);
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca(Biblioteca biblioteca, Usuario usuario)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("5. Exibir Livros Emprestados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro(biblioteca);
                        break;
                    case 2:
                        biblioteca.ListarLivros();
                        break;
                    case 3:
                        EmprestarLivro(biblioteca, usuario);
                        break;
                    case 4:
                        DevolverLivro(biblioteca, usuario);
                        break;
                    case 5:
                        usuario.ExibirLivrosEmprestados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuVeiculos(Garagem garagem, Cliente cliente)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=======   SISTEMA DE VEÍCULOS - GARAGEM   =====");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("3. Comprar Veículo");
                Console.WriteLine("4. Vender Veículo");
                Console.WriteLine("5. Exibir Veículos Comprados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarVeiculo(garagem);
                        break;
                    case 2:
                        ListarVeiculos(garagem);
                        break;
                    case 3:
                        ComprarVeiculo(garagem, cliente);
                        break;
                    case 4:
                        VenderVeiculo(garagem);
                        break;
                    case 5:
                        cliente.ExibirVeiculosComprados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void AdicionarLivro(Biblioteca biblioteca)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
        }

        static void EmprestarLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   EMPRÉSTIMO DE LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser emprestado: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.EmprestarLivro(livro, biblioteca);
                Console.WriteLine("\nLivro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado no acervo.");
            }
        }

        static void DevolverLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("===========   DEVOLUÇÃO DE LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser devolvido: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.DevolverLivro(livro, biblioteca);
                Console.WriteLine("\nLivro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado na lista de empréstimos.");
            }
        }

        static void AdicionarVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO VEÍCULO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite a marca do veículo: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o ano do veículo: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a quilometragem do veículo: ");
            int quilometragem = int.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(marca, modelo, ano, quilometragem);
            garagem.AdicionarVeiculo(veiculo);
            Console.WriteLine("\nVeículo adicionado com sucesso!");
        }

        static void ListarVeiculos(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======   LISTA DE VEÍCULOS DISPONÍVEIS   =====");
            Console.WriteLine("==============================================");
            var veiculos = garagem.ListarTodosVeiculos(); // Obtém todos os veículos da garagem

            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo disponível.");
            }
            else
            {
                foreach (var veiculo in veiculos) // Itera sobre a lista de veículos
                {
                    veiculo.ExibirDetalhes(); // Exibe os detalhes de cada veículo
                }
            }
        }

        static void ComprarVeiculo(Garagem garagem, Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   COMPRA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser comprado: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                cliente.ComprarVeiculo(veiculo, garagem);
                Console.WriteLine("\nVeículo comprado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }

        static void VenderVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   VENDA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser vendido: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                garagem.VenderVeiculo(veiculo);
                Console.WriteLine("\nVeículo vendido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }
    }
}
*/

/*// Instância de Cachorro
Cachorro cachorro = new Cachorro("Rex");
cachorro.ExibirInformacoes();
cachorro.FazerSom();
cachorro.ExplicarHeranca();

// Instância de Gato
Gato gato = new Gato("Mimi");
gato.ExibirInformacoes();
gato.FazerSom();
gato.ExplicarHeranca();*/

/*// Criando um objeto Endereco que pode existir independentemente
Endereco endereco = new Endereco("Rua Principal", "Cidade Exemplo");

// Criando um objeto Pessoa que contém um Endereco (agregação)
PessoaAgrecacao pessoa = new PessoaAgrecacao("João", endereco);

// Exibir as informações da pessoa e seu endereço
pessoa.ExibirInformacoes();

// Explicando o conceito de agregação
pessoa.ExplicarAgregacao();*/

/*// Criando um objeto Departamento
Departamento departamento = new Departamento("Recursos Humanos");

// Criando um objeto Funcionario que está associado a um Departamento
Funcionario funcionarioComDepartamento = new Funcionario("Ana", departamento);

// Criando um objeto Funcionario sem associação a nenhum Departamento
Funcionario funcionarioSemDepartamento = new Funcionario("Carlos");

// Exibir as informações dos funcionários
funcionarioComDepartamento.ExibirInformacoes();
funcionarioSemDepartamento.ExibirInformacoes();

// Explicando o conceito de associação
funcionarioComDepartamento.ExplicarAssociacao();*/

/*// Criando um objeto Carro, que inclui a criação de um Motor
Carro carro = new Carro("Fusca", "Motor 1600");

// Exibindo informações sobre o carro e seu motor
carro.ExibirInformacoes();

// Explicando o conceito de composição
carro.ExplicarComposicao();*/

// Criando funcionários
/*FuncionarioMulti funcionario1 = new FuncionarioMulti("Ana");
FuncionarioMulti funcionario2 = new FuncionarioMulti("Carlos");

// Criando um projeto
Projeto projeto = new Projeto("Desenvolvimento de Software");

// Adicionando funcionários ao projeto
projeto.AdicionarFuncionario(funcionario1);
projeto.AdicionarFuncionario(funcionario2);

// Exibindo informações sobre o projeto e seus funcionários
projeto.ExibirInformacoes();

// Explicando o conceito de multiplicidade
projeto.ExplicarMultiplicidade();*/

/*//Classe Abstrata
AnimalAbs cachorro = new CachorroAbs("Rex");
AnimalAbs gato = new GatoAbs("Mimi");

// Exibindo informações e fazendo som dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de classe abstrata
cachorro.ExplicarClasseAbstrata();*/

/*// Criando instâncias de classes que implementam a interface
IAnimal cachorro = new CachorroInter("Rex");
IAnimal gato = new GatoInter("Mimi");

// Exibindo informações e sons dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de interface
ExplicadorDeInterface explicador = new ExplicadorDeInterface();
explicador.ExplicarInterface();*/

/*var exp = new ExplicadoraDePolimorfismo();
AnimalPoli[] animais = new AnimalPoli[3];
animais[0] = new CachorroPoli("Rex");
animais[1] = new GatoPoli("Mimi");
animais[2] = new AnimalPoli("Dinossauro");

foreach (AnimalPoli animal in animais)
{
    animal.FazerSom(); // Comportamento polimórfico
}
exp.ExplicarPolimorfismo();*/

/*namespace BibliotecaVeiculos
{
    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();
        static Biblioteca biblioteca = new Biblioteca();

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Gerenciar Usuários");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca();
                        break;
                    case 2:
                        MenuUsuarios();
                        break;
                    case 0:
                        SalvarDados(); // Salva dados antes de sair
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro();
                        break;
                    case 2:
                        biblioteca.ObterLivros().ForEach(livro => livro.ExibirDetalhes());
                        break;
                    case 3:
                        EmprestarLivro();
                        break;
                    case 4:
                        DevolverLivro();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuUsuarios()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   GERENCIAR USUÁRIOS   ============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Usuário");
                Console.WriteLine("2. Listar Usuários");
                Console.WriteLine("3. Remover Usuário");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarUsuario();
                        break;
                    case 2:
                        ListarUsuarios();
                        break;
                    case 3:
                        RemoverUsuario();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void AdicionarUsuario()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO USUÁRIO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do usuário: ");
            string cpf = Console.ReadLine();

            // Verificar se o CPF já existe
            if (usuarios.Any(u => u.Cpf == cpf))
            {
                Console.WriteLine("\nUsuário com este CPF já existe.");
                return;
            }

            Usuario usuario = new Usuario(nome, cpf);
            usuarios.Add(usuario);
            Console.WriteLine("\nUsuário adicionado com sucesso!");

            // Atualizar o arquivo JSON
            SalvarUsuarios();
        }

        static void ListarUsuarios()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\Curso_Csharp\Usuarios.json";
            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    string json = File.ReadAllText(caminhoArquivo);
                    var dados = JsonSerializer.Deserialize<Dados>(json);

                    if (dados != null && dados.Usuarios != null)
                    {
                        Console.WriteLine("==============================================");
                        Console.WriteLine("=========   LISTA DE USUÁRIOS CADASTRADOS   =========");
                        Console.WriteLine("==============================================");

                        if (dados.Usuarios.Count == 0)
                        {
                            Console.WriteLine("\nNenhum usuário cadastrado.");
                        }
                        else
                        {
                            for (int i = 0; i < dados.Usuarios.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {dados.Usuarios[i].Nome} - CPF: {dados.Usuarios[i].Cpf}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos ou a lista de usuários está vazia.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar ou desserializar o JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON não encontrado.");
            }
        }

        static void RemoverUsuario()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário a ser removido: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < usuarios.Count)
            {
                usuarios.RemoveAt(indice);
                Console.WriteLine("\nUsuário removido com sucesso!");
                SalvarUsuarios(); // Atualiza o arquivo após remoção
            }
            else
            {
                Console.WriteLine("\nNúmero inválido.");
            }
        }

        static void AdicionarLivro()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
            SalvarLivros(); // Atualiza o arquivo após adicionar livro
        }

        static void EmprestarLivro()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário que irá emprestar o livro: ");
            int usuarioIndice = int.Parse(Console.ReadLine()) - 1;

            if (usuarioIndice >= 0 && usuarioIndice < usuarios.Count)
            {
                Usuario usuario = usuarios[usuarioIndice];
                Console.Write("Digite o título do livro: ");
                string titulo = Console.ReadLine();
                Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);

                if (livro != null)
                {
                    usuario.EmprestarLivro(livro, biblioteca);
                    SalvarEmprestimos(); // Atualiza o arquivo de empréstimos após emprestar livro
                }
                else
                {
                    Console.WriteLine("\nLivro não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de usuário inválido.");
            }
        }

        static void DevolverLivro()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário que irá devolver o livro: ");
            int usuarioIndice = int.Parse(Console.ReadLine()) - 1;

            if (usuarioIndice >= 0 && usuarioIndice < usuarios.Count)
            {
                Usuario usuario = usuarios[usuarioIndice];
                Console.Write("Digite o título do livro: ");
                string titulo = Console.ReadLine();
                Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);

                if (livro != null)
                {
                    usuario.DevolverLivro(livro, biblioteca);
                    SalvarEmprestimos(); // Atualiza o arquivo de empréstimos após devolver livro
                }
                else
                {
                    Console.WriteLine("\nLivro não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de usuário inválido.");
            }
        }

        static void CarregarDados()
        {
            // Carregar usuários
            string caminhoUsuarios = @"C:\Users\Aluno Noite\Desktop\Curso_Csharp\Usuarios.json";
            if (File.Exists(caminhoUsuarios))
            {
                string json = File.ReadAllText(caminhoUsuarios);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        usuarios = dados.Usuarios;
                        Console.WriteLine("Usuários carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos usuários: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de usuários não encontrado.");
            }

            // Carregar livros
            string caminhoLivros = @"C:\Users\Professor\Desktop\Conteudo do Curso Tecnico\Curso C#\livros.json";
            if (File.Exists(caminhoLivros))
            {
                string json = File.ReadAllText(caminhoLivros);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        biblioteca = new Biblioteca();
                        foreach (var livro in dados.Livros)
                        {
                            biblioteca.AdicionarLivro(livro);
                        }
                        Console.WriteLine("Livros carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos livros: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de livros não encontrado.");
            }

            // Carregar empréstimos (se necessário para inicializar estado)
            string caminhoEmprestimos = @"C:\Users\Professor\Desktop\Conteudo do Curso Tecnico\Curso C#\emprestimos.json";
            if (File.Exists(caminhoEmprestimos))
            {
                string json = File.ReadAllText(caminhoEmprestimos);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null && dados.Emprestimos != null)
                    {
                        foreach (var emprestimo in dados.Emprestimos)
                        {
                            // Aqui você pode adicionar lógica para processar empréstimos carregados
                        }
                        Console.WriteLine("Empréstimos carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos empréstimos: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de empréstimos não encontrado.");
            }
        }

        static void SalvarUsuarios()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\Curso_Csharp\Usuarios.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = usuarios,
                    Livros = new List<Livro>(), // Lista vazia
                    Emprestimos = new List<Emprestimo>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Usuários salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar usuários: {ex.Message}");
            }
        }

        static void SalvarLivros()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\Curso_Csharp\Livros.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = new List<Usuario>(), // Lista vazia
                    Livros = biblioteca.ObterLivros(),
                    Emprestimos = new List<Emprestimo>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Livros salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar livros: {ex.Message}");
            }
        }

        static void SalvarEmprestimos()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Desktop\Curso_Csharp\Emprestimos.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = new List<Usuario>(), // Lista vazia
                    Livros = new List<Livro>(), // Lista vazia
                    Emprestimos = usuarios.SelectMany(u => u.LivrosEmprestados.Select(l => new Emprestimo
                    {
                        UsuarioCpf = u.Cpf,
                        LivroTitulo = l.Titulo,
                        DataEmprestimo = DateTime.Now // Aqui seria ideal colocar a data real do empréstimo
                    })).ToList()
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Empréstimos salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar empréstimos: {ex.Message}");
            }
        }

        static void SalvarDados()
        {
            SalvarUsuarios();
            SalvarEmprestimos();
            SalvarLivros();
        }
    }

    public class Dados
    {
        public List<Usuario> Usuarios { get; set; }
        public List<Livro> Livros { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }
    }
}*/






using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SistemaGerenciamentoBar
{
    class Program
    {
        static List<Produto> produtos = new List<Produto>();
        static List<Consumidor> consumidores = new List<Consumidor>();
        static List<Consumo> consumos = new List<Consumo>();

        static string caminhoProdutos = @"C:\Users\Aluno Noite\Desktop\Curso_Csharp\produtos.json"; // Caminho para o arquivo produtos.json
        static string caminhoConsumidores = @"C:\Users\Aluno Noite\Desktop\Curso_Csharp\Consumidores.json"; // Caminho para o arquivo consumidores.json
        static string caminhoConsumos = @"C:\Users\Aluno Noite\Desktop\Curso_Csharp\consumos.json"; // Caminho para o arquivo consumos.json

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=========  SISTEMA DE GERENCIAMENTO  =========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Gerenciar Produtos");
                Console.WriteLine("2. Gerenciar Consumidores");
                Console.WriteLine("3. Gerenciar Consumos");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuProdutos();
                        break;
                    case 2:
                        MenuConsumidores();
                        break;
                    case 3:
                        MenuConsumos();
                        break;
                    case 0:
                        SalvarDados();
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuProdutos()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=========   GERENCIAR PRODUTOS   =============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Atualizar Produto");
                Console.WriteLine("4. Remover Produto");
                Console.WriteLine("0. Voltar");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarProduto();
                        break;
                    case 2:
                        ListarProdutos();
                        break;
                    case 3:
                        AtualizarProduto();
                        break;
                    case 4:
                        RemoverProduto();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuConsumidores()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("========   GERENCIAR CONSUMIDORES  ===========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Consumidor");
                Console.WriteLine("2. Listar Consumidores");
                Console.WriteLine("3. Atualizar Consumidor");
                Console.WriteLine("4. Remover Consumidor");
                Console.WriteLine("0. Voltar");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarConsumidor();
                        break;
                    case 2:
                        ListarConsumidores();
                        break;
                    case 3:
                        AtualizarConsumidor();
                        break;
                    case 4:
                        RemoverConsumidor();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuConsumos()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=========   GERENCIAR CONSUMOS   =============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Consumo");
                Console.WriteLine("2. Listar Consumos");
                Console.WriteLine("3. Atualizar Consumo");
                Console.WriteLine("4. Remover Consumo");
                Console.WriteLine("0. Voltar");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarConsumo();
                        break;
                    case 2:
                        ListarConsumos();
                        break;
                    case 3:
                        AtualizarConsumo();
                        break;
                    case 4:
                        RemoverConsumo();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void AdicionarProduto()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======    ADICIONAR NOVO PRODUTO    ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            int id = produtos.Count > 0 ? produtos[^1].Id + 1 : 1;
            Produto produto = new Produto(id, nome);
            produtos.Add(produto);

            Console.WriteLine("\nProduto adicionado com sucesso!");
            SalvarDados();
        }

        static void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("========    LISTA DE PRODUTOS    ============");
            Console.WriteLine("==============================================");

            if (produtos.Count == 0)
            {
                Console.WriteLine("\nNenhum produto cadastrado.");
            }
            else
            {
                foreach (var produto in produtos)
                {
                    Console.WriteLine($"ID: {produto.Id} - Nome: {produto.Nome}");
                }
            }
        }

        static void AtualizarProduto()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   ATUALIZAR PRODUTO   ============");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID do produto a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            var produto = produtos.Find(p => p.Id == id);

            if (produto != null)
            {
                Console.Write("Digite o novo nome do produto: ");
                produto.Nome = Console.ReadLine();

                Console.WriteLine("\nProduto atualizado com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nProduto não encontrado.");
            }
        }

        static void RemoverProduto()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========    REMOVER PRODUTO    ============");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID do produto a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            var produto = produtos.Find(p => p.Id == id);

            if (produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine("\nProduto removido com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nProduto não encontrado.");
            }
        }

        static void AdicionarConsumidor()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======   ADICIONAR NOVO CONSUMIDOR  ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do consumidor: ");
            string nome = Console.ReadLine();

            int id = consumidores.Count > 0 ? consumidores[^1].Id + 1 : 1;
            Consumidor consumidor = new Consumidor(id, nome);
            consumidores.Add(consumidor);

            Console.WriteLine("\nConsumidor adicionado com sucesso!");
            SalvarDados();
        }

        static void ListarConsumidores()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=======    LISTA DE CONSUMIDORES   ==========");
            Console.WriteLine("==============================================");

            if (consumidores.Count == 0)
            {
                Console.WriteLine("\nNenhum consumidor cadastrado.");
            }
            else
            {
                foreach (var consumidor in consumidores)
                {
                    Console.WriteLine($"ID: {consumidor.Id} - Nome: {consumidor.Nome}");
                }
            }
        }

        static void AtualizarConsumidor()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ATUALIZAR CONSUMIDOR  ============");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID do consumidor a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            var consumidor = consumidores.Find(c => c.Id == id);

            if (consumidor != null)
            {
                Console.Write("Digite o novo nome do consumidor: ");
                consumidor.Nome = Console.ReadLine();

                Console.WriteLine("\nConsumidor atualizado com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nConsumidor não encontrado.");
            }
        }

        static void RemoverConsumidor()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========    REMOVER CONSUMIDOR  ============");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID do consumidor a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            var consumidor = consumidores.Find(c => c.Id == id);

            if (consumidor != null)
            {
                consumidores.Remove(consumidor);
                Console.WriteLine("\nConsumidor removido com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nConsumidor não encontrado.");
            }
        }

        static void AdicionarConsumo()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======   ADICIONAR NOVO CONSUMO   ============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o ID do produto: ");
            int produtoId = int.Parse(Console.ReadLine());
            var produto = produtos.Find(p => p.Id == produtoId);

            Console.Write("Digite o ID do consumidor: ");
            int consumidorId = int.Parse(Console.ReadLine());
            var consumidor = consumidores.Find(c => c.Id == consumidorId);

            if (produto != null && consumidor != null)
            {
                int id = consumos.Count > 0 ? consumos[^1].Id + 1 : 1;
                Consumo consumo = new Consumo(id, produto, consumidor);
                consumos.Add(consumo);

                Console.WriteLine("\nConsumo adicionado com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nProduto ou consumidor não encontrado.");
            }
        }

        static void ListarConsumos()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=======      LISTA DE CONSUMOS   ============");
            Console.WriteLine("==============================================");

            if (consumos.Count == 0)
            {
                Console.WriteLine("\nNenhum consumo registrado.");
            }
            else
            {
                foreach (var consumo in consumos)
                {
                    Console.WriteLine($"ID: {consumo.Id} - Produto: {consumo.Produto.Nome} - Consumidor: {consumo.Consumidor.Nome}");
                }
            }
        }

        static void AtualizarConsumo()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ATUALIZAR CONSUMO   =============");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID do consumo a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            var consumo = consumos.Find(c => c.Id == id);

            if (consumo != null)
            {
                Console.Write("Digite o novo ID do produto: ");
                int produtoId = int.Parse(Console.ReadLine());
                var produto = produtos.Find(p => p.Id == produtoId);

                Console.Write("Digite o novo ID do consumidor: ");
                int consumidorId = int.Parse(Console.ReadLine());
                var consumidor = consumidores.Find(c => c.Id == consumidorId);

                if (produto != null && consumidor != null)
                {
                    consumo.Produto = produto;
                    consumo.Consumidor = consumidor;
                    Console.WriteLine("\nConsumo atualizado com sucesso!");
                    SalvarDados();
                }
                else
                {
                    Console.WriteLine("\nProduto ou consumidor não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nConsumo não encontrado.");
            }
        }

        static void RemoverConsumo()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========    REMOVER CONSUMO   ==============");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID do consumo a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            var consumo = consumos.Find(c => c.Id == id);

            if (consumo != null)
            {
                consumos.Remove(consumo);
                Console.WriteLine("\nConsumo removido com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nConsumo não encontrado.");
            }
        }

        static void SalvarDados()
        {
            File.WriteAllText(caminhoProdutos, JsonSerializer.Serialize(produtos));
            File.WriteAllText(caminhoConsumidores, JsonSerializer.Serialize(consumidores));
            File.WriteAllText(caminhoConsumos, JsonSerializer.Serialize(consumos));
        }

        static void CarregarDados()
        {
            if (File.Exists(caminhoProdutos))
            {
                string json = File.ReadAllText(caminhoProdutos);
                produtos = JsonSerializer.Deserialize<List<Produto>>(json) ?? new List<Produto>();
            }

            if (File.Exists(caminhoConsumidores))
            {
                string json = File.ReadAllText(caminhoConsumidores);
                consumidores = JsonSerializer.Deserialize<List<Consumidor>>(json) ?? new List<Consumidor>();
            }

            if (File.Exists(caminhoConsumos))
            {
                string json = File.ReadAllText(caminhoConsumos);
                consumos = JsonSerializer.Deserialize<List<Consumo>>(json) ?? new List<Consumo>();
            }
        }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Produto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }

    public class Consumidor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Consumidor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }

    public class Consumo
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public Consumidor Consumidor { get; set; }

        public Consumo(int id, Produto produto, Consumidor consumidor)
        {
            Id = id;
            Produto = produto;
            Consumidor = consumidor;
        }
    }
}





