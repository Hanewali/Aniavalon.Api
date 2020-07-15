using System;
using System.Net;
using Aniavalon.Api.Services.Statistics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Aniavalon.Api.Controllers.Statistics
{
    [ApiController]
    [Route("[statistics]")]
    public class StatisticsController : ControllerBase
    {
        private readonly ILogger<StatisticsController> _logger;
        private readonly IStatisticsService _statisticsService;

        public StatisticsController(
            ILogger<StatisticsController> logger, 
            IStatisticsService statisticsService)
        {
            _logger = logger;
            _statisticsService = statisticsService;
        }

        [HttpPost]
        [Route("AddEntry")]
        public ActionResult AddEntry(int personId, int sideId, int playerCount)
        {
            try
            {
                _statisticsService.AddEntry(personId, sideId, playerCount);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex, "Error during adding entry to database");
                Response.StatusCode = (int) HttpStatusCode.InternalServerError;
            }

            return Ok();
        }
    }
}