namespace King_Is_Dead{
    
    

    public class Inforce:ActionCard {

        /*1 is British,2 is scots,3 is welsh */
        int faction;
        int used;
        Region from;
        Region to;

        public Inforce(int faction){
            this.faction=faction;
            this.used=0;
        }

        public override void setTarget(Region from,Region to){
            this.from=from;
            this.to=to;
        }

        public override void playCard(){
            if(!used){
                if(from.isNeighbor(to)){
                    if(from.faction == faction){
                        if(to.faction==0){
                            this.used=1;
                            to.addLoyalist(new Follower(faction));
                        }
                    }
                }
            }
            

    }
}