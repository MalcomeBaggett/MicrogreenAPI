using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MicrogreensTrayApi.Services;
using MicrogreensTrayApi.Models;
namespace MicrogreensTrayApi.Controllers
{

    [Route("api/Tray")]
    [ApiController]
    public class TraysController : ControllerBase
    {
        private readonly TrayService _trayService;

        public TraysController(TrayService trayService)
        {
            _trayService = trayService;
        }

        [HttpGet]
        public ActionResult<List<Tray>> Get() => _trayService.Get();
        [HttpGet("{id:length(24)}", Name = "GetTray")]
        public ActionResult<Tray> Get(string id)
        {
            var tray = _trayService.Get(id);

            if (tray == null)
            {
                return NotFound();
            }

            return tray;
        }

        [HttpPost]
        public ActionResult<Tray> Create(Tray tray)
        {
            _trayService.Create(tray);

            return CreatedAtRoute("GetTray", new { id = tray.Id.ToString() }, tray);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Tray trayInput)
        {
            var tray = _trayService.Get(id);

            if (tray == null)
            {
                return NotFound();
            }

            _trayService.Update(id, trayInput);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var tray = _trayService.Get(id);

            if (tray == null)
            {
                return NotFound();
            }

            _trayService.Remove(tray.Id);

            return NoContent();
        }

    }
}