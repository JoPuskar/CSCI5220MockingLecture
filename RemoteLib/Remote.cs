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
        _device.TurnON();
    }
}
