namespace QuartaAtividade.Entities;

public class Agendamento
{
    public Cidadao Cidadao { get; set; } = null;
    public DateTime DataDeVacinaçao { get; set; }

    public Agendamento(Cidadao cidadao, DateTime dataDeVacinaçao)
    {
        Cidadao = cidadao;
        DataDeVacinaçao = dataDeVacinaçao;
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Agendamento)) return false;
        
        Agendamento other = obj as Agendamento;
        return DataDeVacinaçao.Equals(other.DataDeVacinaçao);
    }

    public override int GetHashCode()
    {
        return Cidadao.GetHashCode() + DataDeVacinaçao.GetHashCode();
    }
}