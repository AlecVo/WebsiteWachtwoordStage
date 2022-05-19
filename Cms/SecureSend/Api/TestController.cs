using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EncryptieAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;// in de umbraco documentation staat Route
using Microsoft.EntityFrameworkCore;
using Umbraco.Cms.Web.Common.Controllers;
//inherit Umbraco.Cms.Web.Common.Controllers.UmbracoApiController;
//inherit UmbracoAuthorizedApiController; is voor als men de api gaat gebruiken voor de umbraco backoffice : is niet van toepassing.

namespace EncryptieAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EncryptieController : UmbracoApiController
{
    private readonly EncrypieContext _dbContext;
    public EncryptieController(EncrypieContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost("Create")]
    public async Task<ActionResult<List<Bericht>>> AddBericht(Bericht bericht)
    {
        _dbContext.Berichten.Add(bericht); //gaat berichten toevoegen in de database
        await _dbContext.SaveChangesAsync(); //gaat berichten opslaan in database

        return Ok(await _dbContext.Berichten.ToListAsync()); //gaat berichten tonen
    }

    [HttpPost("Retrieve")]
    public async Task<ActionResult<Bericht>> OphalenBericht(Guid id)
    {
        var bericht = await _dbContext.Berichten.FindAsync(id); //gaat zoeken in de database met hetzelfde id dat opgegeven is
        if (bericht == null)
        {
            return BadRequest("Het bericht met dat id bestaat niet"); //als het bericht niet bestaat return foutmelding
        }
        else
        {
            _dbContext.Berichten.Remove(bericht);
            await _dbContext.SaveChangesAsync();
            return Ok(bericht); // bericht tonen
            
        }
    }
    
    [HttpGet("test")]
    public async Task<ActionResult<Bericht>> Test()
    {
        return Ok(await _dbContext.Berichten.ToListAsync());//ophalen lijst van berichten
    }

}

