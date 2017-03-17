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
            txt.Location = new Point(500,0);
            txt.Size = new Size(500,500);
            txt.Text = game.getMapDesc();
            Controls.Add(txt);

            /*Whose Turn is displayed */
            TextBox whos = new TextBox();
            whos.Location = new Point(0,0);
            whos.Size = new Size(200,200);
            whos.Text = "It is player: " + game.turn " Turn"; 
            Controls.Add(whos);

            /*Player Followers */
            TextBox inven = new TextBox();
            inven.Location = new Point(0,250);
            inven.Size(50,50);
            inven.Text = "Player " + game.turn + " has " + game.getCurrentPlayerDesc();
            Controls.Add(inven);

            /*Controls*/
            


        }
        
        public void display(){
            Application.Run (this);
        }



    }


}