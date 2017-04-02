using System;
using System.Collections;
using System.Collections.Generic;
namespace King_Is_Dead{
    
    public class Player {
    
    List<Follower> loyalist;   
    
   
    

       public Player(){
           this.done = 0;
           loyalist = new List<Follower>();
            
           crown_index1 =-1;
           crown_index2=-1;
       }

       public void resetCached(){
           crown_index1=-1;
           crown_index2=-1;
       }

       /*The Crown Information*/
       
       int crown_index1 {get; set;}
       int crown_index2 {get; set;}



       List<ActionCard> actionCards {get; set;}

       public void addFollower(Follower foll){
           loyalist.Add(foll);
       }

       ActionCard selected {get; set;}

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
            return "British Loyalist: " + brits + " , Scotish Loyalist: " + scots + " , Welsh Loyalist : " + welsh  + "\n and has " + getActionCardDes() ;

        }
       
       private string getActionCardDes(){
           
           int amb =0;
           int gar =0;
           int crown =0;
           int colony =0;
           int scots =0;
           int welsh=0;
           int brits=0;

           foreach(ActionCard c in actionCards){
               if(c.used==0){
                 switch(c.getinttype()){
                        case 0:
                        crown++;
                        break;

                        case 1:
                        gar++;
                        break;

                        case 2: 
                        amb++;  
                        break;

                        case 3:
                        colony++;
                        break;

                        case 4:
                        brits++;
                        break;

                        case 5:
                        scots++;
                        break;

                        case 6:
                        welsh++;
                        break;
            }
               } 
                   
           }

           return "The Crown: " + crown + " , Garrison: " + gar + " , Ambassador: " + amb + " , Settlements: " + colony + "British: " + brits + " , Scotish: " + scots + " , Welsh: " + welsh;
           
       }
       
       
       

       int done {get; set;}
       
    }
}