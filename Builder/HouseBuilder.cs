using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;
internal class HouseBuilder
{
    public int Stories {  get; private set; }
    public Material FloorType {  get; private set; }
    public Material DoorType {  get; private set; }

    public HouseBuilder SetStories(int stories)
    {
        Stories = stories;
        return this;
    }
    public HouseBuilder SetFloorType(Material floorType)
    {
        FloorType = floorType;
        return this;
    }
    public HouseBuilder SetDoorType(Material doorType)
    {
        DoorType = doorType;
        return this;
    }

    public House Build()
    {
        return new House(this);
    }

}
