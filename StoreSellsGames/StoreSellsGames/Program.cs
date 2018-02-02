using System;

public class Game
{
    string name;
    string genre;
    int esrRating;
    float price;
    float rating;


    public Game()
    {
        
    }

    public void BuyGame(Game gameToBuy)
    {
        //what do we need after selling the game, f.eks. delete the game from store
    }
}


public class Store
{
    string gamesAvailable;
    float price;

    public void BuyGame(Game gameToBuy)
    {
        
    }
}


public class DLC
{
    public Game game;
    float DLCprice;
    float rating;

    public void BuyDLC(DLC dlcToBuy)
    {
        
    }
}


public class Showcase
{
    
}


public class Users
{
    //man kan lave en previous bought games, to keep track off the money we are making
}