public class ExternalBitCoinAdapter : IPaymentProcessor
{
    private readonly ExternalBitCoinService _externalPaymentService;

    public ExternalBitCoinAdapter(ExternalBitCoinService externalPaymentService)
    {
        _externalPaymentService = externalPaymentService;
    }

    public void ProcessPayment(decimal amount)
    {
        // Chamando o método do serviço externo
        _externalPaymentService.transferToWallet(amount);
    }
}