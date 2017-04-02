using System.Collections;
namespace King_Is_Dead{
    
     

   public class Map {
        
        RegionCard[] que;
        Region Caledonia;
        Region Din_Eidyn;
        Region Eboracum;
        Region Deva;
        Region Ratae;
        Region Caerleon;
        Region Londinium;
        Region AquaeSulis;


        public Map(){
            setupRegions();
            setupPowerStruggle();
            que = new RegionCard[8];
        }

        public void swapQue(int index1, int index2){
            
            if(index1>index2){
                return;
            }
            if(index2>7 || index1>7){
                return;
            }
            Region temp1 = que[index1];
            Region temp2 = que[index2];

            que[index1] = temp2;
            que[index2] = temp1;

        }

        public Region getRegioninQue(int quenum){
            return que[quenum];
        }

        private void setupRegions(){
            Caledonia = new Region("Caledonia");
            Din_Eidyn = new Region("Din Eidyn");
            Eboracum = new Region("Eboracum");
            Deva = new Region("Deva");
            Ratae = new Region("Ratae");
            Caerleon = new Region("Caerleon");
            Londinium = new Region("Londindium");
            AquaeSulis = new Region("Aquae Sulis");

            Caledonia.addNeighbor(Din_Eidyn);
            Din_Eidyn.addNeighbor(Eboracum);
            Din_Eidyn.addNeighbor(Deva);
            Eboracum.addNeighbor(Deva);
            Eboracum.addNeighbor(Ratae);
            Eboracum.addNeighbor(Londindium);
            Eboracum.addNeighbor(AquaeSulis);
            Deva.addNeighbor(Ratae);
            Deva.addNeighbor(Caerleon);
            Deva.addNeighbor(AquaeSulis);
            Caerleon.addNeighbor(AquaeSulis);
            AquaeSulis.addNeighbor(Londindium);

            Caledonia.addLoyalist( new Follower(2));
            Caledonia.addLoyalist( new Follower(2));
            Caerleon.addLoyalist(new Follower(3));
            Caerleon.addLoyalist(new Follower(3));
            Londindium.addLoyalist(new Follower(1));
            Londindium.addLoyalist(new Follower(1));
            
            Londindium.faction=1;
            Caerleon.faction=3;
            Caledonia.faction=2;

            assignRanLoyalist(Caledonia);
            assignRanLoyalist(Din_Eidyn);
            assignRanLoyalist(Eboracum);
            assignRanLoyalist(Deva);
            assignRanLoyalist(Ratae);
            assignRanLoyalist(Caerleon);
            assignRanLoyalist(Londinium);
            assignRanLoyalist(AquaeSulis);
        }

        private void setupPowerStruggle(){
            List<Region> list = new List<Region>();
            Random ran = new Random();
            while(list.Count<8){
               int select = ran.Next(0,8);
               Region tempReg = getByInd(select);
               if(!list.Contains(tempReg)){
                   list.Add(tempReg);
               }
            }
            que = list.ToArray();
            
            
        }

        private Region getByInd(int index){
            switch(index){
                case 0:
                return Caledonia;
                break;
                
                case 1: 
                return Din_Eidyn;
                break;

                case 2:
                return Eboracum;
                break;

                case 3:
                return Deva;
                break;

                case 4:
                return Ratae;
                break;

                case 5:
                return Caerleon;
                break;

                case 6:
                return Londindium;
                break;

                case 7:
                return AquaeSulis;
                break;
            }
            return null;
        }

        private void assignRanLoyalist(Region r){
            Random ran = new Random();
            while(r.getFollowerCount()>4){
                r.addLoyalist(new Follower(ran.Next(1,5)));
            }

        }

         public string getMapDesc(){
            string msg = "";
            List<Region> done = new List<Region>();
            Queue q = new Queue();
            q.Enqueue(Caledonia);
            while(q.Count>0){
                Region temp = q.Dequeue();
                msg+=temp.getDesc();
                done.Add(temp);
                foreach(Region r in neighbors){
                    if(!done.Contains(r)){
                        q.Enqueue(r);
                    }
                }

            }
            return msg;
         }

         


        

       

    }
}