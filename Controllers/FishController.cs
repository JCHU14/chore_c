namespace chore_c.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FishController : ControllerBase
{

    private readonly FishService _fishService;
    public FishController(FishService fishService)
    {
        _fishService = fishService;

    }


    [HttpGet]
    public ActionResult<List<Fish>> GetFish()
    {
        try
        {
            List<Fish> fish = _fishService.GetFish();
            return Ok(fish);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }

    [HttpGet("{fishId}")]
    public ActionResult<Fish> GetFishById(int fishId)
    {
        try
        {
            Fish fish = _fishService.GetFishById(fishId);
            return Ok(fish);
        }

        catch (Exception error)
        {

            return BadRequest(error.Message);
        }

    }

    [HttpPost]
    public ActionResult<Fish> CreateFish([FromBody] Fish fishData)
    {
        try
        {
            Fish fish = _fishService.CreateFish(fishData);
            return Ok(fish);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    [HttpDelete("{fishId}")]
    public ActionResult<string> DestroyFish(int fishId)
    {
        try
        {
            string message = _fishService.DestroyFish(fishId);
            return Ok(message);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }
}