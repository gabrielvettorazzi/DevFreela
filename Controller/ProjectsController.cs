using System.Data;
using FreelaDev.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FreelaDev.Controller;

//Actions sõ metodos que estão contidos em uma classe controller
[Route("api/projects")]
public class ProjectsController : ControllerBase
{
    //api/project?query=net core
    [HttpGet]
    public IActionResult Get(string query)
    {
        
        //Buscar todos ou filtrar
        return Ok();
    }

    //api/project/599
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        //busca o Projeto
        //return NotFound
        return Ok();
    }

    
    [HttpPost]
    public IActionResult
        Post([FromBody] CreateProdutoModel createProdutoModel) //a part do corp da requisite vou pager um corp
    {
        if (createProdutoModel.Title.Length > 50)
        {
            return BadRequest();
        }

        return CreatedAtAction(nameof(GetById), new { id = createProdutoModel.Id }, createProdutoModel);
    }

    // Api/projects/2
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] UpadateProdutoModel upadateProdutoModel)
    {
        if (upadateProdutoModel.Description.Length > 200)
        {
            return BadRequest();
        }

        //Atualiso o projeto
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        //buscar de não existir retorna NotFound

        //Deletar campo na tabela
        return NoContent();
    }
     // api/projects/1/comments POST
    [HttpPost("{id}/comments")]
    public IActionResult PostComment(int id,[FromBody] CreateCommentModel createCommentModel)
    {
        return NoContent();
    }
    //api/project/1/start
    [HttpPut("{id}/start")]

    public IActionResult Start(int id)
    {
        return NoContent();
    }
    
    //api/project/1/finish
    [HttpPut("{id}/finish")]
    public IActionResult Finish(int id)
    {
        return NoContent();
    }
    
}




