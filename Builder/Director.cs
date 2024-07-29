using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;
internal class Director
{
    private HouseBuilder _builder;
    public Director(HouseBuilder builder)
    {
        _builder = builder;
    }

    public House BuildOneStoryWoodenHouse()
    {
        return _builder.SetStories(1).SetFloorType(Material.Wood).SetDoorType(Material.Wood).Build();
    }
}
