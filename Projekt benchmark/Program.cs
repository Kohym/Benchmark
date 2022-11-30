using Hardware.Info;
using System.Net.NetworkInformation;

HardwareInfo hardwareInfo = new HardwareInfo();

hardwareInfo.RefreshAll();

Menu:
Console.WriteLine("HW analyzator");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine(hardwareInfo.OperatingSystem);
Console.WriteLine("\n   *\n");
Console.WriteLine("[1] CPU");
Console.WriteLine("[2] Motherboard");
Console.WriteLine("[3] RAM");
Console.WriteLine("[4] GPU");
Console.WriteLine("[5] Storage");
string volba = Console.ReadLine();

if (volba == "1")
{
    Console.Clear();
    Console.WriteLine(hardwareInfo.OperatingSystem);
    Console.WriteLine("CPU info:");
    Console.WriteLine("_______________________________________________________________________________________\n");
    foreach (var cpu in hardwareInfo.CpuList)
    {
        Console.WriteLine(cpu);

        foreach (var cpuCore in cpu.CpuCoreList)
            Console.WriteLine(cpuCore);
        Console.ReadLine();
        Console.Clear();
        goto Menu;
    }
}

if (volba == "2")
{
    Console.Clear();
    Console.WriteLine(hardwareInfo.OperatingSystem);
    Console.WriteLine("Motherboard info:");
    Console.WriteLine("_______________________________________________________________________________________\n");
    foreach (var hardware in hardwareInfo.MotherboardList)
        Console.WriteLine(hardware);
        Console.ReadLine();
        Console.Clear();
        goto Menu;
}

if (volba == "3")
{
    Console.Clear();
    Console.WriteLine(hardwareInfo.OperatingSystem);
    Console.WriteLine("Memory info:");
    Console.WriteLine("_______________________________________________________________________________________\n");
    Console.WriteLine(hardwareInfo.MemoryStatus);
    foreach (var hardware in hardwareInfo.MemoryList)
        Console.WriteLine(hardware);

    foreach (var hardware in hardwareInfo.BatteryList)
        Console.WriteLine(hardware);

    Console.ReadLine();
    Console.Clear();
    goto Menu;

}

if (volba == "4")
{
    Console.Clear();
    Console.WriteLine(hardwareInfo.OperatingSystem);
    Console.WriteLine("GPU info:");
    Console.WriteLine("_______________________________________________________________________________________\n");
    foreach (var hardware in hardwareInfo.VideoControllerList)
        Console.WriteLine(hardware);
    Console.ReadLine();
    Console.Clear();
    goto Menu;
}

if (volba == "5")
{
    Console.Clear();
    Console.WriteLine(hardwareInfo.OperatingSystem);
    Console.WriteLine("Storage info:");
    Console.WriteLine("_______________________________________________________________________________________\n");
    Console.WriteLine(hardwareInfo.MemoryStatus);
    foreach (var drive in hardwareInfo.DriveList)
    {
        Console.WriteLine(drive);
        Console.ReadLine();
        Console.Clear();
        goto Menu;
    }
}
