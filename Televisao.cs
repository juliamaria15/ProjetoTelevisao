public class Televisao
{
    private const int VOLUME_MAX = 100;
    private const int CANAL_MAX = 520;
    private const int CANAL_MIN = 1;

    private int volume;
    private int canalAtual;
    private bool ligada;
    private bool mudo;

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        volume = 50;        // volume inicial padrão
        canalAtual = CANAL_MIN;  // canal inicial padrão
        ligada = false;
        mudo = false;
    }

    public float Tamanho { get; }

    public void Ligar()
    {
        if (!ligada)
        {
            ligada = true;
            Console.WriteLine("TV ligada.");
        }
        else
        {
            Console.WriteLine("TV já está ligada.");
        }
    }

    public void Desligar()
    {
        if (ligada)
        {
            ligada = false;
            Console.WriteLine("TV desligada.");
        }
        else
        {
            Console.WriteLine("TV já está desligada.");
        }
    }

    public void AumentarVolume()
    {
        if (!ligada)
        {
            Console.WriteLine("TV está desligada. Ligue para ajustar volume.");
            return;
        }

        if (mudo)
        {
            mudo = false;
            Console.WriteLine("Mudo desligado.");
        }

        if (volume < VOLUME_MAX)
        {
            volume++;
        }
        else
        {
            Console.WriteLine("Volume já está no máximo.");
        }
    }

    public void DiminuirVolume()
    {
        if (!ligada)
        {
            Console.WriteLine("TV está desligada. Ligue para ajustar volume.");
            return;
        }

        if (mudo)
        {
            mudo = false;
            Console.WriteLine("Mudo desligado.");
        }

        if (volume > 0)
        {
            volume--;
        }
        else
        {
            Console.WriteLine("Volume já está no mínimo.");
        }
    }

    public void AtivarOuDesativarMudo()
    {
        if (!ligada)
        {
            Console.WriteLine("TV está desligada.");
            return;
        }

        mudo = !mudo;
        Console.WriteLine(mudo ? "Mudo ativado." : "Mudo desativado.");
    }

    public void AvancarCanal()
    {
        if (!ligada)
        {
            Console.WriteLine("TV está desligada. Ligue para mudar canal.");
            return;
        }

        if (canalAtual < CANAL_MAX)
        {
            canalAtual++;
        }
        else
        {
            canalAtual = CANAL_MIN; // volta para o primeiro canal
        }
    }

    public void RetrocederCanal()
    {
        if (!ligada)
        {
            Console.WriteLine("TV está desligada. Ligue para mudar canal.");
            return;
        }

        if (canalAtual > CANAL_MIN)
        {
            canalAtual--;
        }
        else
        {
            canalAtual = CANAL_MAX; // volta para o último canal
        }
    }

    public void IrParaCanal(int numero)
    {
        if (!ligada)
        {
            Console.WriteLine("TV está desligada. Ligue para mudar canal.");
            return;
        }

        if (numero < CANAL_MIN || numero > CANAL_MAX)
        {
            Console.WriteLine($"Canal inválido. Digite um canal entre {CANAL_MIN} e {CANAL_MAX}.");
            return;
        }

        canalAtual = numero;
    }

    public int ObterVolume()
    {
        return volume;
    }

    public int ObterCanal()
    {
        return canalAtual;
    }

    public void ExibirEstado()
    {
        Console.WriteLine($"TV está {(ligada ? "ligada" : "desligada")}.");
        Console.WriteLine($"Canal atual: {canalAtual}");
        Console.WriteLine($"Volume: {(mudo ? "Mudo" : volume.ToString())}");
    }
}