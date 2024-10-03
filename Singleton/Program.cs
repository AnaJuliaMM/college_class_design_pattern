// Obtendo a instância do Singleton
Singleton singletonInstance = Singleton.Instance;

// Chamando um método da instância
singletonInstance.ShowMessage();

// Confirmando que a mesma instância é usada
Singleton anotherInstance = Singleton.Instance;

if (singletonInstance == anotherInstance)
{
    Console.WriteLine("Ambas as variáveis referenciam a mesma instância.");
}

// Exercise: Magic Kingdom of Eldoria and Magic Draconis Dragon
Draconis fistMagicDragonCall = Draconis.Instance;
Draconis secondMagicDragonCall = Draconis.Instance;

if (fistMagicDragonCall == secondMagicDragonCall) {
    fistMagicDragonCall.ShowMessage();
    Console.WriteLine("There is only one Draconis!");
}
    