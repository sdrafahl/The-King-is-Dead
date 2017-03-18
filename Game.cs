using System;
using System.Collections;
using System.Collections.Generic;


namespace King_Is_Dead{
    

    public class Game {
        
        int turn;
        Map map;
        List<Player> players;
        

        public Game(int numplayers){
            players = new List<Player>();
            for(int x=0;x<numplayers;x++){
                players.Add(new Player());
            }
            setupGame();
            this.map = new Map();
            this.turn = 0;
        }

        Map map {get; set;}

        public Player getPlayer(){
            return players[turn];
        }

        public Player getCurrentPlayer(){
            return players[turn];
        }

        public void playTurn(int skip){
            if(skip){
                this.turn++;
                if(this.turn==players.Count){
                    this.turn=0;
                }
            }else{
                selected.playCard();
            }

        }

        int turn {get; set;}
        
        public string getCurrentPlayerDesc(){
           return players[turn].getCurrentPlayerDesc();
        }

        private void setupGame(){
            
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
                   return new TheCrown(map);
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
    
        public string getMapDesc(){
            return map.getMapDesc();
        }
        
        
    
    }
}