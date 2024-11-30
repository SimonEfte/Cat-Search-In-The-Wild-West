using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    public void Start()
    {
        /*AchClear("ach_noHints");

        AchClear("ach_cat1");
        AchClear("ach_cat2");
        AchClear("ach_cat3");
        AchClear("ach_cat4");
        AchClear("ach_cat5");
        AchClear("ach_cat6");
        AchClear("ach_cat7");
        AchClear("ach_cat8");
        AchClear("ach_cat9");
        AchClear("ach_cat10");
        AchClear("ach_cat11");
        AchClear("ach_cat12");
        AchClear("ach_13");
        AchClear("ach_14");
        AchClear("ach_15");
        AchClear("ach_16");
        AchClear("ach_17");
        AchClear("ach_18");
        AchClear("ach_19");
        AchClear("ach_20");
        AchClear("ach_21");
        AchClear("ach_22");
        AchClear("ach_23");
        AchClear("ach_24");
        AchClear("ach_25");
        AchClear("ach_26");
        AchClear("ach_27");
        AchClear("ach_28");
        AchClear("ach_29");
        AchClear("ach_30");
        AchClear("ach_31");
        AchClear("ach_32");
        AchClear("ach_33");
        AchClear("ach_34");
        AchClear("ach_35");
        AchClear("ach_36");
        AchClear("ach_37");
        AchClear("ach_38");
        AchClear("ach_39");
        AchClear("ach_40");
        AchClear("cat_41");
        AchClear("cat_42");
        AchClear("cat_43");
        AchClear("cat_44");
        AchClear("cat_45");
        AchClear("ach_46");
        AchClear("ach_47");
        AchClear("ach_48");
        AchClear("ach_49");
        AchClear("ach_50");
        AchClear("ach_51");
        AchClear("ach_52");
        AchClear("ach_53");
        AchClear("ach_54");
        AchClear("ach_55");
        AchClear("ach_56");
        AchClear("ach_57");
        AchClear("ach_58");
        AchClear("ach_59");
        AchClear("ach_60");
        AchClear("ach_61");
        AchClear("ach_62");
        AchClear("ach_63");
        AchClear("ach_64");
        AchClear("ach_65");
        AchClear("ach_66");
        AchClear("ach_67");
        AchClear("ach_68");
        AchClear("ach_69");
        AchClear("ach_70");
        AchClear("ach_71");
        AchClear("ach_72");
        AchClear("ach_73");
        AchClear("ach_74");
        AchClear("ach_75");
        AchClear("ach_76");
        AchClear("ach_77");
        AchClear("ach_78");
        AchClear("ach_79");
        AchClear("ach_80");
        AchClear("ach_81");
        AchClear("ach_82");
        AchClear("ach_83");
        AchClear("ach_84");
        AchClear("ach_85");
        AchClear("ach_86");

        AchClear("ach_89");
        AchClear("ach_92");
        AchClear("ach_94");
        AchClear("ach_97");
        AchClear("ach_100");

        AchClear("ach_poster1");
        AchClear("ach_poster3");
        AchClear("ach_poster5");


        AchClear("ach_outlaw");
        AchClear("ach_outlaw2");
        AchClear("ach_outlaw3");
        AchClear("ach_outlaw4");
        AchClear("ach_outlaw5");*/
    }

    public void CheckAchievements()
    {
        if (ClickCats.catsFountCount == 100 && ClickCats.posterFoundCount == 5 && ClickCats.catOutlawFoundCount == 5 && ClickCats.hintsUsed == 0) { FindCats("ach_noHints"); }

        if (ClickCats.catsFountCount == 1) { FindCats("ach_cat1"); }
        if (ClickCats.catsFountCount == 2) { FindCats("ach_cat2"); }
        if (ClickCats.catsFountCount == 3) { FindCats("ach_cat3"); }
        if (ClickCats.catsFountCount == 4) { FindCats("ach_cat4"); }
        if (ClickCats.catsFountCount == 5) { FindCats("ach_cat5"); }
        if (ClickCats.catsFountCount == 6) { FindCats("ach_cat6"); }
        if (ClickCats.catsFountCount == 7) { FindCats("ach_cat7"); }
        if (ClickCats.catsFountCount == 8) { FindCats("ach_cat8"); }
        if (ClickCats.catsFountCount == 9) { FindCats("ach_cat9"); }
        if (ClickCats.catsFountCount == 10) { FindCats("ach_cat10"); }
        if (ClickCats.catsFountCount == 11) { FindCats("ach_cat11"); }
        if (ClickCats.catsFountCount == 12) { FindCats("ach_cat12"); }
        if (ClickCats.catsFountCount == 13) { FindCats("ach_13"); }
        if (ClickCats.catsFountCount == 14) { FindCats("ach_14"); }
        if (ClickCats.catsFountCount == 15) { FindCats("ach_15"); }
        if (ClickCats.catsFountCount == 16) { FindCats("ach_16"); }
        if (ClickCats.catsFountCount == 17) { FindCats("ach_17"); }
        if (ClickCats.catsFountCount == 18) { FindCats("ach_18"); }
        if (ClickCats.catsFountCount == 19) { FindCats("ach_19"); }
        if (ClickCats.catsFountCount == 20) { FindCats("ach_20"); }
        if (ClickCats.catsFountCount == 21) { FindCats("ach_21"); }
        if (ClickCats.catsFountCount == 22) { FindCats("ach_22"); }
        if (ClickCats.catsFountCount == 23) { FindCats("ach_23"); }
        if (ClickCats.catsFountCount == 24) { FindCats("ach_24"); }
        if (ClickCats.catsFountCount == 25) { FindCats("ach_25"); }
        if (ClickCats.catsFountCount == 26) { FindCats("ach_26"); }
        if (ClickCats.catsFountCount == 27) { FindCats("ach_27"); }
        if (ClickCats.catsFountCount == 28) { FindCats("ach_28"); }
        if (ClickCats.catsFountCount == 29) { FindCats("ach_29"); }
        if (ClickCats.catsFountCount == 30) { FindCats("ach_30"); }
        if (ClickCats.catsFountCount == 31) { FindCats("ach_31"); }
        if (ClickCats.catsFountCount == 32) { FindCats("ach_32"); }
        if (ClickCats.catsFountCount == 33) { FindCats("ach_33"); }
        if (ClickCats.catsFountCount == 34) { FindCats("ach_34"); }
        if (ClickCats.catsFountCount == 35) { FindCats("ach_35"); }
        if (ClickCats.catsFountCount == 36) { FindCats("ach_36"); }
        if (ClickCats.catsFountCount == 37) { FindCats("ach_37"); }
        if (ClickCats.catsFountCount == 38) { FindCats("ach_38"); }
        if (ClickCats.catsFountCount == 39) { FindCats("ach_39"); }
        if (ClickCats.catsFountCount == 40) { FindCats("ach_40"); }
        if (ClickCats.catsFountCount == 41) { FindCats("cat_41"); }
        if (ClickCats.catsFountCount == 42) { FindCats("cat_42"); }
        if (ClickCats.catsFountCount == 43) { FindCats("cat_43"); }
        if (ClickCats.catsFountCount == 44) { FindCats("cat_44"); }
        if (ClickCats.catsFountCount == 45) { FindCats("cat_45"); }
        if (ClickCats.catsFountCount == 46) { FindCats("ach_46"); }
        if (ClickCats.catsFountCount == 47) { FindCats("ach_47"); }
        if (ClickCats.catsFountCount == 48) { FindCats("ach_48"); }
        if (ClickCats.catsFountCount == 49) { FindCats("ach_49"); }
        if (ClickCats.catsFountCount == 50) { FindCats("ach_50"); }
        if (ClickCats.catsFountCount == 51) { FindCats("ach_51"); }
        if (ClickCats.catsFountCount == 52) { FindCats("ach_52"); }
        if (ClickCats.catsFountCount == 53) { FindCats("ach_53"); }
        if (ClickCats.catsFountCount == 54) { FindCats("ach_54"); }
        if (ClickCats.catsFountCount == 55) { FindCats("ach_55"); }
        if (ClickCats.catsFountCount == 56) { FindCats("ach_56"); }
        if (ClickCats.catsFountCount == 57) { FindCats("ach_57"); }
        if (ClickCats.catsFountCount == 58) { FindCats("ach_58"); }
        if (ClickCats.catsFountCount == 59) { FindCats("ach_59"); }
        if (ClickCats.catsFountCount == 60) { FindCats("ach_60"); }
        if (ClickCats.catsFountCount == 61) { FindCats("ach_61"); }
        if (ClickCats.catsFountCount == 62) { FindCats("ach_62"); }
        if (ClickCats.catsFountCount == 63) { FindCats("ach_63"); }
        if (ClickCats.catsFountCount == 64) { FindCats("ach_64"); }
        if (ClickCats.catsFountCount == 65) { FindCats("ach_65"); }
        if (ClickCats.catsFountCount == 66) { FindCats("ach_66"); }
        if (ClickCats.catsFountCount == 67) { FindCats("ach_67"); }
        if (ClickCats.catsFountCount == 68) { FindCats("ach_68"); }
        if (ClickCats.catsFountCount == 69) { FindCats("ach_69"); }
        if (ClickCats.catsFountCount == 70) { FindCats("ach_70"); }
        if (ClickCats.catsFountCount == 71) { FindCats("ach_71"); }
        if (ClickCats.catsFountCount == 72) { FindCats("ach_72"); }
        if (ClickCats.catsFountCount == 73) { FindCats("ach_73"); }
        if (ClickCats.catsFountCount == 74) { FindCats("ach_74"); }
        if (ClickCats.catsFountCount == 75) { FindCats("ach_75"); }
        if (ClickCats.catsFountCount == 76) { FindCats("ach_76"); }
        if (ClickCats.catsFountCount == 77) { FindCats("ach_77"); }
        if (ClickCats.catsFountCount == 78) { FindCats("ach_78"); }
        if (ClickCats.catsFountCount == 79) { FindCats("ach_79"); }
        if (ClickCats.catsFountCount == 80) { FindCats("ach_80"); }
        if (ClickCats.catsFountCount == 81) { FindCats("ach_81"); }
        if (ClickCats.catsFountCount == 82) { FindCats("ach_82"); }
        if (ClickCats.catsFountCount == 83) { FindCats("ach_83"); }
        if (ClickCats.catsFountCount == 84) { FindCats("ach_84"); }
        if (ClickCats.catsFountCount == 85) { FindCats("ach_85"); }
        if (ClickCats.catsFountCount == 86) { FindCats("ach_86"); }

        if (ClickCats.catsFountCount == 89) { FindCats("ach_89"); }
        if (ClickCats.catsFountCount == 92) { FindCats("ach_92"); }
        if (ClickCats.catsFountCount == 94) { FindCats("ach_94"); }
        if (ClickCats.catsFountCount == 97) { FindCats("ach_97"); }
        if (ClickCats.catsFountCount == 100) { FindCats("ach_100"); }

        if(ClickCats.posterFoundCount == 1) { FindCats("ach_poster1"); }
        if (ClickCats.posterFoundCount == 3) { FindCats("ach_poster3"); }
        if (ClickCats.posterFoundCount == 5) { FindCats("ach_poster5"); }
      

        if (ClickCats.catOutlawFoundCount == 1) { FindCats("ach_outlaw"); }
        if (ClickCats.catOutlawFoundCount == 2) { FindCats("ach_outlaw2"); }
        if (ClickCats.catOutlawFoundCount == 3) { FindCats("ach_outlaw3"); }
        if (ClickCats.catOutlawFoundCount == 4) { FindCats("ach_outlaw4"); }
        if (ClickCats.catOutlawFoundCount == 5) { FindCats("ach_outlaw5"); }
    }

    public void FindCats(string achID)
    {
        var ach = new Steamworks.Data.Achievement(achID);
        if (ach.State == false) { ach.Trigger(); }
    }

    public void AchClear(string achID)
    {
        var ach = new Steamworks.Data.Achievement(achID);
        ach.Clear();
    }
}
