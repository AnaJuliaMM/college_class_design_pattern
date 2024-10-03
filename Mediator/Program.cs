// Criando o mediador
ChatMediator mediator = new ChatMediator();

// Criando os usuários (colegas) e registrando-os no mediador
Manager client = new Manager(mediator, "Mainara");
Manager po = new Manager(mediator, "Beatriz");
Manager techLead = new Manager(mediator, "Vini");

Employee matheus = new Employee(mediator, "Matheus");
Employee gustavo = new Employee(mediator, "Gustavo");
Employee luis = new Employee(mediator, "Luis");
Employee erick = new Employee(mediator, "Erick");

Intern anaJulia = new Intern(mediator, "Ana Julia");
Intern camila = new Intern(mediator, "Camila");

mediator.AddColleague(po);
mediator.AddColleague(client);
mediator.AddColleague(gustavo);
mediator.AddColleague(matheus);
mediator.AddColleague(erick);
mediator.AddColleague(anaJulia);
mediator.AddColleague(camila);


// Enviando mensagens
client.Send("Pessoal, vamos subir o Florida!");
po.Send("Atualizem seus cards, pois amanhã vou fazer planning da implementação.");

matheus.Send("Vish, vou ter que atualizar tudo hoje!");
gustavo.Send("Sla, mano...");
erick.Send("Oi, oi, oi");

anaJulia.Send("Beleze, Bia. Falta só o de hoje!");
camila.Send("Ok! O meu já está atualizado!");

luis.Send("Gente, vou sair da empresa!");
techLead.Send("Eu tbm. Vou junto kkk");