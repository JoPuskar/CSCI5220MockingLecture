using NSubstitute;
using RemoteLib;

namespace RemoteUnitTesting
{
    [Category("Remote Unit Testing")]
    public class ARemote
    {
        [Test]
        public void CanSendTurnOnMessageToDevice()
        {
            IDevice device = Substitute.For<IDevice>();
            Remote sut = new(device);
            sut.ToggleDevicePower();

            //Assert that the device received the call
            device.Received().TurnON();

            //Assert.Fail("Work in Progress");
        }
    }
}