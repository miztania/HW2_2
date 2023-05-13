using System;

class Program{
    static void Main(string[] args){
        Console.Write("Enter DNA :");
        string DNAInput = Console.ReadLine();


        bool isWorking = true;
        while(isWorking){
        if(IsValidSequence(DNAInput)){
                Console.WriteLine("Replicated half DNA sequence : " + DNAInput);
                while(true){
                    Console.Write("Do you want to replicate it ? (Y/N) :");
                    string userInput1 = Console.ReadLine();
                    if(userInput1 == "Y"){
                        Console.WriteLine("Replicated half DNA sequence : " + ReplicateSeqeunce(DNAInput));
                        while(isWorking){
                            Console.Write("Do you want to process another sequence ? (Y/N) :");
                            string userInput3 = Console.ReadLine();
                            if(userInput3 == "Y"){
                                break;
                            }else if(userInput3 == "N"){
                                isWorking = false;
                                break;
                            }else{
                                Console.WriteLine("Please input Y or N.");
                                continue;
                            }
                        }
                        
                    }else if(userInput1 =="N"){
                        isWorking = false;
                        break;
                    }else{
                        Console.WriteLine("Please input Y or N.");
                        continue;
                    }
                }
        }else{
                Console.WriteLine("That half DNA sequence is invalid.");
                while(isWorking){
                    Console.Write("Do you want to process another sequence ? (Y/N) :");
                    string userInput2 = Console.ReadLine();
                    if(userInput2 == "Y"){
                        break;
                    }else if(userInput2 =="N"){
                        isWorking = false;
                        break;
                    }else{
                        Console.WriteLine("Please input Y or N.");
                        continue;
                    }
                }
            }
        }


    }

    static bool IsValidSequence(string halfDNASequence){
            foreach(char nucleotide in halfDNASequence)
            {
                if(!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
    }

    static string ReplicateSeqeunce(string halfDNASequence){
            string result = "";
            foreach(char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
    }




}