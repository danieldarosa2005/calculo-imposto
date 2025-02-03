class Individual : TaxPayer {
    public double HealthExpenditures { get; set; }

    public Individual() {

    }
    public Individual (string name, double anualincome, double healthExpenditures)
    : base (name, anualincome) {
        HealthExpenditures = healthExpenditures;
    }

    // public override double Tax()
    // {
    
    //     if (HealthExpenditures < 1 && AnualIncome < 20000) {
    //        return AnualIncome * 0.15;
    //     } else {
    //         return HealthExpenditures * 0.5 + AnualIncome * 0.25;
    //     }
    // }
      public override double Tax() {
             if (AnualIncome < 20000.0) {
                 return AnualIncome * 0.15 - HealthExpenditures * 0.5;
             }
             else {
                 return AnualIncome * 0.25 - HealthExpenditures * 0.5;
             }
} }

abstract class TaxPayer {
    public string Name { get; set; }
    public double AnualIncome { get; set; }

    public TaxPayer () {

    }
    public TaxPayer(string name, double anualincome) {
        Name = name;
        AnualIncome = anualincome;
    } 
    public abstract double Tax();

}