using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tpmodul9_1302213120.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {

        static public List<Mahasiswa> listMhs = new List<Mahasiswa> {
            new Mahasiswa("Walid Hanif Ataullah", "1302213120"),
            new Mahasiswa("Muhammad Raffa Zuhayr", "1302210068"),
            new Mahasiswa("Sylvana Rheina Khrameliawaty", "1302210017"),
            new Mahasiswa("M. Yasin Rafi", "1302210055"),
            new Mahasiswa("M. Nabiel P", "1302210041")
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMhs;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMhs[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            listMhs.Add(value);
        }


        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMhs.RemoveAt(id);
        }
    }
}