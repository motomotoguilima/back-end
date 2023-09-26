//habilitar propriedades do mvc(controllers)
using Microsoft.AspNetCore.Mvc;
//trabalhar com lista
using System.Collections.Generic;
//consulta links
using System.Linq;
//usando o arquivo na pasta models(linkar os arquivos)
//using CRUD.Models


public class TarefaController : Controller
{
    //criando um objeto _tarefas que armazenara uma lista de tarefas
    private static List<Tarefa> _tarefas = new List<Tarefa>();

    public IActionResult Index()
    {
        return View(_tarefas);
    }

    public IActionResult Adicionar()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Adicionar(Tarefa novaTarefa)
    {
        //verificando o total de tarefas da lista e somando mais 1 para criar o ID
        novaTarefa.Id = _tarefas.Count + 1;
        //adicionando minha nova tarefa á minha lista
        _tarefas.Add(novaTarefa);
        //redirecionando para a pagina principal com a lista de tarefas
        return RedirectToAction("index");
    }

    public IActionResult Editar(int id)
    {
        //estou buscando na minha lista a tarefa que desejo alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == id);
        //verificanod se ela existe
        if (novaTarefa == null)
            return NotFound();

        //enviando para view a tarefa que queremo alterar
        return View(novaTarefa);
    }
    [HttpPost]
    public IActionResult Editar(Tarefa tarefaEditando)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == tarefaEditando.Id);
        if (tarefaEncontrada == null)
            return NotFound();

        tarefaEncontrada.Descricao = tarefaEditando.Descricao;
        tarefaEncontrada.Concluido = tarefaEditando.Concluido;
        return RedirectToAction("index");
    }
     public IActionResult Deletar(int id)
    {
        //estou buscando na minha lista a tarefa que desejo alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == id);
        //verificanod se ela existe
        if (novaTarefa == null)
            return NotFound();

        //enviando para view a tarefa que queremo alterar
        return View(novaTarefa);
    }
    [HttpPost]
    public IActionResult DeletarConfirmado(int Id)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == Id);
        if (tarefaEncontrada == null)
            return NotFound();
        _tarefas.Remove(tarefaEncontrada);
        return RedirectToAction("index");
    }
}