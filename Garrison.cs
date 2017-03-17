namespace King_Is_Dead{
    
    public class Garrison:ActionCard {

         int used;
         Region from;
         Region to;
         Follower fr;
         Follower t;
         Follower fr2;

         public Gerrison():base() {
            this.used = 0;
        }

        public override void setTarget(Region from,Region to,Follower fr,Follower t,Follower fr2){
            this.from=from;
            this.to=to;
            this.fr = fr;
            this.t = t;
            this.fr2 = fr2;
        }

        public override void playCard(){
            if(!used){
                this.used = 1;
                Follower temp = from.removeLoyalist(fr.faction);
                to.addLoyalist(temp);
                Follower temp1 = to.removeLoyalist(t.faction);
                from.addLoyalist(temp1);
                Follower temp2 = from.removeLoyalist(fr2.faction);
                to.addLoyalist(temp2);
            }
            

        }
    }
}