# Ruleta Del Infortunio

# Introducción
¿Alguna vez han estado en un casino y se han preguntado cómo funcionan esas máquinas digitales que parecen tener el control de todo? 

Bueno, déjenme contarles cómo surgió la idea de este proyecto. Resulta que durante mi último cumpleaños, salí con amigos al casino y me llamó mucho la atención que todas las máquinas estaban digitalizadas, incluso la ruleta

Lo curioso es que, sin importar cuánto apostara, nunca lograba ganar. En ese momento, tenia dos opciones o aceptar que las posibildades son minimas o que la maquina esta arreglada (es lo mas seguro) y **comenze a pensar como funciona la ruleta**

solo era cosa de que despues de que todos realizen la apuesta entrar esos datos en el sistema y este se encargaria de encontrar un numero que no cumpla con los atributos una vez calculado giraria la ruleta. pero ¿como saber de que la bola caiga donde el sistema quiere? la unica forma es que cada cuadrado de la ruleta que representan al numero sean electroimanes y la bola sea de metal

**me pareció un desafío divertido y espero que a ustedes tambien**

# ¿como funciona?

arrancamos el juego con 4000 creditos y 4 tipos de fichas con valor de 100, 200, 500 y 1000 

https://github.com/bautista-escalante/Ruleta_Del_Infortunio/assets/123372673/7f43a903-5efa-4ded-ae7a-29df539abe83

se debe apuestar sea a un numero especifico o un periferico 

luego de que el contador de tiempo llegue a 0 se "gira" la ruleta con una animacion y finalmente se da a conocer el numero que el sistema eligido por el sistema

# Ejemplo

se aposto a que sea par pero salio el 35

https://github.com/bautista-escalante/Ruleta_Del_Infortunio/assets/123372673/671b5d8b-82d3-4416-97fc-31149f98d7d4

# ¿por que es imposible ganar?

dentro de la clase periferia tenemos este metodo nos devuelve una lista de numeros que cumplen con el atributo que se pide

```csharp
 public List<int> ObtenerNumeros()
 {
     List<int> retorno = new List<int>();
     switch(this.objeto)
     {
         case "rombo":
             if(base.color == "rojo")
             {
                 retorno = base.rojo;
             }
             else if(base.color == "negro")
             {
                 retorno = base.negro;
             }
             break;
         case "pares":
             for(int i = 0; i < 36; i++)
             {
                 if (base.esPar(i))
                 {
                     retorno.Add(i);
                 }
             }
             break;
         case "impares":
             for (int i = 0; i < 36; i++)
             {
                 if (base.esPar(i) == false)
                 {
                     retorno.Add(i);
                 }
             }
             break;
         case "1ra docena":
             retorno.AddRange([1,12]);
             break;
         case "2da docena":
             retorno.AddRange([13, 24]);
             break;
         case "3ra docena":
             retorno.AddRange([25, 36]);
             break;
         case "1ra linea":
             bool bandera = true;
             int resultado = 1;
             for (int i = 1; i < 37; i++)
             {
                 if (bandera || i == resultado)
                 {
                     bandera = false;
                     retorno.Add(i);
                     resultado += 3;
                 }
             }
             break;
         case "2da linea":
             bool flag = true;
             int result = 2;
             for (int i = 2; i < 37; i++)
             {
                 if (flag || i == result)
                 {
                     flag = false;
                     retorno.Add(i);
                     result += 3;
                 }
             }
             break;
         case "3ra linea":
             for (int i = 1; i < 37; i++)
             {
                 if (i % 3 == 0)
                 {
                     retorno.Add(i);
                 }
             }
             break;
     }
     return retorno;
 }
```

dentro de la clase FrmRuleta tenemois este metodo que devuelve true si encuentra el numero dentro de la lista

```csharp
private bool EncontrarNumero(List<int> ListaNumeros, int num)
{
    bool encontrado = false;

    for (int i = 0; i < ListaNumeros.Count; i++)
    {
        if (num == ListaNumeros[i])
        {
            encontrado = true;
            break;
        }
    }
    return encontrado;
}
```
en esta misma clase tenemos a este metodo que crea un numero aleatorio y usando el metodo EncontrarNumero() verifiamos que no se encuentre dentro de la lista que le pasamos por parametro

si el numero no esta dentro de esta lista entonces lo retornamos

```csharp
private int GenerarNumero(List<int> ListaNumeros)
{
    Random rnd = new Random();
    while (true)
    {
        int numeroAleatorio = rnd.Next(0, 37);
        if (this.EncontrarNumero(ListaNumeros, numeroAleatorio) == false)
        {
            return numeroAleatorio;
        }
    }
}
```

dentro de el manejo de evento del picturebox usamos tosos estos metodos para saber que numero salio y asignar true o false a this.ganador

```csharp
private void PbPares_Click(object sender, EventArgs e)
{

    PbPeriferico7.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos_elegidos\\pares_elegido.png");
    Periferia pares = new Periferia("pares", 18);
    this.numeroSaliente = this.GenerarNumero(pares.ObtenerNumeros());
    if (this.EncontrarNumero(pares.ObtenerNumeros(), this.numeroSaliente))
    {
        this.ganador = true;
        this.valorApuesta = pares.valor;
    }
    else
    {
        this.valorApuesta = 0;
        this.ganador = false;
    }
}
```
y finalmente cuando el tiempo de la apusta termine evaluamos la si es un ganador o no 

```csharp
    if (ganador)
    {
        int ganancia = valorApuesta * valorFicha;
        this.creditos += ganancia;
        this.LblValorFicha.Text = $"ganaste {ganancia} creditos";
    }
    else
    {
        this.creditos -= valorFicha;
    }
    LblCreditoDisponibles.Text = $"tienes {this.creditos} creditos";
    
}
```

# FichasInsuficientesExepcion

si los creditos son menor al valor de la ficha se lanza una exepcion y se informa cuantos creditos le faltan
```csharp
 try
 {
     if(this.creditos < 100)
     {
         throw new FichasInsuficientesExepcion(this.creditos, this.valorFicha);
     }
     this.OrdenarFichas();
     PbFicha1.Image = this.fichasElegidas[0];
     this.valorFicha = 100;
     this.LblValorFicha.Text = $"valor de ficha: {this.valorFicha}";
 }
 catch (FichasInsuficientesExepcion ex)
 {
     this.LblCreditoDisponibles.Text = ex.Message;
 }
```

# link de descarga

https://drive.google.com/file/d/191geR2vACNXvjF2gMGhcLFl-xY7pOwcj/view?usp=sharing
