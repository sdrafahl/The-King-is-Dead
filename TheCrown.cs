namespace King_Is_Dead{
    
    public class TheCrown:ActionCard {

        
        Map map;

         public TheCrown(Map m):base() {
            this.map = m;
            int index1;
            int index2;

        }

        public override void setTarget(int index1,int index2){
            this.index1=index1;
            this.index2=index2;
        }

        public override void playCard(){
            if(!used){
                used=1;
                map.swapQue(this.index1,this.index2);
            }
            

        }
        public override int getinttype(){
            return 0;
        }
    }
}