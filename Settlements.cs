namespace King_Is_Dead{
    
    public class Settlements:ActionCard {

        
        

        Region to1;
        Region to2;
        Region to3;
        Follower t1;
        Follower t2;
        Follower t3;

        public AmbassadorCard():base() {
            
        }

        public override void setTarget(Region to1,Region to2,Region to3,Follower t1, Follower t2, Follower t3){
            this.to1=to1;
            this.to2=to2;
            this.to3=to3;
            this.t1=t1;
            this.t2=t2;
            this.t3=t3;
        }

        public override void playCard(){
            if(!used){
                to1.addLoyalist(t1);
                to2.addLoyalist(t2);
                to3.addLoyalist(t3);
                used=1;
            }
            
        }

        public override int getinttype(){
            return 3;
        }

    }
}