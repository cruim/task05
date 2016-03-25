namespace Task_5
{
    class Animal
    {
        public ISpeaking Speaking { get; set; }
        public IMoving Moving { get; set; }

        public Animal(ISpeaking _speaking)
        {
            Speaking = _speaking;

        }

        public Animal(IMoving _moving)
        {
            Moving = _moving;
        }

        public Animal()
        {
            
        }
    }
}
