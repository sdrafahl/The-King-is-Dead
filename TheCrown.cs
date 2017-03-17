namespace King_Is_Dead{
    
    public class TheCrown:ActionCard {

        int used;
        Map map;

         public TheCrown(Map m):base() {
            this.map = m;
            this.used = 0;
            int index1;
            int index2;

        }

        public override void setTarget(int index1,int index2){
            this.index1=index1;
            this.index2=index2;
        }

        public override void playCard(){
            if(!used){
                this.used=1;
                map.swapQue(this.index1,this.index2);
            }
            

        }
    }
}