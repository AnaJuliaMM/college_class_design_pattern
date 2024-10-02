class Subwoofer
{
    public void On()
    {
        Console.WriteLine("Subwoofer ligado.");
    }

    public void Off()
    {
        Console.WriteLine("Subwoofer desligado.");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"Volume do subwoofer ajustado para {level}.");
    }
}