

namespace chore_c.Services;


public class FishService
{

    private readonly FishRepository _fishRepository;

    public FishService(FishRepository fishRepository)
    {
        _fishRepository = fishRepository;
    }



    internal Fish CreateFish(Fish fishData)
    {
        if (fishData.Name == null)
        {
            throw new Exception("A name needs to be entered");
        }

        Fish fish = _fishRepository.CreateFish(fishData);
        return fish;
    }


    internal string DestroyFish(int fishId)
    {
        Fish fish = GetFishById(fishId);

        _fishRepository.DestroyFish(fish);

        return $"{fish.Name} was caught!";
    }

    internal List<Fish> GetFish()
    {
        List<Fish> fishies = _fishRepository.GetFish();
        return fishies;
    }

    internal Fish GetFishById(int fishId)
    {
        Fish fish = _fishRepository.GetFishById(fishId);

        if (fish == null)
        {
            throw new Exception($"incorrect Id: {fishId}");
        }

        return fish;
    }

}