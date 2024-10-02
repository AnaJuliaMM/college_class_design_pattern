// Classe Facade
class HomeTheaterFacade
{
    private TV tv;
    private SoundSystem soundSystem;
    private DVDPlayer dvdPlayer;
    private Subwoofer subwoofer;

    // Construtor
    public HomeTheaterFacade(TV tv, SoundSystem soundSystem, DVDPlayer dvdPlayer, Subwoofer subwoofer)
    {
        this.tv = tv;
        this.soundSystem = soundSystem;
        this.dvdPlayer = dvdPlayer;
        this.subwoofer = subwoofer;
        
    }

    // Método simplificado para assistir a um filme
    public void WatchMovie(string movie)
    {
        Console.WriteLine("Preparando para assistir ao filme...");
        tv.On();
        soundSystem.On();
        subwoofer.On();
        soundSystem.SetVolume(20);
        subwoofer.SetVolume(30);
        dvdPlayer.On();
        dvdPlayer.Play(movie);
    }

    // Método simplificado para desligar o sistema
    public void EndMovie()
    {
        Console.WriteLine("Desligando o sistema...");
        dvdPlayer.Stop();
        dvdPlayer.Off();
        subwoofer.Off();
        soundSystem.Off();
        tv.Off();
    }
}