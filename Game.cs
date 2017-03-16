using System;
using System.Collections;
using System.Collections.Generic;


namespace King_Is_Dead{
    

    public class Game {

        List<Player> players;

        public Game(){

        }


        public void setPlayers(List<Player> players){
            this.players=players;
        }

        public void setupGame(){
            
            for(int x=0;x<players.Count;x++){
                Player p = players.ElementAt(x);
                setupLoyalist(p);
                setupCards(p);
                
            }
        }

        private void setupLoyalist(Player play){
            Random ran = new Random();
            int select1 = ran.Next(0,3);
            int select2 = ran.Next(0,3);
            switch(select1){
                case 0:
                    play.addFollower(new addFollower(1));
                break;
                
                case 1:
                    play.addFollower(new addFollower(2));
                break;

                case 2:
                    play.addFollower(new addFollower(3));
                break;
            }
            switch(select2){
                case 0:
                    play.addFollower(new addFollower(1));
                break;
                
                case 1:
                    play.addFollower(new addFollower(2));
                break;

                case 2:
                    play.addFollower(new addFollower(3));
                break;
            }
        }
    
        private void setupCards(Player play){
            
            for(int x=0;x<8;x++){
                play.addActionCard(getActionCard());
            }
        }

        private ActionCard getActionCard(){
            Random ran = new Random();
            switch(ran.Next(0,5)){
                
                case 0:
                   return new TheCrown();
                break;

                case 1: 
                    return new Settlements();
                break;

                case 2: 
                    return new Garrison();
                break;

                case 3: 
                    return new AmbassadorCard();
                break;

                case 4: 
                    int fac = ran.Next(0,3);
                    switch(fac){
                        case 0:
                            return new Inforce(1);
                        break;

                        case 1: 
                            return new Inforce(2);
                        break;

                        case 2:
                            return new Inforce(3);
                        break;
                    }
                break;
                    
            }
            return null;
        }
    
    
    }
}