// Eventos
Event magic = new Magic("Reino Norte", "AM");
Event batle = new Batle("Reino Sul", "PM");
Event fireworks = new Firework("Reino Leste", "PM");

// Anunciadores
Elder elderMagic = new Elder(magic);
Elder elderBatle = new Elder(batle);
Elder elderFireworks = new Elder(fireworks);

// Observadores
Citzen citzen1 = new Citzen("Ana Julia");
Citzen citzen2 = new Citzen("Beatriz");
Citzen citzen3 = new Citzen("Carlos");
Citzen citzen4 = new Citzen("Danilo");

// Registrando observadores
elderMagic.RegisterObserver(citzen1);
elderMagic.RegisterObserver(citzen2);

elderBatle.RegisterObserver(citzen3);

elderFireworks.RegisterObserver(citzen4);

// Alterando os Eventos
elderMagic.SetEvent("Reino Norte", "noite");
elderBatle.SetEvent("Reino X", "manhã");
