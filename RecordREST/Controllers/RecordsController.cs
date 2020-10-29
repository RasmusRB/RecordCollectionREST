using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecordLib.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecordREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private static readonly List<Record> _records = new List<Record>()
        {
            new Record("Aenema", "TOOL", 120, 1992),
            new Record("Lateralus", "TOOL", 150, 2002),
            new Record("10.000 Days", "TOOL", 95, 2006),
            new Record("Fear Inoculum", "TOOL", 150, 2019)
        };


        // GET: api/<RecordsController>
        [HttpGet]
        public IEnumerable<Record> Get()
        {
            return _records;
        }

        [HttpGet]
        [Route("Artist/{substring}")]
        public IEnumerable<Record> GetFromArtist(string substring)
        {
            List<Record> records;
            records = _records.FindAll(r => r.Artist.Contains(substring));
            return records;
        }

        [HttpGet]
        [Route("Published/{release}")]
        public Record Get(int release)
        {
            return _records.Find(r => r.YearOfPublication == release);
        }

        // POST api/<RecordsController>
        [HttpPost]
        public void Post([FromBody] Record value)
        {
            _records.Add(value);
        }

        // PUT api/<RecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<RecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
