namespace HellowWorld.Models
{
    //A simple Model Class
    //The Model is where our Business data (and business rules) will live
    //for Example, in a banking application it’s where the customer class, account class, all code related to business itself, would be placed
    //- Validation logic would also go in the model class(es) e.g. Check if customer ID correct length, Customer DOB is a valid date or age is not less than 0

    public class Student
    {
        public string Name { get; set; } = "";
        public int    Age  { get; set; }
    }
}
