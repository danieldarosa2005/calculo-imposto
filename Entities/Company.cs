 class Company : TaxPayer {
    public int NumberOfEmployees { get; set; }

    public Company() {

    }
    public Company (string name, double anualincome, int numberOfEmployees)
    : base (name, anualincome) {
        NumberOfEmployees = numberOfEmployees;
    }
    public override double Tax()
    {
        if (NumberOfEmployees > 10) {
            return AnualIncome * 0.14;
            
        } else {
            return AnualIncome * 0.16;
        }
    }


}