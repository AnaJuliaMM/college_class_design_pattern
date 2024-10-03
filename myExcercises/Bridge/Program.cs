using Bridge.screens;
using Bridge.shapes;


// Criando formas e controle
Shape circle = new Circle("Black", 0, 10);
Screen tablet = new UniversalScreen(circle);
Screen mobile = new UniversalScreen(circle);

tablet.Draw();

