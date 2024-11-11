using DAL.EfClasses;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace NotissimusTestovoe.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StoragesController(IStoragesServices storagesServices) : ControllerBase
{
    [HttpGet]
    public List<Storage> GetStorages([FromQuery] string text)
    {
        List<Storage> storages = storagesServices.GetStorages(text);
        return storages;
    }
}