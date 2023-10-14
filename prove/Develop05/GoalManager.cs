public class GoalManager {

   public List<Goal> _goals = new List<Goal>();

  
   public GoalManager(List<Goal> goal){
        _goals = goal;
   }
   
    int option = 0;
    public void run(){
    do
        {
   
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal" +
                            "\n     2. List Goal" +
                            "\n     3. Save Goal" +
                            "\n     4. Load Goal" +
                            "\n     5. Record Event" +
                            "\n     6 Quit \n");
            Console.WriteLine("Select a choice from the menu: ");
            option = Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Chek List Goal");
                    Console.WriteLine ("Which type of goal would you like to crate?");
                    int goalType = Convert.ToInt32(Console.ReadLine());
                    string name = Console.ReadLine();
                    string description = Console.ReadLine();
                    int ponts = Convert.ToInt32(Console.ReadLine());
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        } while (option != 4);


    }//end run

   
    }
} 