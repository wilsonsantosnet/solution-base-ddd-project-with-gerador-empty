# O que é o Seed?

Seed é um projeto de template para construir sistemas com administrativos e até mesmo sites, o objetivo desse projeto é fornecer o esqueleto básico de um projeto dotnet core com uma API Rest, um FontEnd SPA Angular e um SSO com Identity serve 4, prover as camadas, as dependências básicas entre elas e pacotes principais como logs e acesso a dados. 

Depois de clonado esse repositório, existe um projeto nele chamado **Gerador.Gen.Core** ele utiliza uma série de arquivos txts para construir as classes do projeto baseado em um banco de dados. Ou seja, basta modelar o banco e depois especificar o nome das tabelas na classe **ConfigContext** método **ConfigContextDefault**, algo como segue abaixo.

```
TableInfo = new UniqueListTableInfo
{
	new TableInfo().FromTable("Sample").MakeBack().MakeFront().AndConfigureThisFields(new  List<FieldConfig> {

		new FieldConfig(){

			Name = "descricao",
			TextEditor = true
		},
		new FieldConfig(){

			Name = "FilePath",
			Upload = true
		}

	}),
	new TableInfo().FromTable("SampleType").MakeBack().MakeFront(),
	new TableInfo().FromTable("SampleItem").MakeBack().MakeFront()
}
```

Essa configuração está baseada em um script de exemplo igual a esse [Sample.Seed.sql](https://github.com/wilsonsantosnet/solution-base-ddd-project-with-gerador-empty/blob/main/Gerador.Gen.Core/Scripts/Sample.Seed.sql) basta rodá-lo em algum banco de dados SQL Server e alterar a Connectionstring do arquivo **appsettings.json** do gerador.

A estrutura é dividida em vários repositórios independentes que são gerenciados também pelo gerador na classe **ConfigExternalResources**, ela vai apontar para os repositórios do git que representam os seguintes componentes:


1. Arquivos de Template para o Back-end
1. Arquivos de Templates para o Front-end
1. Um Framework para o Back-end
1. Um Framework para o Front-end
1. Um esqueleto de projeto para um sistema administrativo
1. Um esqueleto de projeto para um site convecional
1. Um esqueleto de projeto para toda a solução de front ao back


#Repositorio Atuais

1. [backend-template-DDD](https://github.com/wilsonsantosnet/backend-template-DDD)
1. [template-gerador-front-coreui-angular6.0](https://github.com/wilsonsantosnet/template-gerador-front-coreui-angular6.0)
1. [backend-framework-common](https://github.com/wilsonsantosnet/backend-framework-common)
1. [framework-angular6.0-CRUD](https://github.com/wilsonsantosnet/framework-angular6.0-CRUD)
1. [project-base-layout-front-coreui-angular6.0](https://github.com/wilsonsantosnet/project-base-layout-front-coreui-angular6.0)
1. [project-custom-layout-front-coreui-angular8.0](https://github.com/wilsonsantosnet/project-custom-layout-front-coreui-angular8.0)
1. [solution-base-ddd-project-with-gerador-empty](https://github.com/wilsonsantosnet/solution-base-ddd-project-with-gerador-empty)


###### Caso esteja interessado em baixar o SEED e rodar o gerador siga as instruções do artigo:
1. [Gerador de Código](https://medium.com/@wilsonsantos_66971/gerador-de-c%C3%B3digo-7e3c08981e43)

###### Para saber mais consulte essa lista de artigos relacionados ao gerador e aos frameworks citados acima 
1. [gerador Init()](https://medium.com/@wilsonsantos_66971/brain-board-b3bf5e550cd9)


###### Digrama macro (obs.: está meio desatualizado, mas serve como referência)
![Diagrama 1](flow.png?raw=true "Flow")

