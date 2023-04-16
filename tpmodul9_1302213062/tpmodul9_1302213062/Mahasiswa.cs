using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302213062
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa : Controller
    {
        public static List<mahasiswa> mhs = new List<mahasiswa>
        {
            new mahasiswa {Nama = "Aisha Putri Nuryan", Nim = "1302213038"},
            new mahasiswa {Nama = "Jannatin Nurrohmah", Nim = "1302213051"},
            new mahasiswa {Nama = "Jean Rika Haryadi", Nim = "1302210004)"},
            new mahasiswa {Nama = "Novita Sabila Nugraha", Nim = "1302213030"},
            new mahasiswa {Nama = "Triani Putri Mumpuni", Nim = "1302213091"}
        };

        // GET: api/<Mahasiswa>
        // mereturn output berupa list dari semua obj mhs
        [HttpGet]
        public IEnumerable<mahasiswa> Get()
        {
            return mhs;
        }

        // GET api/<Mahasiswa>/{id}
        // mereturn output berupa obj mhs ke-i
        [HttpGet("{id}")]
        public mahasiswa Get(int id)
        {
            return mhs[id];
        }

        // POST api/<Mahasiswa>
        // menambah obj mhs baru 
        [HttpPost]
        public IActionResult Post([FromBody] mahasiswa newMhs)
        {
            mhs.Add(newMhs);
            return Ok();
        }

        // DELETE api/<Mahasiswa>/{id}
        // menghapus obj mhs ke-i
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id >= mhs.Count)
            {
                return NotFound();
            }

            mhs.RemoveAt(id);
            return Ok();
        }
    }

    public class mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
    }
}