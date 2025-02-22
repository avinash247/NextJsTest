using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactTestApp.Server.DataLayer;
using ReactTestApp.Server.Models;

namespace ReactTestApp.Server
{
    [ApiController]
    [Route("[controller]")]
    public class TradingDataController : ControllerBase
    {
        private readonly TradeAPIDbContext _context;

        public TradingDataController(TradeAPIDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<TradingData>> Get()
        {
            return await _context.TradingData.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TradingData>> Get(int id)
        {
            var tradingData = await _context.TradingData.FindAsync(id);

            if (tradingData == null)
            {
                return NotFound();
            }

            return tradingData;
        }

        [HttpPost]
        public async Task<ActionResult<TradingData>> Post(TradingData tradingData)
        {
            _context.TradingData.Add(tradingData);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = tradingData.OrderId }, tradingData);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TradingData tradingData)
        {
            if (id != tradingData.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(tradingData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TradingDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var tradingData = await _context.TradingData.FindAsync(id);
            if (tradingData == null)
            {
                return NotFound();
            }

            _context.TradingData.Remove(tradingData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TradingDataExists(int id)
        {
            return _context.TradingData.Any(e => e.OrderId == id);
        }
    }
}
