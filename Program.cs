using System;

class Program{
    static void Main(string[] args){
        


        bool isWorking = true;
       
        while(isWorking){
             bool isWorking2 = true;
             bool isWorking3 = true;
            Console.Write("Enter DNA :");
            string DNAInput = Console.ReadLine();
            
            if(IsValidSequence(DNAInput)){
                    Console.WriteLine("Current half DNA sequence : " + DNAInput);
                    while(isWorking3){
                        Console.Write("Do you want to replicate it ? (Y/N) :");
                        string userInput = Console.ReadLine();
                        if(userInput == "Y"){
                            Console.WriteLine("Replicated half DNA sequence : " + ReplicateSeqeunce(DNAInput));
                            while(isWorking2){
                                Console.Write("Do you want to process another sequence ? (Y/N) :");
                                userInput = Console.ReadLine();
                                if(userInput == "Y"){
                                    isWorking2 = false;
                                    isWorking3 = false;
                                    break;
                                }else if(userInput == "N"){
                                    isWorking = false;
                                    isWorking3 = false;
                                    break;
                                }else{
                                    Console.WriteLine("Please input Y or N.");
                                    continue;
                                }
                            }
                            
                        }else if(userInput =="N"){
    
                                 while(isWorking2){
                                    Console.Write("Do you want to process another sequence ? (Y/N) :");
                                    userInput = Console.ReadLine();
                                    if(userInput == "Y"){
                                        isWorking2 = false;
                                        isWorking3 = false;
                                        break;
                                    }else if(userInput == "N"){
                                        isWorking = false;
                                        isWorking3 = false;
                                        break;
                                    }else{
                                        Console.WriteLine("Please input Y or N.");
                                        continue;
                                    }
                                 }
                        }else{
                            Console.WriteLine("Please input Y or N.");
                            continue;
                        }
                    }
            }else{
                    Console.WriteLine("That half DNA sequence is invalid.");
                    while(isWorking2){
                        Console.Write("Do you want to process another sequence ? (Y/N) :");
                        string userInput = Console.ReadLine();
                        if(userInput == "Y"){
                            isWorking2 = false;
                            break;
                        }else if(userInput =="N"){
                            isWorking = false;
                            isWorking3 = false;
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