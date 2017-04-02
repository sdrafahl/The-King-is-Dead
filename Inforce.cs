namespace King_Is_Dead{
    
    

    public class Inforce:ActionCard {

        /*1 is British,2 is scots,3 is welsh */
        int faction;
        
        Region from;
        Region to;

        public Inforce(int faction){
            this.faction=faction;
            
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
                            used=1;
                            to.addLoyalist(new Follower(faction));
                        }
                    }
                }
            }
            

    }

    public override int getinttype(){
            switch(faction){
                case 1:
                    return 4;
                

                case 2:
                    return 5;
                

                case 3:
                    return 6;

                default:
                    return 10;
                
            }
            
        }
    }
}