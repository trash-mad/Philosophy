using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philosophy
{
    public abstract class Item
    {
        protected Item() { }
        public string Title { get; set; }
        public string Type { get; set; }
    }

    public class ImageItem : Item
    {
        public ImageItem() { }
        public string Image { get; set; }
    }

    public class MapItem : Item
    {
        public MapItem() { }
        public string ExeName { get; set; }
    }

    public static class Model
    {
        public static Item[] DefaultItem =
        {
new MapItem(){Title="Карта \"Античные философы\"",ExeName="Map.exe",Type="Интерактивная карта"},
new ImageItem(){Title="ОБЩИЕ ПОНЯТИЯ МИРОВОЗЗРЕНИЯ И ЕГО ОСНОВНЫЕ ВИДЫ",Image="1.png",Type="Схема"},
new ImageItem(){Title="МИФОЛОГИЯ КАК МИРОВОЗЗРЕНИЕ",Image="2.png",Type="Схема"},
new ImageItem(){Title="РЕЛИГИЯ КАК МИРОВОЗЗРЕНИЕ",Image="3.png",Type="Схема"},
new ImageItem(){Title="ФИЛОСОФИЯ КАК МИРОВОЗЗРЕНИЕ",Image="4.png",Type="Схема"},
new ImageItem(){Title="СТРУКТУРА ФИЛОСОФИИ",Image="5.png",Type="Схема"},
new ImageItem(){Title="СОДЕРЖАНИЕ ПРЕДМЕТА ФИЛОСОФИИ",Image="6.png",Type="Схема"},
new ImageItem(){Title="ФУНКЦИИ ФИЛОСОФИИ",Image="7.png",Type="Схема"},
new ImageItem(){Title="ИСТОРИЧЕСКИЕ ТИПЫ ФИЛОСОФИИ",Image="8.png",Type="Схема"},
new ImageItem(){Title="ОСНОВНЫЕ ЭТАПЫ И ХАРАКТЕРНЫЕ ЧЕРТЫ КИТАЙСКОЙ ФИЛОСОФИИ",Image="9.png",Type="Схема"},
new ImageItem(){Title="ДАОСИЗМ – ДРЕВНЕЙШЕЕ ФИЛОСОФСКОЕ УЧЕНИЕ КИТАЯ",Image="10.png",Type="Схема"},
new ImageItem(){Title="ПЕРИОДИЗАЦИЯ ДРЕВНЕИНДИЙСКОЙ ФИЛОСОФИИ",Image="11.png",Type="Схема"},
new ImageItem(){Title="ОНТОЛОГИЯ ДРЕВНЕИНДИЙСКОЙ ФИЛОСОФИИ",Image="12.png",Type="Схема"},
new ImageItem(){Title="ГНОСЕОЛОГИЯ ДРЕВНЕИНДИЙСКОЙ ФИЛОСОФИИ",Image="13.png",Type="Схема"},
new ImageItem(){Title="ОБЩЕЕ ПОНЯТИЕ И ПЕРИОДИЗАЦИЯ ДРЕВНЕГРЕЧЕСКОЙ ФИЛОСОФИИ",Image="14.png",Type="Схема"},
new ImageItem(){Title="ОБЩЕЕ ПОНЯТИЕ ДОСОКРАТИЧЕСКИХ ФИЛОСОФСКИХ ШКОЛ",Image="15.png",Type="Схема"},
new ImageItem(){Title="ФИЛОСОФИЯ СОКРАТА",Image="16.png",Type="Схема"},
new ImageItem(){Title="ОБЩАЯ ХАРАКТЕРИСТИКА ЛИЧНОСТИ И ТВОРЧЕСТВА ПЛАТОНА",Image="17.png",Type="Схема"},
new ImageItem(){Title="ОБЩИЕ ПОЛОЖЕНИЯ ФИЛОСОФИИ АРИСТОТЕЛЯ",Image="18.png",Type="Схема"},
new ImageItem(){Title="ПРОБЛЕМЫ МАТЕРИИ, ДУШИ И ЧЕЛОВЕКА В ФИЛОСОФИИ АРИСТОТЕЛЯ",Image="19.png",Type="Схема"},
new ImageItem(){Title="ОБЩЕЕ ПОНЯТИЕ И ОСНОВНЫЕ ЧЕРТЫ СРЕДНЕВЕКОВОЙ ТЕОЛОГИЧЕСКОЙ ФИЛОСОФИИ",Image="20.png",Type="Схема"},
new ImageItem(){Title="ОБЩИЕ ПОНЯТИЯ СХОЛАСТИКИ, НОМИНАЛИЗМА И РЕАЛИЗМА",Image="21.png",Type="Схема"},
new ImageItem(){Title="ФИЛОСОФИЯ ФОМЫ АКВИНСКОГО (ТОМИЗМ)",Image="22.png",Type="Схема"},
new ImageItem(){Title="ОБЩЕЕ ПОНЯТИЕ И ПРЕДПОСЫЛКИ ФИЛОСОФИИ ЭПОХИ ВОЗРОЖДЕНИЯ",Image="23.png",Type="Схема"},
new ImageItem(){Title="ОСНОВНЫЕ НАПРАВЛЕНИЯ И ХАРАКТЕРНЫЕ ЧЕРТЫ ФИЛОСОФИИ ЭПОХИ ВОЗРОЖДЕНИЯ",Image="24.png",Type="Схема"},
new ImageItem(){Title="ГУМАНИЗМ",Image="25.png",Type="Схема"},
new ImageItem(){Title="НАТУРФИЛОСОФИЯ",Image="26.png",Type="Схема"},
new ImageItem(){Title="ПРЕДПОСЫЛКИ И ОБЩАЯ ХАРАКТЕРИСТИКА АНГЛИЙСКОЙ ФИЛОСОФИИ НОВОГО ВРЕМЕНИ",Image="27.png",Type="Схема"},
new ImageItem(){Title="ПРОБЛЕМА ПОЗНАНИЯ В ФИЛОСОФИИ Ф. БЭКОНА",Image="28.png",Type="Схема"},
new ImageItem(){Title="ЗНАЧЕНИЕ ФИЛОСОФИИ ДЕКАРТА",Image="29.png",Type="Схема"},
new ImageItem(){Title="ФИЛОСОФИЯ Т. ГОББСА",Image="30.png",Type="Схема"},
new ImageItem(){Title="ФИЛОСОФИЯ ДЖ. ЛОККА. TABULA RASA. РАЗДЕЛЕНИЕ ВЛАСТЕЙ",Image="31.png",Type="Схема"},
new ImageItem(){Title="ФИЛОСОФИЯ ДЭВИДА ЮМА",Image="32.png",Type="Схема"},
new ImageItem(){Title="НЕМЕЦКАЯ КЛАССИЧЕСКАЯ ФИЛОСОФИЯ",Image="33.png",Type="Схема"},
new ImageItem(){Title="ИСТОРИЧЕСКОЕ ЗНАЧЕНИЕ ФИЛОСОФИИ КАНТА",Image="34.png",Type="Схема"},
new ImageItem(){Title="ДИАЛЕКТИКА ГЕГЕЛЯ",Image="35.png",Type="Схема"},
new ImageItem(){Title="КРИТИКА ФЕЙЕРБАХОМ ГЕГЕЛЕВСКОЙ ФИЛОСОФИИ",Image="36.png",Type="Схема"},
new ImageItem(){Title="ОБЩЕЕ ПОНЯТИЕ МАРКСИСТСКОЙ ФИЛОСОФИИ",Image="37.png",Type="Схема"},
new ImageItem(){Title="ФИЛОСОФИЯ ПОЗИТИВИЗМА ОГЮСТА КОНТА",Image="38.png",Type="Схема"},
new ImageItem(){Title="ИРРАЦИОНАЛИЗМ, «ФИЛОСОФИЯ ЖИЗНИ»",Image="39.png",Type="Схема"},
new ImageItem(){Title="«ФИЛОСОФИЯ ЖИЗНИ» ФРИДРИХА НИЦШЕ",Image="40.png",Type="Схема"},
new ImageItem(){Title="ОБЩЕЕ ПОНЯТИЕ ПСИХОАНАЛИЗА",Image="41.png",Type="Схема"},
new ImageItem(){Title="ОБЩЕЕ ПОНЯТИЕ И ОСНОВНЫЕ ПРОБЛЕМЫ НЕОПОЗИТИВИЗМА",Image="42.png",Type="Схема"},
new ImageItem(){Title="ОБЩИЕ ПОНЯТИЯ. ОСНОВНЫЕ ПРОБЛЕМЫ, РАССМАТРИВАЕМЫЕ ЭКЗИ-СТЕНЦИАЛИЗМОМ",Image="43.png",Type="Схема"},
new ImageItem(){Title="ОБЩЕЕ ПОНЯТИЕ И ХАРАКТЕРНЫЕ ЧЕРТЫ РУССКОЙ ФИЛОСОФИИ",Image="44.png",Type="Схема"},
new ImageItem(){Title="РАННЯЯ РУССКАЯ ФИЛОСОФИЯ (ПЕРИОД ЕЕ ЗАРОЖДЕНИЯ И РАННЕГО ХРИСТИАНСТВА)",Image="45.png",Type="Схема"},
new ImageItem(){Title="ОСНОВНЫЕ НАПРАВЛЕНИЯ РУССКОЙ ФИЛОСОФИИ XIX И XX ВВ.",Image="46.png",Type="Схема"},
new ImageItem(){Title="ФИЛОСОФИЯ ЗАПАДНИКОВ И СЛАВЯНОФИЛОВ",Image="47.png",Type="Схема"},
new ImageItem(){Title="ЛИБЕРАЛЬНАЯ ФИЛОСОФИЯ",Image="48.png",Type="Схема"},
new ImageItem(){Title="ОСНОВНЫЕ НАПРАВЛЕНИЯ РУССКОЙ ФИЛОСОФИИ КОНЦА XIX – XX ВВ.",Image="49.png",Type="Схема"},
new ImageItem(){Title="СОВЕТСКАЯ ФИЛОСОФИЯ",Image="50.png",Type="Схема"},
new ImageItem(){Title="ОСНОВНЫЕ ФОРМЫ БЫТИЯ",Image="51.png",Type="Схема"},
new ImageItem(){Title="СТРУКТУРНЫЕ УРОВНИ РАЗВИТИЯ МАТЕРИИ",Image="52.png",Type="Схема"},
new ImageItem(){Title="ФОРМЫ ДВИЖЕНИЯ МАТЕРИИ",Image="53.png",Type="Схема"},
new ImageItem(){Title="СОЗНАНИЕ И ЕГО СТРУКТУРА",Image="54.png",Type="Схема"},
new ImageItem(){Title="ОСНОВНЫЕ ПОДХОДЫ К ПРОБЛЕМЕ СОЗНАНИЯ В ФИЛОСОФИИ",Image="55.png",Type="Схема"},
new ImageItem(){Title="ТЕОРИЯ ОТРАЖЕНИЯ",Image="56.png",Type="Схема"},
new ImageItem(){Title="КОНЦЕПЦИЯ СМЫСЛА ЖИЗНИ",Image="57.png",Type="Схема"},
new ImageItem(){Title="ОСНОВНЫЕ СФЕРЫ ОБЩЕСТВЕННОГО БЫТИЯ И ГЛАВНЫЕ СФЕРЫ ЖИЗНИ ОБЩЕСТВА",Image="58.png",Type="Схема"},
new ImageItem(){Title="МЕРЫ ПО ПРЕДОТВРАЩЕНИЮ ТЕХНОГЕННОЙ КАТАСТРОФЫ",Image="59.png",Type="Схема"},
new ImageItem(){Title="СТРУКТУРА ПОЗНАВАТЕЛЬНОГО ПРОЦЕССА",Image="60.png",Type="Схема"},
new ImageItem(){Title="МЕТОДЫ И ФОРМЫ НАУЧНОГО ПОЗНАНИЯ",Image="61.png",Type="Схема"},
new ImageItem(){Title="ВИДЫ ЯЗЫКА",Image="62.png",Type="Схема"},
new ImageItem(){Title="СХЕМА ВЗАИМОДЕЙСТВИЯ КУЛЬТУР",Image="63.png",Type="Схема"},
new ImageItem(){Title="ПРОГНОСТИЧЕСКАЯ ФУНКЦИЯ ФИЛОСОФИИ. ВОЗМОЖНОСТЬ ПРОДВИЖЕНИЯ БУДУЩЕГО И ЕЕ ОСНОВНЫЕ ПРОБЛЕМЫ",Image="64.png",Type="Схема"}
        };
    }
}
