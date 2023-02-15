using System;
namespace Assignment22
{

    class Insurance
    {
        static int counter = 1000;
        int insuranceId;
        string consumerName;
        int age;
        int creditHistory;
        string[] documents;

        static Insurance()
        {
            counter = 1000;
        }

        public Insurance()
        {
            age = 0;
            creditHistory = 0;
        }

        public Insurance(string consumerName) : this()
        {
            this.consumerName = consumerName;
        }

        public Insurance(string consumerName, string[] documents)
        {
            this.consumerName = consumerName;
            this.documents = documents;
        }

        public Insurance(string consumerName, int age, int creditHistory, string[] documents)
        {
            this.consumerName = consumerName;
            this.documents = documents;
            this.age = age;
            this.creditHistory = creditHistory;
        }

        public bool CheckEligibility()
        {
            if (age < 18)
            {
                return false;
            }
            else if (age > 18 && age <= 30 && creditHistory <= 60000)
            {
                return true;
            }
            else if (age > 30 && creditHistory <= 45000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckDocuments(string[] acceptableDocuments)
        {
            if (CheckEligibility())
            {

                foreach (string document in documents)
                {
                    foreach (string acceptableDocument in acceptableDocuments)
                    {
                        if (document == acceptableDocument)
                        {
                            insuranceId = counter++;
                            return true;
                        }
                    }
                }
                return false;
            }
            else { return false; }
        }



        static void Main(string[] args)
        {
            string[] acceptableDocuments = { "adharcard ", "pan card", "passport" };
            Insurance i = new Insurance("usha", 25, 25000, new string[] { "aadhar card", "passport" });
            Console.WriteLine("is the consumer eligible for insurace:" + i.CheckEligibility());
            Console.WriteLine("does the consumer have the required documents:" + i.CheckDocuments(acceptableDocuments));
            Console.WriteLine("insurance id:" + i.insuranceId);
        }
    }
}



