using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 An event is organized and the following has to happen. 


The chief guest needs to be picked up from the airport. 
The stage has to be decorated. 
The catering team needs to start preparing food
The transport team needs to drop the food raw materials to the venue before the cooking needs to start. 
The chief guest's speech needs to be reviewed by the PA
The venue needs to be checked for security features like bomb threat, etc
Prize distribution is set to happen at the end of the event so all the prizes that need to be presented should be brought to the venue. 
The chief guest needs to give the speech. 
Prizes need to be distributed. 
Food has to be provided to all participants. 

Please write a C# program to make use of the Async Programming concepts and write the program so that all of the above happen in a correct order. 
 
 */
namespace C__Tasks
{
    internal class eventoraganization
    {


        static void Mssain(string[] args)
        {
            Task chiefGuest = PickUpChiefGuest();
            DecorateStage();
            DropOffRawMaterials();
            CheckSecurity();
            Task BringPrize = BringPrizes();
            Task.WaitAll(BringPrize, chiefGuest);
            //ProvideFood();
            Console.ReadLine();
        }
        static async Task PickUpChiefGuest()
        {
            Console.WriteLine("Picking chief guest task started");
            await Task.Delay(10000);
            Console.WriteLine("Chief guest has arrived");
            ReviewSpeech();
        }
        static async Task DecorateStage()
        {
            Console.WriteLine("Decorating stage task started");
            await Task.Delay(5000);
            Console.WriteLine("Stage has been decorated");
        }
        static async Task PrepareFood()
        {
            Console.WriteLine("Food preparation started");
            await Task.Delay(15000);
            Console.WriteLine("Food preparation ended");
        }
        static async Task DropOffRawMaterials()
        {
            Console.WriteLine("Rawmaterial droppoff started");
            await Task.Delay(2000);
            Console.WriteLine("Rawmaterial droppoff ended");
            Task prepareFood = PrepareFood();
            Task.WaitAll(prepareFood);
            ProvideFood();
        }
        static async Task ReviewSpeech()
        {
            Console.WriteLine("Speech is being reviewed");
            await Task.Delay(2000);
            Console.WriteLine("Speech reviewed successfully");
            Task giveSpeech = GiveSpeech();
            Task.WaitAll(giveSpeech);
            DistributePrizes();
        }
        static async Task CheckSecurity()
        {
            Console.WriteLine("Security checking is going on");
            await Task.Delay(25000);
            Console.WriteLine("Security check is completed");
        }
        static async Task BringPrizes()
        {
            Console.WriteLine("Prize is bringing up to the venue");
            await Task.Delay(3000);
            Console.WriteLine("Prize has been bought up to the venue");
        }
        static async Task GiveSpeech()
        {
            Console.WriteLine("Speech started");
            await Task.Delay(5000);
            Console.WriteLine("Speech has ended");
        }
        static async Task DistributePrizes()
        {
            Console.WriteLine("Prize distribution started");
            await Task.Delay(15000);
            Console.WriteLine("Prize distribution ended");
        }
        static async Task ProvideFood()
        {
            Console.WriteLine("Food is being provided");
        }
    }
}
