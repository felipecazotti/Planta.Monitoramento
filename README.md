# Planta.Monitoramento
Site para gerenciamento dos dados e do sistema de medição de umidade da planta.


## Migrations
Devido a forma como foi dividido os projetos, criar e subir migrations exige passar parametros da classe de contexto(-c), do projeto onde está o contexto(-p) e do projeto onde está a Program.cs(-s). O contexto é o ApplicationDbContext que foi adicionado no projeto Planta.Monitoramento.Infra. A Program.cs está na Planta.Monitoramento.Api.

``dotnet ef migrations add {NomeDaMigration} -c ApplicationDbContext -p Planta.Monitoramento.Infra -s Planta.Monitoramento.Api``

``dotnet ef database update -c ApplicationDbContext -p Planta.Monitoramento.Infra -s Planta.Monitoramento.Api``