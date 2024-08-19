using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodTextController : MonoBehaviour
{
    public Transform _canvas;
    Transform _oneGodOn,_theeGodOn,_oldTeam,_otherTeam, _handsomeTeam,_youngTeam, _introduce,_godOpen, _introduceText;
    public bool TC = true;
    // Start is called before the first frame update
    void Start()
    {
        _theeGodOn = _canvas.Find("顯示組");
        _oneGodOn = _canvas.Find("單一顯示組");
        _oldTeam = _theeGodOn.Find("三老王爺");
        _otherTeam = _theeGodOn.Find("三番王爺");
        _handsomeTeam = _theeGodOn.Find("三帥王爺");
        _youngTeam= _theeGodOn.Find("三少王爺");
        _introduce= _theeGodOn.Find("介紹文本");
        _introduceText = _oneGodOn.Find("單一介紹文本");
    }

    // Update is called once per frame
    void Update()
    {
        if (_oldTeam.gameObject.activeInHierarchy)
        {
            _introduce.GetComponent<Text>().text = "神尊形象較為年老，所以稱之為「三老」王爺。";

        }
        if (_otherTeam.gameObject.activeInHierarchy)
        {
            _introduce.GetComponent<Text>().text = "三位王爺皆屬中原域外的番邦人氏，所以稱之為「三番」王爺。";

        }
        if (_handsomeTeam.gameObject.activeInHierarchy)
        {
            _introduce.GetComponent<Text>().text = "在天庭之職務為軍師或執行者，所以稱之為「三帥」王爺。";

        }
        if (_youngTeam.gameObject.activeInHierarchy)
        {
            _introduce.GetComponent<Text>().text = "他們是唯三沒有鬍鬚的千歲，外貌看起來較為年輕，因而有「三少王爺」之稱。";

        }
        if (TC && _oneGodOn.gameObject.activeInHierarchy)
        {
            switch (ButtonClickHandler.ChooseGod)
            {
                case "張千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『張千歲』，為『子年』的值年歲科監科主神，是天庭玉皇大帝之軍師，同時亦是盧千歲之軍師，也是『五年千歲』中排行第“一”位的王爺。聖誕千秋日為農曆三月四日。神尊造型為粉面或黑面、黑鬍鬚、文袍身造型、頭戴文帝帽、身著米黃色或橙色龍袍。職掌為掌管食品行業，故餐飲、食品業可求之保佑。是『五年千歲』十二王爺中的『三帥王爺』之一。";
                    break;
                case "徐千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『徐千歲』，為『丑年』的值年歲科監科主神，為天庭玉皇大帝之軍師，亦是『五年千歲』中排行第“二”位的王爺，其聖誕千秋日為 農曆八月三日 。神尊造型為粉面白鬍鬚、文袍身造型、頭戴金貂相帽、身著黑色龍袍。職掌為制風水、地理，也是作官職者、民意代表圖求晉升之神明。是『五年千歲』十二王爺中的『三帥王爺』之一。";
                    break;
                case "侯千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『侯千歲』，為『寅年』的值年歲科監科主神，是『五年千歲』中排行第“三”位的王爺，也是番邦人氏的王爺，其聖誕千秋日為農曆五月五日。神尊造型為青底〈偏綠豆色〉花面紅鬍鬚、武甲身造型、頭戴三翅王帽、身著青綠色龍袍；職掌：制車關五鬼，求行車平安。是『五年千歲』十二王爺中的『三番王爺』之一。";
                    break;
                case "耿千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『耿千歲』，為『卯年』的值年歲科監科主神，是『五年千歲』中排行第“四”位的王爺，也是年輕的王爺，其聖誕千秋日為農曆五月七日。神尊造型為紅面〈偏赭色〉無鬍鬚、文袍身造型、頭戴四角金冠、身著紅色龍袍。職掌為制官司、保佑不受官司困擾，惟必須於情、理、法內方能受之眷顧。是『五年千歲』十二王爺中的『三少王爺』之一。";
                    break;
                case "吳千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『吳千歲』，為『辰年』的值年歲科監科主神，是『五年千歲』中排行第“五”位的王爺，也是位老的王爺，其聖誕千秋日為農曆三月三日。神尊造型為粉面黑鬍鬚、文武甲身造型、頭戴三翅王帽、身著金黃色龍袍。職掌為求農業豐收、畜牧興旺，是農、漁、畜牧業之守護神。是『五年千歲』十二王爺中的『三老王爺〈吳、何、趙〉』之一。";
                    break;
                case "何千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『何千歲』，為『巳年』的值年歲科監科主神，是『五年千歲』中排行第“六”位的王爺，也是位老的王爺，其聖誕千秋日為農曆八月十二日 。神尊造型為粉面黑鬍鬚、文袍身造型、頭戴文帝帽、身著米黃色或橙色龍袍。職掌為是仲介業求房屋、土地承購、銷售順利之神。是『五年千歲』十二王爺中的『三老王爺』之一。";
                    break;
                case "薛千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『薛千歲』，為『午年』的值年歲科監科主神，是『五年千歲』十二王爺中的『三少王爺』之一，亦是『五年千歲』中排行第“七”位的王爺，也是番邦人氏的王爺，其聖誕千秋日為農曆五月一日。神尊造型為粉面、無鬍鬚、文武甲身造型、頭戴二龍冠、身著金黃色龍袍。職掌為求功名利祿、學業高進。是『五年千歲』十二王爺中的『三少王爺』之一。";
                    break;
                case "封千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『封千歲』，為『未年』的值年歲科監科主神，是『五年千歲』中排行第“八”位的王爺，也是番邦人氏的王爺，其聖誕千秋日為農曆五月一日。神尊造型為黑底花面黑鬍鬚、武甲身造型、頭戴元帥帽、身著紅色龍袍。職掌為制小人、桃花、防止小人暗害，更保家庭和諧。是『五年千歲』十二王爺中的『三番王爺』之一。";
                    break;
                case "趙千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『趙千歲』，為『申年』的值年歲科監科主神，是『五年千歲』十二王爺中的『三老王爺』之一，亦是『五年千歲』中排行第“九”位的王爺，也是位老的王爺，其聖誕千秋日為農曆三月八日 。神尊造型為粉面黑鬍鬚、文武甲身造型、頭戴文帝帽、身著金黃色或橙色龍袍。職掌為保佑軍、警子弟求職平安、力求晉升之神明。 是『五年千歲』十二王爺中的『三老王爺』之一。";
                    break;
                case "譚千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『譚千歲』，為『酉年』的值年歲科監科主神，是『五年千歲』中排行第“ 十” 位的王爺，也是番邦人氏的王爺，其聖誕千秋日為農曆十二月一日 。神尊造型為紅底〈偏赭色〉花面黑鬍鬚、武甲身造型、頭戴四角金冠、身著黑色龍袍。職掌為凡消災、解厄、制煞，及經過喪家受到陰煞其擾，均可求之保佑。是『五年千歲』十二王爺中的『三番王爺』之一。";
                    break;
                case "盧千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『盧千歲』，為『戌年』的值年歲科監科主神，十二王爺中權力最大，奉旨掌管天盤，亦是『五年千歲』中排行第“十一”位的王爺。其聖誕千秋日為農曆五月十二日 。神尊造型為紅面〈偏赭色〉黑鬍鬚、文袍身造型、作『通壽』狀、頭戴文帝帽、身著米黃色龍袍。職掌為信者求醫、保身體的神明。是『五年千歲』十二王爺中的『三帥王爺』之一。";
                    break;
                case "羅千歲":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "『羅千歲』，為『亥年』的值年歲科監科主神，是『五年千歲』十二王爺中的『三少王爺』之一，亦是『五年千歲』中排行第“十二”位的王爺，也是最年輕的王爺，其聖誕千秋日為農曆正月十二日 。『羅千歲』之神尊造型，為粉面無鬍鬚、武甲身造型、頭戴二龍冠、身著紅色龍袍。職掌為是信者求經商順利、通商興旺、生意昌隆之神明。是『五年千歲』十二王爺中的『三少王爺』之一。";
                    break;
            }
            TC = false;

        }
        if (!TC && ! _oneGodOn.gameObject.activeInHierarchy)
        {
            _godOpen.gameObject.SetActive(false);
            TC = true;
        }
    }
}
