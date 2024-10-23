import { useEffect } from "react";

function ProdutoListar(){
    useEffect(() => {
        //Função utilizada para executar algum código ao abrir ou renderizar o componente
        //AXIOS biblioteca de requisições HTTP
        fetch("https://viacep.com.br/ws/80440020/json")
            .then(response =>{
                return response.json();
            })
            .then(cep => {
                console.log(cep);
            })
    });

    return (
        <>
            <h1>Primeiro Post!</h1>
            <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Molestias, voluptate aliquam ab esse, vero consequuntur numquam mollitia maiores voluptates exercitationem libero aspernatur impedit quidem officiis laudantium odit at quis rerum?</p>
        </>
    );
}

export default ProdutoListar;

//1- Exibir alguma informação do CEP no navegador(componente)
//2- Realizar a requisição para a sua API
//3- Resolver o problema de CORS que será mostrado no console
//4- Exibir a lista de livros no navegador