using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Builder;
internal class House
{
    public House(HouseBuilder builder)
    {
        _stories = builder.Stories;
        _floorType = builder.FloorType;
        _doorType = builder.DoorType;
    }
    private int _stories;
    private Material _doorType;
    private Material _floorType;
    public override string ToString()
    {
        return $"House : Stories : {_stories} , Door type : {_doorType} , floor type : {_floorType}";
    }

}
