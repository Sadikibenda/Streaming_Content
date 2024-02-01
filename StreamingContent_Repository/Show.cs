
public class Show : StreamingContent 
{
    public double AverageRunTime {
        get
        {
        //total runtime = add all episode runtime value 
            double total = 0;
            double averageRunTime = 0;
         foreach(Episode i in Episodes)

        {   
            Console.WriteLine(i.RunTime);
            total = total + i.RunTime;
        }
            Console.WriteLine(total);
        //divide total runtime by the number of episode
            averageRunTime = total / Episodes.Count;
            return averageRunTime;
        }

     }

    public List<Episode> Episodes { get; set; } = new List<Episode>();

   
}   

public class Episode 
{
    public string Name { get; set; }
    public double RunTime { get; set; }
    
    //public List<Episode> Episodes { get; set; } = new List<Episode>(); (had been moved to show class so that Episodes can be added to any show)

}