namespace CTM.Common.Constants
{
    public static class Errors
    {
        public const string Postcode = @"Your postcode has not been recognised, " + 
            "please check you have entered it correctly and if you still need help " + 
            "call the switching support team on 0800 093 6831";

        public const string Complete = "Complete this section to continue {} " + 
            "remaining view question";

        public const string Email = "Your email doesn’t appear to be valid. " + 
            "please check you have entered it correctly.";

        public const string ReviewElectricitySpend = "We've calculated that your electricity usage is negative.\n" + 
            "This is because the spend figure you have entered here is too small. " + 
            "Please review and correct your spend amount.";
    }
}
