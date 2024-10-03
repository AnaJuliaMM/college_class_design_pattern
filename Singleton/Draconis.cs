public class Draconis
{
    // A instância privada e estática da classe
    private static Draconis instance;

    // Um objeto para sincronização
    private static readonly object lockObject = new object();

    // Construtor privado para evitar instanciamento externo
    private Draconis()
    {
        // Inicialização da instância
    }

    // Propriedade pública para obter a instância
    public static Draconis Instance
    {
        get
        {
            // Usa bloqueio para garantir que apenas uma instância seja criada em ambientes multithread
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Draconis();
                }
                return instance;
            }
        }
    }

    // Um exemplo de método da classe
    public void ShowMessage()
    {
        Console.WriteLine("Hello, I am Draconis! How can I magic you?");
    }
}
