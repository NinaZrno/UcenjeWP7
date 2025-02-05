using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using WebAPI9.Models;

namespace WebAPI9.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")] // ruta ce se zvati /api/v1/HttpMetode
    public class HttpMetodeController : ControllerBase
    {

        // ovdje pocinje ruta
        // ruta je metoda

        [HttpGet]
        public string HelloWorld()
        {
            return "Hello World!";
        }


        // ovdje zavrsava ruta







        //ovdje pocinje ruta

        [HttpGet]
        [Route("Pozdrav")]
        public string HelloWorld(string ime)
        {
            return $"Hello {ime}!";
        }






        //ovdje zavrsava ruta





        [HttpGet]
        [Route("json")]

        public IActionResult GetJson(string ime, int godina)
        {
            return Ok(new { Ime = ime, Prezime = "Doe", godina = godina });
        }



        //ovdje zapocinje ruta






        //ovdje zavrsava ruta



        //ovdje pocinje ruta

        [HttpPost]
        public IActionResult PostJson(Osoba osoba)
        {
            osoba.Ime = "Hello" + osoba.Ime;
            return StatusCode(StatusCodes.Status201Created, osoba); // StatusCode(201,osoba);
        }


        //ovdje zavrsava ruta


        // ovdje pocinje ruta


        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            osoba.Ime = "Promjenio" + osoba.Ime;
            return Ok(osoba);
        }

        //ovdje zavrsava ruta


        //ovdje pocinje ruta

        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if (sifra <= 0)
            {
                return BadRequest(new { poruka = "Sifra mora biti veca od 0" });
            }
            else
            {
                return Ok(new object { poruka = "Obrisano" });
            }
        }
          

        //ovdje zavrsava ruta





    }
}
