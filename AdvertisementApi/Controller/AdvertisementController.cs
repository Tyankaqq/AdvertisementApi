using AdvertisementApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class AdvertisementController : ControllerBase
{
    private readonly AdvertisementContext _context;

    public AdvertisementController(AdvertisementContext context)
    {
        _context = context;
    }

    [HttpGet("average-cost")]
    public IActionResult GetAverageCost()
    {
        var averageCost = _context.AdvertisementOrders.Average(a => a.Cost);
        return Ok(averageCost);
    }

    [HttpGet("advertisements-above-cost")]
    public IActionResult GetAdvertisementsAboveCost([FromQuery] decimal cost)
    {
        var advertisements = _context.AdvertisementOrders
            .Where(a => a.Cost > cost)
            .ToList();
        return Ok(advertisements);
    }

    [HttpGet("most-popular-broadcasts")]
    public IActionResult GetMostPopularBroadcasts()
    {
        var popularBroadcasts = _context.AdvertisementOrders
            .GroupBy(a => a.BroadcastCode)
            .Select(g => new
            {
                BroadcastCode = g.Key,
                TotalDuration = g.Sum(a => a.Duration)
            })
            .OrderByDescending(g => g.TotalDuration)
            .ToList();
        return Ok(popularBroadcasts);
    }
}

