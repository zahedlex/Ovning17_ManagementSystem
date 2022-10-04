namespace ManagementSystem.Models
{
    public class MachineDevice
    {
        public string DeviceId { get; set; } = Guid.NewGuid().ToString("n");
        public string DeviceName { get; set; } = string.Empty;
        public bool Status { get; set; }
        public List<MachineDevice> Data { get; set; } = new List<MachineDevice>();
    }
}
