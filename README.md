# Determinar se um número é multiplo de 11
###### Aplicação feita com o objetivo de receber uma lista de números e retornar dizendo se esse número é multiplo de 11 ou não.
***

# Modo de execução:
Execute o projeto através do Visual stuio community, onde ele já executa o programa e abre a página do Swagger com os métodos disponíveis.
Ou através do prompt de command, acessando a pasta NPF.Api e executando o seguinte comando: _dotnet run watch_ e logo após no broswer acesse o endereço: _https://localhost:5001/swagger/index.html_, onde aparecerar a página do swagger com os métodos disponíveis. 

### POST /muliple
> Request body
  Exemplo: 
   {
    "numbers": [
             "112233",
             "30800",
             "2937",
             "323455693",
             "5038297",
             "112234"
     ]
   }

> Retorno esperado:
 {
    "result": 
    [
       {
          "number": "112233",
          "isMultiple": true
       },
       {
          "number": "30800",
          "isMultiple": true
        },
        {
          "number": "2937",
          "isMultiple": true
        },
        {
          "number": "323455693",
          "isMultiple": true
        {
          "number": "5038297",
          "isMultiple": true
        },
        {
          "number": "112234",
          "isMultiple": false
        }
    ]
  }
