# Inbtrodução ao .NET.

#### O que é o .NET?

- O .NET é uma plataforma de desenvolvimento de software gratuita, de código aberto e multiplataforma (roda em Windows, macOS e Linux) mantida pela Microsoft. Ela é usada para criar uma ampla variedade de aplicações, como:

    - Aplicações Web: Sites e serviços usando o ASP.NET Core.

    - Aplicações de Desktop: Programas para computadores usando Windows Forms, WPF e MAUI.

    - Serviços de nuvem e microsserviços: Aplicações rodando em ambientes como o Azure.

    - Jogos: Com o motor de jogo Unity, que usa C# (uma das linguagens do .NET).

    - Aplicações móveis: Apps para iOS e Android usando o .NET MAUI.

- Uma das principais características do .NET é o ecossistema de linguagens de programação que ele suporta, sendo as mais populares:

    - C#: A linguagem carro-chefe da plataforma, moderna e orientada a objetos.

    - F#: Uma linguagem funcional.

    - Visual Basic: Uma linguagem mais antiga, mas ainda utilizada.

#### A História e a Linha do Tempo
- A história do .NET pode ser dividida em duas grandes eras: a do .NET Framework e a do .NET (moderno).

#### A Era do .NET Framework (2002-2014)
- 2002: A Microsoft lança a primeira versão do .NET Framework. A ideia era ter uma plataforma unificada para o desenvolvimento no Windows, competindo com outras tecnologias como o Java. Ele era monolítico, ou seja, tudo vinha em um pacote só e era exclusivo para o sistema operacional Windows.

- 2005: É lançada a versão 2.0 do .NET Framework, junto com a linguagem C# 2.0. Essa versão consolidou muitas das funcionalidades básicas que usamos até hoje.

- 2006: Lançamento do WPF (Windows Presentation Foundation) e WCF (Windows Communication Foundation), que trouxeram novas formas de desenvolver aplicações de desktop e serviços, respectivamente.

- 2014: A Microsoft anuncia o .NET Core, um marco na história da plataforma. O objetivo era criar uma versão modular e multiplataforma do .NET, que pudesse rodar em Windows, macOS e Linux. Este foi o primeiro passo para o .NET moderno que conhecemos hoje.

#### A Era do .NET Moderno (2014-Hoje)
- 2016: Lançamento do .NET Core 1.0. A plataforma se torna código aberto e multiplataforma de fato. Este foi o início da transição. O .NET Framework continuou a ser atualizado, mas o foco da Microsoft mudou para o .NET Core.

- 2019: Lançamento do .NET Core 3.1, que foi uma versão de Long-Term Support (LTS), ou seja, com suporte estendido. Muitos projetos migraram para essa versão, solidificando o .NET Core como a escolha principal para novos projetos.

- 2020: A Microsoft toma uma decisão estratégica e unifica o .NET Core e o .NET Framework em um único nome: .NET. A versão lançada foi a .NET 5, que simbolizou a unificação. A partir daí, o número da versão seria incrementado anualmente.

- 2021: Lançamento do .NET 6, outra versão LTS que trouxe muitas melhorias de performance e a integração completa para desenvolvimento de aplicações móveis com o .NET MAUI.

- 2022: Lançamento do .NET 7.

- 2023: Lançamento do .NET 8, a versão LTS mais recente e a mais estável e performática até o momento. É nela que você provavelmente irá focar seus estudos.

#### Principais Diferenças entre .NET Framework e .NET
Esta é uma das partes mais importantes para entender, pois define a plataforma que você vai usar em um projeto.

| Característica	| .NET Framework (Legado)	| .NET (Moderno) |
|:---|:---|:---|
| Plataforma |	Exclusivo para Windows.	| Multiplataforma: Windows, macOS, Linux. |
| Código |	Código fechado (com algumas partes de código aberto).	| Completamente de código aberto. |
| Arquitetura |	Monolítica: um único pacote grande.	| Modular: você inclui apenas o que precisa, com o uso de pacotes NuGet. |
| Desenvolvimento |	Apenas para aplicações desktop e web no Windows. |	Vasto ecossistema: web, desktop, mobile, nuvem, jogos, IoT. |
| Atualizações |	Versões com foco em estabilidade, mas não recebe mais atualizações com novos recursos.	| Atualizações frequentes, com uma versão LTS a cada dois anos. |
| Ferramentas |	Principalmente o Visual Studio para Windows. |	Visual Studio, Visual Studio Code, JetBrains Rider e CLI do .NET. |

