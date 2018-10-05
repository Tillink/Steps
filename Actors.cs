using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgmakerScripts.Database
{
    class Actors
    {
/*  1. 왼쪽 / 2. 가운데 / 3. 오른쪽
         
  1. Left Pannel
    1) 캐릭터 목록: ActorList
    2) 목록 나열: list 번호순 정렬
    3) 최대수 변경(캐릭터 목록 수):
        Change Maximum -> Max: (숫자) Ok, Cancel
          
  2. Center Pannel
    1) 이름            // Name
        닉네임          // Nickname
    2) 직업명          // Class  
        최소레벨        // Initial Level
        최대레벨        // Max Level
    3) 캐릭터 설명     // Description
    4) 캐릭터 그래픽   // Charactor Design
        (1) 전체이미지 (2) 캐릭터 얼굴
    5) 게임 시작 시 기초 장비 //Starting Equipment
        (1) 무기              //Weapon // 스크롤 선택
        (2) 방패              //Shield // 스크롤 선택
        (3) 투구              //Head // 스크롤 선택
        (4) 갑옷              //Body // 스크롤 선택
        (5) 장신구            //Accessory //스크롤 선택
          
  3. Right Pannel 
          
    3-1. 상태이상 // Features // Kind, Content
    1) Rate 
        (1) Element Rate   // 속성 스크롤 선택 * (0~100) %
        (2) Debuff Rate    // 스탯 스크롤 선택 * (0~100) %
        (3) State Rate     // 상태 스크롤 선택 * (0~100) %
        (4) State Resist   // 상태 스크롤 선택
          
    2) Param
        (1) Parameter     // 스탯 스크롤 선택 * (0~100) %
        (2) Ex-Parameter  // 스탯(상세수치) 스크롤 선택 * (0~100) %
        (3) Sp-Parameter  // 스탯(상세수치) 스크롤 선택 * (0~100) %
          
    3) Attack
        (1) Atk Element    // 상태 스크롤 선택
        (2) Atk State      // 상태 스크롤 선택 * (0~100) %
        (3) Atk Speed      // 수치조정 0-999
        (4) Atk Times+     // 수치조정 -9~ +9
           
    4) Skill
        (1) Add Skill Type     //스크롤 선택 (특수, 마법) 2중 택1
        (2) Seal Skill Type    //스크롤 선택 (특수, 마법) 2중 택1
        (3) Add Skill          //스크롤 선택 (특수, 마법) 다수
        (4) Seal Skill         //스크롤 선택 (특수, 마법) 다수
           
    5) Equip
        (1) Equip Weapon    // 무기 스크롤 선택
        (2) Equip Armor     // 갑옷 또는 방패 스크롤 선택
        (3) Fix Equip       // 장비의 종류 스크롤 선택
        (4) Seal Equip      // 장비의 종류 스크롤 선택
        (5) Slot Type       // 듀얼 착용 선택
          
    6) Other
        (1) Action Times+   // 수치조정 0~100 %
        (2) Special Flag    // 스크롤 선택 // 특수기능
            -> Auto Battle, Guard, Substitute, Preserve TP
        (3) Collapse Effect // 스크롤 선택 //
            -> Boss, Instant, Not Disappear
        (4) Party Ability   // 스크롤 선택
            -> Encounter Half, Encounter None, Cancel Surprise, Raise Preemptive, Gold Double, Drop Item Double
          
  3-2. Note
       -> Text Only(Read,Write)
*/
    }
}
