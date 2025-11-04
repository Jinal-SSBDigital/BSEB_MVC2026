using Microsoft.AspNetCore.Mvc;
//using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        //private readonly IActiveLogService _activeLogService;
        //private readonly ILogger<ActiveLogController> _logger;

        //public ProductController(IActiveLogService activeLogService, ILogger<ActiveLogController> logger)
        //{
        //    _activeLogService = activeLogService;
        //    _logger = logger;
        //}
        //[HttpPost("activelog")]
        //public async Task<IActionResult> Activelog([FromForm] DTOs.ActiveLogDTO activeLog)
        //{
        //    try
        //    {
        //        var result = await _activeLogService.UserActiveLogAsync(activeLog, HttpContext);
        //        if (result)
        //        {
        //            _logger.LogInformation("User activelog: {type}", activeLog.activitytype);
        //            return Ok(new { success = true, message = "User Active LOg successfully" });
        //        }




        //        _logger.LogWarning("Registration failed for user activelog: {type}", activeLog.activitytype);
        //        return BadRequest(new { success = false, message = "Registration failed" });
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Exception during registration for user activelog: {type}", activeLog.activitytype);
        //        return StatusCode(500, new { success = false, message = "Internal server error" });
        //    }
        //}
    }
}
