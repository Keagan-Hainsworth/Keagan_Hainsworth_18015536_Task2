﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public enum Movement
    {
        NoMovement,
        up,
        down,
        left,
        Right,
    }
    abstract class Character : Tile
    {
        protected int HP;
        protected int maxHP;
        protected int Damage;
        protected string Sym;
        protected int Y;
        protected int X;

        //private View[] = new View[];

        protected Character( ) : base()
        {
                       
        }

       

        public virtual void Attack(Character target);

        public abstract bool IsDead();

        public virtual bool CheckRange(Character target)
        {

        }

        public abstract int DistanceTo(int x, int y);        

        public abstract void Move();

        public virtual void ReturnMove(int move)
        {

        }

        public abstract override string ToString();
    }
}
