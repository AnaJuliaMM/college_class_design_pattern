// Instanciando o serviço externo
ExternalPaymentService externalService = new ExternalPaymentService();
// Criando o adapter para permitir o uso do serviço externo
IPaymentProcessor paymentProcessor = new ExternalPaymentAdapter(externalService);


// Exercicio - utilizando o serviço externo de pagamento com ExternalBitCoinAdapter
ExternalBitCoinService bitCoinExternalService = new ExternalBitCoinService();
IPaymentProcessor bitCoinProcessor = new ExternalBitCoinAdapter(bitCoinExternalService);


// Usando o serviço de pagamento com o adapter
PaymentService paymentService = new PaymentService(paymentProcessor);
PaymentService bitCoinServices = new PaymentService(bitCoinProcessor);

paymentService.MakePayment(150.00M);
bitCoinServices.MakePayment(200.00M);