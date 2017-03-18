using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace King_Is_Dead{
    

    public class HomeLocal : Form {
        
        Game game;

        public HomeLocal(){
            
        }

        public HomeLocal (){
            Label b = new Label ();
            b.Text = "Select Number of Players";
            b.Location = new Point(100,0);
            b.Size = new Size(100, 100);
            Size = new Size(800, 800);
            Controls.Add (b);
            Button button1 = new Button();
            button1.Text = "2 Players";
            button1.Click += new EventHandler (twoplayer);
            b.Parent = this;
            button1.Parent = this;
            Button button2 = new Button();
            button2.Text = "3 Players";
            button2.Click += new EventHandler (threeplayer); 
            button2.Location = new Point(40, 20);
            Controls.Add(button2);
            Button button3 = new Button();
            button3.Text = "4 Players";
            button3.Click += new EventHandler (fourplayer);
            Controls.Add(button3);
            Text = "The King Is Dead";
            AutoSize = true;
            CenterToScreen();
        }

        public void display(){
            Application.Run (this);
        }

        private void twoplayer (object sender, EventArgs e){
            List<Player> players = new List<Player>();
            this.game = new Game(2);
            Close();
            new GameScreen(game).display();
            
        }

        private void threeplayer(object sender, EventArgs e){
            List<Player> players = new List<Player>();
            this.game = new Game(3);
            
            Close();
            new GameScreen(game).display();
        }

        private void fourplayer(object sender, EventArgs e){
            List<Player> players = new List<Player>();
            this.game = new Game(4);
            Close();
            new GameScreen(game).display();
        }
    
    }

    public class HomeScreen : Form {

        Game game;

        public HomeScreen(){
            Console.Write("Does Nothing");
        }

        public HomeScreen (Game g){
            this.game=g;
            Label b = new Label ();
            b.Text = "Local";
            b.Location = new Point(500,0);
            b.Size = new Size(50, 100);
            Size = new Size(800, 800);
            Controls.Add (b);
            Button local = new Button();
            local.Location = new Point(0,30);
            local.Text="Local";
            local.Size = new Size(50,50);
            local.Click += new EventHandler (localGame);
            Controls.Add(local);

        }
        
        private void localGame(object sender, EventArgs e){
            Close();
            new HomeLocal(game).display();
        }

        public void display(){
            Application.Run (this);
        }



    }

    /**
     *   Class for UI for playing the game locally 
     */
     public class GameScreen : Form {

        Game game;

        public GameScreen(){
            Console.Write("Does Nothing");
        }

        public GameScreen (Game g){
            this.game=g;
            Size = new Size(1000,1000);

            /*Temporary untill graphics are complete */
            TextBox txt = new TextBox();
            txt.Location = new Point(0,500);
            txt.Size = new Size(500,500);
            txt.Text = game.getMapDesc();
            Controls.Add(txt);

            /*Whose Turn is displayed */
            TextBox whos = new TextBox();
            whos.Location = new Point(0,0);
            whos.Size = new Size(75,75);
            whos.Text = "It is player: " + game.turn " Turn"; 
            Controls.Add(whos);

            /*Player Followers */
            TextBox inven = new TextBox();
            inven.Location = new Point(0,250);
            inven.Size = new Size(50,50);
            inven.Text = "Player " + game.turn + " has " + game.getCurrentPlayerDesc() ;
            Controls.Add(inven);

            /*Controls*/
            
            /*Skip Button*/
            int y = 250;
            Button skip = new Button();
            skip.Location = new Point(y,1);
            skip.Size = new Size(50,50);
            skip.Text = "Skip";
            skip.Click += new EventHandler(skipMethod);
            Controls.Add(skip);

            int crown = 0;
            TheCrown cro;
            int garrison =0;
            Garrison gar;
            int ambassador =0;
            AmbassadorCard amb;
            int settlements =0;
            Settlements set;
            int brits=0;
            Inforce bri;
            int scots=0;
            Inforce sco;
            int welsh=0;
            Inforce we;
            
            foreach(ActionCard r in g.getPlayer().actionCards){
                if(r.used==0){
                    switch(r.getinttype()){
                        case 0:
                        crown=1;
                        cro = r;
                        break;

                        case 1:
                        garrison=1;
                        gar = r;
                        break;

                        case 2:
                        ambassador=1;
                        amb = r;
                        break;

                        case 3:
                        set=r;
                        settlements =1;
                        break;

                        case 4:
                        bri=r;
                        brits=1;
                        break;

                        case 5:
                        sco=r;
                        scots=1;
                        break;

                        case 6:
                        we=r;
                        welsh=1;
                        break;
                    }
                }
                
            }

            if(crown){
                y+=55;
                Button btcrown = new Crown(game.map);
                btcrown.Location = new Point(y,1);
                btcrown.Size = new Size(50,50);
                btcrown.Text = "The Crown";
                btcrown.Click += new EventHandler(selectCrown);
                Controls.Add(btcrown);
            }

            if(garrison){
                y+=55;
                Button btcrown = new Crown(game.map);
                btcrown.Location = new Point(y,1);
                btcrown.Size = new Size(50,50);
                btcrown.Text = "Garrison";
                btcrown.Click += new EventHandler(selectGarrison);
                Controls.Add(btcrown);
            }

            if(ambassador){
                y+=55;
                Button btcrown = new Crown(game.map);
                btcrown.Location = new Point(y,1);
                btcrown.Size = new Size(50,50);
                btcrown.Text = "Ambassador";
                btcrown.Click += new EventHandler(selectAmbassador);
                Controls.Add(btcrown);
            }

            if(settlements){
                y+=55;
                Button btcrown = new Crown(game.map);
                btcrown.Location = new Point(y,1);
                btcrown.Size = new Size(50,50);
                btcrown.Text = "Ambassador";
                btcrown.Click += new EventHandler(selectSettlements);
                Controls.Add(btcrown);
            }

            if(brits){
                y+=55;
                Button btcrown = new Crown(game.map);
                btcrown.Location = new Point(y,1);
                btcrown.Size = new Size(50,50);
                btcrown.Text = "Ambassador";
                btcrown.Click += new EventHandler(selectBritish);
                Controls.Add(btcrown);
            }

            if(scots){
                y+=55;
                Button btcrown = new Crown(game.map);
                btcrown.Location = new Point(y,1);
                btcrown.Size = new Size(50,50);
                btcrown.Text = "Ambassador";
                btcrown.Click += new EventHandler(selectScots);
                Controls.Add(btcrown);
            }

            if(welsh){
                y+=55;
                Button btcrown = new Crown(game.map);
                btcrown.Location = new Point(y,1);
                btcrown.Size = new Size(50,50);
                btcrown.Text = "Ambassador";
                btcrown.Click += new EventHandler(selectWelsh);
                Controls.Add(btcrown);
            }




        }
        private void selectWelsh(){
            Player p = game.getCurrentPlayer();
            p.selected = we;
        }

        private void selectScots(){
            Player p = game.getCurrentPlayer();
            p.selected = sco;
        }

        private void selectBritish(){
            Player p = game.getCurrentPlayer();
            p.selected = bri;
        }

        private void selectSettlements(){
            Player p = game.getCurrentPlayer();
             p.selected = set;
        }

        private void selectAmbassador(){
             Player p = game.getCurrentPlayer();
             p.selected = amb;
        }

        private void selectGarrison(){
            Player p = game.getCurrentPlayer();
             p.selected = gar;
        }

        private void selectCrown(){
           Player p = game.getCurrentPlayer();
           p.selected = cro;
        }

        private void skipMethod(){
            game.playTurn(1 , null);
        }        

        public void display(){
            Application.Run (this);
        }



    }


}