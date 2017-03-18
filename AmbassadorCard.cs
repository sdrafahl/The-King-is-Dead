namespace King_Is_Dead{
    
    public class AmbassadorCard:ActionCard {
        
        Region from;
        Follower fr;
        Region to;
        Follower t;
        

        public AmbassadorCard():base() {
            
        }

        public override void setTarget(Region from,Region to,Follower fr,Follower t){
            this.from=from;
            this.to=to;
            this.fr = fr;
            this.t = t;
        }

        public override void playCard(){
            if(!used){
                used = 1;
                Follower temp = from.removeLoyalist(fr.faction);
                to.addLoyalist(temp);
                Follower temp1 = to.removeLoyalist(t.faction);
                from.addLoyalist(temp1);
            }
            

        }

        public override int getinttype(){
            return 2;
        }

        

    }
}