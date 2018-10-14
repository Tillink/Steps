using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgmakerScripts.Database
{
    class Actors
    {         
        // 1. 캐릭터 목록창 // make list class
        // 캐릭터 목록
        // 목록의 최대수 변경

        // 2. 캐릭터 정보창 property
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Classname { get; set; }
        public int InitialLevel { get; set; }
        public int MaxLevel { get; set; }
        public string Description { get; set; }

        // 이미지 항목 수정 전
        public List<List<Actors>> ActorImage { get; set; }
        public int ActorFace { get; set; }

        enum Equips
        {
            Weapon,
            Shield,
            Head,
            Body,
            Accessory
        }

        public override void GeneralSettings()
        {
            // 수정 전
            List<Actors> actors = new List<Actors>();
            Name = Console.ReadLine();
            Nickname = Console.ReadLine();
            Classname = List<Actors>(); // select in list
            InitialLevel = new int(1, 99);
            MaxLevel = new int(1, 99);
            Description = Console.ReadLine();

            actors.Add(); // Add actors generalsettings member
        }
        public void Graphic()
        {
            // 수정 전
            ActorImage = new List<List<Actors>>(0, 1);
            ActorFace = new int(); // get face image
        }

        /// <summary>
        /// Starting Equipment
        /// : The weapons and armor the actor has equipped at the beginning.
        /// </summary>
        /// <returns></returns>
        public List<string> StartingEquipment()
        {
            // 수정 전
            // 각 항목별 스크롤 선택있음. 
            List<string> list = new List<string>();
            foreach (var equip in Equips)
            {
                list.Add(equip);
            }
            return list;
        }

        public string ToString()
        {
            return $"Name: {Name} \tNickname: {Nickname} \n Classname: {Classname} \tInitialLevel: {InitialLevel}  MaxLevel: {MaxLevel} \n Description: {Description}";
        }

        /// <summary>
        /// Note
        /// : A memo area where you can freely add notes.
        /// </summary>
        /// <returns></returns>
        public string Note()
        {
            string getText = Console.ReadLine();
            
            return getText.ToString();
        }
    }
}
