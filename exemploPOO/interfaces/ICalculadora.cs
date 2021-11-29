namespace exemploPOO.Interfaces
{
    public interface ICalculadora
    {
        // é possivel implementear os metodos na interfaçe apartatir do .Net 3, assim as class que extançiar a interface não precisan implementar os metodos das mesmas.
        double Soma(double nub1, double nub2);
        double Subt(double nub1, double nub2);
        double Divd(double nub1, double nub2);
        double Mult(double nub1, double nub2);
    }
}