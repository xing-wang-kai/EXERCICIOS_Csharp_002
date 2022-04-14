# Csharp parte5: Bibliotecas DLLs, documentação e usando NuGets

##01.Projeto de Bibliotecas
Para iniciar uma biblioteca devemos clicar direito em "Soluões 'projetoname'e selecionar em 
> adicionar "novo Projeto" -> bibliotecas de Classes (.net framework) então após iniciar
a biblioteca.

Para adicionar a biblioteca no projeto principal do programa vamos no projeto prinpipal e
no arquivo chamado "Referências" click direito e selecionar > "adicionar Referências",
Marcar a biblioteca que queremos usar.

Automáticamente na pasta BIN do executador de nosso programa será gerado um novo arquivo .dll que
será a biblioteca usada dentro do projeto que estamos trabalhando naquele momento.

###Vocabulários
----------------------------------------------------------------------------------------------------
##02.Modificadores de Acesso em Bibliotecas

Quando declaramamos uma class e queremos que ela seja somente usada em uma determinada biblioteca
então precisamos declara-la como Internal, para protejar de que ela seja usadas em outros projetos
desta maneira mantemos a integridade da class unicamente aquele projeto especifico impedindo que seja
usada em outros projetos e comprometa a integridade do mesmo caso seja usada.


							+---------------------------------------+
							|  Public - todas o Projeto             |
							|  +------------------------------------+
							|  |  Internal - Até a Biblioteca       |
							|  |  +---------------------------------+
							|  |  |Protected - até a class Child    |
							|  |  |  +------------------------------+
							|  |  |  |Private - Class Parents       |
							|  |  |  +------------------------------+
							|  |  +---------------------------------+
							|  +------------------------------------+
							+---------------------------------------+

Podemos usar também o como internal Protected esse tipo de controlador matem a instancia visivel para
classes derivadas de contextos que possuem esse controle fora da biblioteca.


###Vocabulários
-internal
-internal Protected

----------------------------------------------------------------------------------------------------
##03.Referencia de DLL

Em casos que temos outros projetos que vão usar a mesma biblioteca inicial, somente cópiar os codigos
de uma biblioteca para outra não irão ser de grande ajuda, melhor prestar atenção no código gerado dentro
da pasta BIN/Debug do projeto inicial chamado dll.

Desta forma podemos ir em "Referências" e em seguida procurar e localizar o arquivo DLL, que por lógica
pode estar salvo em uma pasta especifica para o uso desta biblioteca padrão. fazendo isso o sistema permite
que instaciamos todos methodos e class desta biblioteca e usemos em nossos projetos.


----------------------------------------------------------------------------------------------------
##04.Documentando

Para documentar funcionábilidades de nosso códigos e usar nos projetos que extends determinadas bibliotecas podemos
então usar a tag summary
Estas tags usada nos comentários são do tipo XML

Esta estrutura é definida acima da CLASS

					/// <summary>
					/// Define uma Conta Corrente do Banco ByteBank.
					/// </summary>
Esta estrutura acima dos méthods da class

					/// <summary>
					/// Cria uma instancia de conta correte com os argumentos necessários
					/// </summary>
					/// <param name="agencia">Representa a <see cref = "agencia"/> e precisa ser maior que 0</param>
					/// <param name="numero">Representa o número da conta é precisa ser maior que 0</param>
					/// <exception cref="ArgumentException"></exception>

Cada um dos Parms são parametros que precisamos passar como argumentos para explicar no código da biblioteca

para salvar esta biblioteca para outros projetos click direito na class biblioteca e então você clica em
preferencias > build (copilador) e seleciona o XML

###Vocabulários
-summary
-param
-<see cref = ""/>
-<exception>
----------------------------------------------------------------------------------------------------
##05.NuGet

Podemos pesquisar os comandos para instalar as bibliotecas em nosso projeto.

Para salvar uma biblioteca em nosso projeto vamos em --> ferramentas --> gerenciador de pacotes do Nuget --> no prompt de comando
aberto digitar o comando para instalr a biblioteca 

Isso vai gerar uma pasta nova no diretório do projeto com nome package e arquivo config que adiciona uma linha de pacote
que será resturado no momento de compilar


Assim qualquer um que quiser usar a biblioteca no prjeto ele vai está dentro do projeto.


----------------------------------------------------------------------------------------------------
# Csharp parte6: Strings, Expressoes Regulares e Class

##Mais sobre Strings

datetime data = new datetime(yyy,mm,dd hh:mm:ss);
New datetime.now
	retorna  a data de agora.

	TimeSpan re(data1 + data2)
##Methodos e Propriedades
	usando: indexof(valor)         => - para localizar o index do caracter dentro de uma string.
	usando: valor.substring(index) => - quebra a string apartir do index.
	usando: valor.length           => - retorna o qtd de cacteres dentro de uma string, conatando tbm os spaces

--------------------------------------------------------------------------------------------------

# ARRAY EM Csharp

Para adicionar um array em Csharp precisamos informar o typo da váriavel conforme exemplo abaixo.

```csharp
	
	int[] itens = new int[5];

	itens[0] = 1;
	itens[1] = 2;
	itens[2] = 3;
	itens[3] = 4;
	itens[4] = 5;	

```

## Conhecendo Array: 

	Para informar o tamanho do array colocamos numero dentro do valor do array em new int[tamanho].
	para array podem ter todos types ex.: new string[12];
	necessário sempre usar os colchetes para informar o Array. 
	cada possição de um array Começa com 0;

```csharp
int[] listas = new int[4];
            listas[0] = 1;
            listas[1] = 2; 
            listas[2] = 3; 
            listas[3] = 4;
            foreach(int i in listas)
            {
                Console.WriteLine(i);
            }
```

## Contando total de itens em um array.

para contar o total de valores que tem em um array usamos .length;

## Criando uma class que adicina valores ao Array;

Este código adiciona tamanho a um novo Array toda vez que o tamanho do array é insuficiente
para conter todo conteúdo adicionado no Array;


```csharp
public class Itens{
	private int[] _itens;
	private int _next;
	
	public Itens(int tamanho = 5){
		_itens = new int[tamanho];
		_next = 0;
	}
	public void adicionar(int valor){

	capacidade(_next+1);
		_itens[_next] = valor;
		_next ++;
	}

	private void capacidade(int tamanhoNecessario){
		if(_itens.length >= tamanhoNecessario){
			return;
		}
		int novoTamanho = _itens.lenght*2;
		int[] _newItens = new int[novoTamanho]

		for(int i = 0; i < _itens.length; i++ ){
			_newItens[i] = _itens[i];
		}
		_itens = _newItens;
	}
}
```

