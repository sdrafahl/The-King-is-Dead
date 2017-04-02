namespace King_Is_Dead{
    
    public abstract class ActionCard{

       // int used;

        public ActionCard(){
            used=0;
        }

        int used {get; set;}

        abstract public void setTarget();
        abstract public void playCard();
        abstract public int getinttype();
        
    }
}