
namespace TestApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using TestApi.Core;

// {id:alpha}: Restringe o parâmetro para conter apenas letras
// {id:bool}: Restringe o parâmetro para representar valores booleanos
// {id:datetime}: Restringe para usar valores de Data e Hora
// {id:Guid}: Restringe para usar apenas Guids

[ApiController]
[Route("clients")]
/// [Route("Default/GetRecordsById/{id:int:min(1)}")]   
public class ClientController : ControllerBase
{
    private static List<Client> _clients = new();
    private static int _nextId = 1;

    [HttpPost]
    public ActionResult Create(ClientRequest request)
    {
        var client = request.CreateClient(_nextId++);
        _clients.Add(client);

        return StatusCode(201, client);
    }

    [HttpPut("{id: int:min(1)}")]
    public ActionResult Update(int id, ClientRequest request)
    {
        var client = _clients.FirstOrDefault(c => c.Id == id);

        if (client == null)
            return NotFound("Client not found");

        var clientUpdated = request.UpdateClient(client);

        return Ok(clientUpdated);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var removed = _clients.RemoveAll(c => c.Id == id);

        if (removed == 0)
            return NotFound("Client not found");

        return NoContent();
    }


    [HttpGet]
    public ActionResult List()
    {
        return StatusCode(200, _clients);
    }
}