Resumindo: O .NET Framework é a versão antiga e legada, que parou de receber novas funcionalidades, sendo utilizada principalmente para manter aplicações antigas. O .NET (a partir da versão 5) é a plataforma moderna, multiplataforma, de código aberto e a escolha para qualquer novo projeto.


Links utilizados em aula:
- [https://dotnet.microsoft.com/pt-br/learn/dotnet/what-is-dotnet](https://dotnet.microsoft.com/pt-br/learn/dotnet/what-is-dotnet)
- [https://dotnet.microsoft.com/pt-br/learn/dotnet/what-is-dotnet](https://time.graphics/pt/line/291016)
- [https://www.scalablepath.com/dot-net/microsoft-dot-net-framework](https://www.scalablepath.com/dot-net/microsoft-dot-net-framework)
- [https://www.quora.com/Why-was-C-developed-when-an-object-oriented-programming-language-like-C++-already-existed](https://www.quora.com/Why-was-C-developed-when-an-object-oriented-programming-language-like-C++-already-existed)
- [https://docs.microsoft.com/pt-br/dotnet/core/introduction](https://docs.microsoft.com/pt-br/dotnet/core/introduction)
- [https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core)
- [https://pt.wikipedia.org/wiki/.NET_Framework](https://pt.wikipedia.org/wiki/.NET_Framework)
- [https://docs.microsoft.com/pt-br/dotnet/core/get-started](https://docs.microsoft.com/pt-br/dotnet/core/get-started)
- [https://www.guru99.com/compiler-design-phases-of-compiler.html](https://www.guru99.com/compiler-design-phases-of-compiler.html)
- [https://freecontent.manning.com/how-is-c-compiled](https://freecontent.manning.com/how-is-c-compiled)
- [https://www.youtube.com/watch?v=afUiVvDUIRA](https://www.youtube.com/watch?v=afUiVvDUIRA)

- [https://jpdeffo.medium.com/how-dotnet-core-compilation-work-for-absolute-beginners-fdba62b3167c](https://jpdeffo.medium.com/how-dotnet-core-compilation-work-for-absolute-beginners-fdba62b3167c)
- [https://www.geeksforgeeks.org/what-is-just-in-time-jit-compiler-in-dot-net/](https://www.geeksforgeeks.org/what-is-just-in-time-jit-compiler-in-dot-net/)
- [https://www.quora.com/Is-assembly-just-another-name-for-machine-code](https://www.quora.com/Is-assembly-just-another-name-for-machine-code)
- [https://hpc-wiki.info/hpc/Compiler](https://hpc-wiki.info/hpc/Compiler)
- [https://freecontent.manning.com/how-is-c-compiled/(https://freecontent.manning.com/how-is-c-compiled/)]
- [https://codeasy.net/lesson/c_sharp_compilation_process](https://codeasy.net/lesson/c_sharp_compilation_process)

- [https://docs.microsoft.com/en-us/dotnet/core/tools/(https://docs.microsoft.com/en-us/dotnet/core/tools/)]
- [https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/coding-style/coding-conventions](https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions)
- [https://www.tutorialspoint.com/csharp/csharp_basic_syntax.htm](https://www.tutorialspoint.com/csharp/csharp_basic_syntax.htm)
- [https://www.ralms.net/dica/entity%20framework%20core/snakecase/](https://www.ralms.net/dica/entity%20framework%20core/snakecase/)

- [https://www.tutorialspoint.com/csharp/csharp_data_types.htm](https://www.tutorialspoint.com/csharp/csharp_data_types.htm)
- [https://docs.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-6.0](https://docs.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-6.0)
