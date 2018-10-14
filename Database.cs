using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgmakerScripts
{
    class Database
    {
        // Left Pannel
        // top    :  ClassesList      // TextBox : Class name
        // middle :  ListSort         // Show : All member in list
        // bottom :  ListModifyNumber // Button : Change Maximum
        protected void FirstPannel(Database dblist)
        {
            // class name
            dblist.ToString();

            //dblist sort
            List<Database> list = dblist;
            list.Sort();

            // Change Maximum Button
            // 1. max : number (scroll)
            // 2. OK, Cancel (IsSave)

            int max; // min :1- max: 999
            bool IsSave = false;
            // if push button ok, return save; else return;
        }
        public string Name { get; private set; }
        public string Description { get; private set; }
        /// <summary>
        /// General Settings
        /// Basic settings
        /// </summary>
        protected virtual void GeneralSettings()
        {
            Name = Console.ReadLine();
            Description = Console.ReadLine();
        }
        // Center Pannel
        // top : General Settings
        //          :Actors, Classes, Skills, Items, Weapons, Armors, Enemies, Troops, States, Animations, Tilesets, CommonEvents

        // 3. 상태 정보, 메모창
        // use override method
        /// <summary>
        /// 
        /// </summary>
        public virtual Features()
        {
            //      Kind, Content
            //ex)   State Rate,
            //       [some State] * [rate]%
        }
        // Right Pannel
        //top    :  Features
        //bottom :  Note
    }
}
