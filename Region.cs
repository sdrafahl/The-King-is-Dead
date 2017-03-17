using System.Collections;
using System.Collections.Generic;
namespace King_Is_Dead{
    
    
    
    
    
    class Region{

        /*0 none,1 is British,2 is scots,3 is welsh,4 saxons */
        int faction;
        
        string name;
    
        List<Follower> loyalist;

        List<Region> neighbors;

        public Region(string name){
            this.name=name;
            loyalist = new List<Follower>();
            neighbors = new List<Follower>();
        }
        
        List<region> neighbors {get; set;}
        int faction {get; set;}

        public addNeighbor(Region reg){
            if(neighbors.Contains(Follower)){
                return;
            }else{
                neighbors.Add(reg);
                reg.addNeighbor(this);
            }
        }

        public void addLoyalist(Follower g){
            loyalist.Add(g);
        }

        public Follower removeLoyalist(int color){
            for(int x=0;x<loyalist.Count;x++){
                Follower temp = loyalist.Remove(x);
                if(temp.faction == color){
                    return temp;
                }
                loyalist.Add(temp);
            }
        }

        public int getFollowerCount(){
            return loyalist.Count;
        }

        public bool isNeighbor(Region r){
            return neighbors.Contains(r);   
        }

        public string getDesc(){
            return name + " Is occupied by " + getFaction(faction) + " , has " + getloyalistDesc() + "\n" ;
        }

        private string getloyalistDesc(){   
            int brits =0;
            int scots =0;
            int welsh = 0;
            int loyalist = 0;
            foreach (Follower f in loyalist){
                if(f.faction==1){
                    brits++;
                }else{
                    if(f.faction==2){
                        scots++;
                    }else{
                        if(f.faction==3){
                            welsh++;
                        }else{
                            loyalist++;
                        }
                    }
                }
            }
            return "British Loyalist: " + brits + " , Scotish Loyalist: " + scots + " , Welsh Loyalist : " + welsh + " , Black Loyalist: " + loyalist; 

        }

        
         private string getFaction(int fac){
             switch(fac){
                 case 0:
                 return "none";
                 break;

                 case 1:
                 return "British";
                 break;

                 case 2:
                 return "Scots";
                 break;

                 case 3:
                 return "Welsh";
                 break;

                 case 4:
                 return "Saxons";
                 break;
             }
             return "null";
         }

    }
}