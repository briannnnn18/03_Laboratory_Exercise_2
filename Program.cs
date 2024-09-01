using System;

class LabExercise_Ceniza
{
    static void Main()
    {
        
        while (true)
        {
            // first part ng program, kung saan nagpapakita ng greeting at nagtatanong kung gusto ng user na mag-enroll
            Console.WriteLine("Welcome to STI Enrollment Portal!");
            Console.WriteLine("Do you want to enroll in our School? (Yes/No)");
            string enrollmentResponse = Console.ReadLine().Trim().ToLower();

           
            if (enrollmentResponse == "no")
            {
                Console.WriteLine();
                // output pag nag no yung user tapos mag e-end na agad yung program
                Console.WriteLine("Ohh okay. Hope to see you soon!");
                break;
            }

            Console.WriteLine();
            // Kung ang user ay gusto mag-enroll, mag a-ask ang program kung magkano ang pera na meron ang user
            Console.Write("How much money do you have? ");
            string fundsInput = Console.ReadLine().Trim();
            int availableFunds = Convert.ToInt32(fundsInput);

            // Ito ang bahagi ng program kung saan nagche-check kung sapat ang pera ng user para mag-enroll
            // Kung ang pera ng user ay hindi sapat, magpapakita ng error message at mag-eexit ang program
            if (availableFunds <= 24000)
            {
                Console.WriteLine();
                // Ito ang bahagi ng programa kung saan nagpapakita ng error message kung hindi sapat ang pera ng user
                Console.WriteLine("It looks like you don't have enough money at the moment. Remember, you need more than 24,000.");
                break;
            }

            Console.WriteLine();
            // Print out kung ang pera ng user ay sapat, magtatanong ang program kung meron ang user ng mga kinakailangang document
            Console.WriteLine("Perfect! Now, we need to check if you have the required documents.");
            Console.WriteLine();
            Console.WriteLine("________________________________________________________________________________________________");
            Console.WriteLine();

            // dito nagche-check kung meron ang user ng mga kinakailangang document
            // Ginagamit ang isang separate na method na tinatawag na AskForDocument para mag ask kung meron ang user ng isang document

            bool hasDiploma = AskForDocument("SHS/ISD Diploma");
            
            bool hasForm137 = AskForDocument("Form 137");
            
            bool hasGoodMoral = AskForDocument("Good Moral Certificate");
            
            bool hasPSA = AskForDocument("PSA");
            
            bool hasMedCert = AskForDocument("Medical Certificate");

            // dito nagche-check kung meron ang user ng lahat ng kinakailangang document
            if (hasDiploma && hasForm137 && hasGoodMoral && hasPSA && hasMedCert)
            {
                Console.WriteLine();
                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine();
                // dito sa section naman na ito nagpapakita ng success message kung meron ang user ng lahat ng kinakailangang document
                Console.WriteLine("Congratulations! You're ready to enroll!");
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("________________________________________________________________________________________________");
                // Ito yung section na kung saan nagpapakita ng error message kung kulang ang document na naipresent ng user
                Console.WriteLine("Oops! It seems like you're missing some documents.");
                break;
            }
        }
    }

    // Ito ang separate na method na ginagamit para magtanong kung meron ang user ng isang document
    static bool AskForDocument(string documentName)
    {
       
        // Nagtatanong kung merong document yung user
        Console.Write($"Do you have your {documentName}? (Yes/No): ");
        string response = Console.ReadLine().Trim().ToLower(); Console.WriteLine();

        return response == "yes";
    }
}