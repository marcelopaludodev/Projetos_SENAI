// ATRIBUTOS //

let editando = null;

let listaTarefas = [
    {id: 1, titulo: "Estudar Para Prova", descricao: "Devo estudar para a prova sobre revolução francesa", concluida: false, data: "2026-06-06"}
];

// ELEMENTOS //

const inicio = document.getElementById("inicio")// Telas
const sidebar = document.getElementById("sidebar");
const tasks = document.getElementById("tasks");

const tarefas = document.getElementById("tarefas");// Outros
const formulario = document.getElementById("formulario");
const titulo = document.getElementById("titulo");
const descricao = document.getElementById("descricao");
const concluida = document.getElementById("concluida");
const data = document.getElementById("data");

const btnAdicionar = document.getElementById("adicionar");// Botões
const btnRemover = document.getElementById("remover");
const btnCancelar = document.getElementById("cancelar");

// DISPLAYS //

function mostrarInicio(){

};

function mostrarSidebar(){

};

function mostrarTarefas(){

};

// FUNÇÕES //

function adicionar(){
    const novaTarefa = {
        id: Date.now(),
        titulo: titulo.value,
        descricao: descricao.value,
        concluida: concluida.checked,
        data: data.value
    };

    listaTarefas.push(novaTarefa);

    renderizar();

    // Limpar Formulario
    titulo.value = "";
    descricao.value = "";
    concluida.checked = false;
    data.value = "";

};

function remover(){
    
};

function editar(){

};

// DOM //

function renderizar(){
    tarefas.innerHTML = "";

    if(listaTarefas.length === 0){
        tarefas.innerHTML = `<p class = "vazio">Nenhuma tarefa criada.</p>`;
        return;
    }

    for(const tarefa of listaTarefas){
        const card = document.createElement("div");

        card.className = "card";
        card.dataset.id = tarefa.id;

        card.innerHTML = `
            <div class="tarefa">
                <h3>${tarefa.titulo}</h3>
                <p>${tarefa.descricao}</p>
                <p>${tarefa.concluida ? "✅ Concluída" : "❌ Pendente"}</p>
                <p>${tarefa.data}</p>
            </div>
        `;

        tarefas.appendChild(card);
    }
};

// EVENTOS // 

btnAdicionar.addEventListener("click", () => {
    adicionar();
});

btnRemover.addEventListener("click", () => {
    if (editando !== null) {
        remover(editando); 
        editando = null; 

        formulario.reset(); 
        renderizar(); 
    } else {
        console.log("Selecione uma tarefa para remover!");
    }
});

btnCancelar.addEventListener("click", () => {
    formulario.reset();
    editando = null;
});

renderizar();