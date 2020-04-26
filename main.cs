using Godot;
using System;

public class main : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    class SomeBigClass
    {
        double a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z;
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    DateTime lastPrint = DateTime.Now;

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        for (int i=0;i<10000;++i)
        {
            var temp = new SomeBigClass();
        }

        if ((DateTime.Now - lastPrint).TotalSeconds >= 1)
        {
            Console.WriteLine($"{DateTime.Now}: MB={(int)(System.GC.GetTotalMemory(false) / 1000 / 1000)}");
            lastPrint = DateTime.Now;
        }
    }
}
