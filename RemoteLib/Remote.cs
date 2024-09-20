using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RemoteLib;
public class Remote
{
    private IDevice _device;

    public Remote(IDevice device) {
        _device = device;

    }

    public void ToggleDevicePower()
    {
        if (_device.IsOn())
        {
            _device.TurnOff();
        }
        else { 

            _device.TurnOn();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="volumeIncrement"></param>
    public void VolumeUp(int volumeIncrement)
    {
        if (_device.IsOn())
        { 
            _device.VolumeUp(volumeIncrement);
        }
    }
}
