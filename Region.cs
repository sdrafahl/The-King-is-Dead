using System.Collections;
using System.Collections.Generic;
namespace King_Is_Dead{
    
    string name;
    
    List<Follower> loyalist;

    List<Region> neighbors;
    
    /*0 none,1 is British,2 is scots,3 is welsh,4 loyalist */
    int faction;
    
    class Region{

        public Region(string name){
            this.name=name;
            loyalist = new List<Follower>();
            neighbors = new List<Follower>();
        }
        
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
        

    }
}