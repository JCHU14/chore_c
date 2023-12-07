namespace chore_c.Repositories;


public class FishRepository
{
    private List<Fish> _fishies;

    public FishRepository()
    {
        _fishies = [

            new Fish("Rainbow", 1, "Green", 4, 6),
            new Fish("Brown Trout", 2, "Brown", 2, 7),
            new Fish("Brookie", 3, "Brook", 6, 4),
        ];
    }


    internal List<Fish> GetFish()
    {
        return _fishies;
    }


    internal void DestroyFish(Fish fish)
    {
        _fishies.Remove(fish);
    }

    internal Fish GetFishById(int fishId)
    {
        Fish foundFish = _fishies.Find(fish => fish.Id == fishId);
        return foundFish;
    }

    internal Fish CreateFish(Fish fishData)
    {
        Fish lastFish = _fishies[_fishies.Count - 1];
        if (lastFish == null)
        {
            fishData.Id = 1;
        }
        else
        {
            fishData.Id = lastFish.Id + 1;
        }
        _fishies.Add(fishData);
        return fishData;
    }
}