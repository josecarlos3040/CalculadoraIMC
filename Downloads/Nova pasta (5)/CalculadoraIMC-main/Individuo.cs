public class Individuo
{
    public string Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    public double IMC { get => Peso / (Altura * Altura); }
    public string Classificacao
    {
        get {
            if(IMC < 18.5)
            {
                return "Peso abaixo do normal";
            }
            else if(IMC >= 18.5 && IMC <= 24.9)
            {
                return "Peso normal ";
            }
            else if(IMC >= 25.0 && IMC <= 29.9)
            {
                return "Sobre o Peso";
            }
            else if(IMC >= 30.0 && IMC <= 34.9)
            {
                return "1° de Obesidade";
            }
            else if(IMC >= 35.0 && IMC <= 39.9)
            {
                return "2° de Obesidade";
            }
            else
            {
                return "3° de Obesidade";
            }
        }
    }

    public Individuo()
    {
        Nome = "";
        Altura = 0;
        Peso = 0;
    }

    public Individuo(string nome, float altura, float peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }

    public double GanharPeso() => (18.5 * Altura * Altura) - Peso;
    public double PerderPeso() => Peso - (24.9 * Altura * Altura);
}