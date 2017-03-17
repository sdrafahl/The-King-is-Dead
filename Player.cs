using System;
using System.Collections;
using System.Collections.Generic;
namespace King_Is_Dead{
    
    public class Player {
    List<Follower> loyalist;   
    List<ActionCard> actionCards;

    int done;

       public Player(){
           this.done = 0;
           loyalist = new List<Follower>();
           actionCards = new List<ActionCard>(); 
       }

       public void addFollower(Follower foll){
           loyalist.Add(foll);
       }

       public void addActionCard(ActionCard card){
           actionCards.Add(card);
       }

       public string getCurrentPlayerDesc(){
             int brits =0;
            int scots =0;
            int welsh = 0;
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
            return "British Loyalist: " + brits + " , Scotish Loyalist: " + scots + " , Welsh Loyalist : " + welsh ;

        }
       
 

       int done {get; set;}
       
    }
}