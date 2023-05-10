namespace Figura;

class Triangulo : IFigura{

public Triangulo(int alto, int baset){
    this.alto=alto;
    this.ancho=baset;
}
 public int alto {get;set;}

 public int ancho {get;set;}

 public int area (){
    return (this.alto*this.ancho)/2;
}

}