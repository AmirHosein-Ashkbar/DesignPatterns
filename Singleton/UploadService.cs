using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton;
sealed class UploadService
{
    private static UploadService _instance;
    public int Id { get; private set; }
    private static readonly object _lock = new object();
    private UploadService() { }

    public static UploadService Instance(int id)
    {
        if(_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance =  new UploadService();
                    _instance.Id = id;
                }
            }
        }
        return _instance;
    }
}
