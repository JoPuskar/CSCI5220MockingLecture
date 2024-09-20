namespace RemoteLib
{
    public interface IDevice
    {
        bool IsOn();
        void TurnOff();
        void TurnOn();
        void VolumeUp(int volumeIncrement);
    }
}
