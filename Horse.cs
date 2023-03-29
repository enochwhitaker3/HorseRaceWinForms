namespace WinFormsApp1
{
    public class Horse
    {
        public int Mod = 100;
        public int RaceDistance = 100;
        public int AllowedMatchingAttempts = 1;
        public int ID { get; set; }
        public int RaceLocation { get; private set; }    
        public Horse(int id)
        {
            ID = id;
            RaceLocation = 0;
        }
        public bool isFinished => RaceLocation >= RaceDistance;
        public int progressPercent => (int)((RaceLocation * 100.0) / RaceDistance);
        public void Advance()
        {
            if(RaceLocation < 100)
            {
                if(Random.Shared.Next() % 1000 == 0)
                {
                    RaceLocation++;
                }
            }
        }
    }
}
