using System;
using System.Collections;
using System.Collections.Generic;
namespace King_Is_Dead{
    
    public class Player {
    List<Follower> loyalist;   
    List<ActionCard> actionCards;

       public Player(){
           loyalist = new List<Follower>();
           actionCards = new List<ActionCard>(); 
       }

       public void addFollower(Follower foll){
           loyalist.Add(foll);
       }

       public void addActionCard(ActionCard card){
           actionCards.Add(card);
       }

    }
}