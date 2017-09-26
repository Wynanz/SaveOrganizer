﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveOrganizer
{
    class FuncLocs
    {
        public static Dictionary<string, int> LuaFunctions()
        {
            Dictionary<int, string> LuaFunctionsBackward = new Dictionary<int, string>();
            LuaFunctionsBackward.Add(14030544, "actionend");
            LuaFunctionsBackward.Add(14023712, "addactioncount");
            LuaFunctionsBackward.Add(14017664, "addblockclearbonus");
            LuaFunctionsBackward.Add(14019616, "addclearcount");
            LuaFunctionsBackward.Add(14027056, "addcorpseevent");
            LuaFunctionsBackward.Add(14024912, "addcurrentvowrankpoint");
            LuaFunctionsBackward.Add(14042560, "addcustomroutepoint");
            LuaFunctionsBackward.Add(14016032, "adddeathcount");
            LuaFunctionsBackward.Add(14028016, "addeventparts_ignore");
            LuaFunctionsBackward.Add(14035040, "addeventsimpletalk");
            LuaFunctionsBackward.Add(14034976, "addeventsimpletalktimer");
            LuaFunctionsBackward.Add(14034832, "addfieldinsfilter");
            LuaFunctionsBackward.Add(14033584, "addgeneevent");
            LuaFunctionsBackward.Add(14015312, "addhelpwhiteghost");
            LuaFunctionsBackward.Add(14044496, "addhitmaskbybit");
            LuaFunctionsBackward.Add(14042912, "addinfomationbuffer");
            LuaFunctionsBackward.Add(14042928, "addinfomationbuffertag");
            LuaFunctionsBackward.Add(14033776, "addinfomationlist");
            LuaFunctionsBackward.Add(14042864, "addinfomationtimemsgtag");
            LuaFunctionsBackward.Add(14042832, "addinfomationtosbuffer");
            LuaFunctionsBackward.Add(14042800, "addinfomationtosbufferplus");
            LuaFunctionsBackward.Add(14050496, "addinventoryitem");
            LuaFunctionsBackward.Add(14015280, "addkillblackghost");
            LuaFunctionsBackward.Add(14022672, "addqwc");
            LuaFunctionsBackward.Add(14021552, "addtreasureevent");
            LuaFunctionsBackward.Add(14015984, "addtruedeathcount");
            LuaFunctionsBackward.Add(14023920, "beginaction");
            LuaFunctionsBackward.Add(14023568, "beginloopcheck");
            LuaFunctionsBackward.Add(14023424, "camreset");
            LuaFunctionsBackward.Add(14049200, "castpointspell");
            LuaFunctionsBackward.Add(14048912, "casttargetspell");
            LuaFunctionsBackward.Add(14048848, "casttargetspellplus");
            LuaFunctionsBackward.Add(14028144, "changeinitposang");
            LuaFunctionsBackward.Add(14050256, "changegreyghost");
            LuaFunctionsBackward.Add(14044272, "changemodel");
            LuaFunctionsBackward.Add(14032288, "changetarget");
            LuaFunctionsBackward.Add(14047392, "changethink");
            LuaFunctionsBackward.Add(14028800, "changewander");
            LuaFunctionsBackward.Add(14026848, "characterallattachsys");
            LuaFunctionsBackward.Add(14041488, "charactorcopyposang");
            LuaFunctionsBackward.Add(14019680, "checkeventbody");
            LuaFunctionsBackward.Add(14020176, "checkpenalty");
            LuaFunctionsBackward.Add(14029920, "chrdisableupdate");
            LuaFunctionsBackward.Add(14026720, "chrfadein");
            LuaFunctionsBackward.Add(14026608, "chrfadeout");
            LuaFunctionsBackward.Add(14026352, "chrresetanimation");
            LuaFunctionsBackward.Add(14026400, "chrresetrequest");
            LuaFunctionsBackward.Add(14015872, "clearbossgauge");
            LuaFunctionsBackward.Add(14020048, "clearmyworldstate");
            LuaFunctionsBackward.Add(14020304, "clearsossign");
            LuaFunctionsBackward.Add(14029760, "cleartarget");
            LuaFunctionsBackward.Add(14017792, "closegendialog");
            LuaFunctionsBackward.Add(14019840, "closemenu");
            LuaFunctionsBackward.Add(14014800, "closerankingdialog");
            LuaFunctionsBackward.Add(14018064, "closetalk");
            LuaFunctionsBackward.Add(14049440, "completeevent");
            LuaFunctionsBackward.Add(14033072, "createcamsfx");
            LuaFunctionsBackward.Add(14034496, "createherobloodstain");
            LuaFunctionsBackward.Add(14020608, "createsfx");
            LuaFunctionsBackward.Add(14041408, "createsfx_dummypoly");
            LuaFunctionsBackward.Add(14017536, "crosebriefingmsg");
            LuaFunctionsBackward.Add(14036016, "customluacall");
            LuaFunctionsBackward.Add(14049856, "customluacallstart");
            LuaFunctionsBackward.Add(14049808, "customluacallstartplus");
            LuaFunctionsBackward.Add(14018720, "deletecamsfx");
            LuaFunctionsBackward.Add(14019232, "deleteevent");
            LuaFunctionsBackward.Add(14018480, "deleteobjsfxall");
            LuaFunctionsBackward.Add(14018544, "deleteobjsfxdmyplyid");
            LuaFunctionsBackward.Add(14018512, "deleteobjsfxeventid");
            LuaFunctionsBackward.Add(14027328, "disablecollection");
            LuaFunctionsBackward.Add(14028240, "disabledamage");
            LuaFunctionsBackward.Add(14027264, "disablehpgauge");
            LuaFunctionsBackward.Add(14029488, "disableinterupt");
            LuaFunctionsBackward.Add(14030736, "disablemaphit");
            LuaFunctionsBackward.Add(14030800, "disablemove");
            LuaFunctionsBackward.Add(14020384, "enablegeneratorsystem");
            LuaFunctionsBackward.Add(14028288, "enablehide");
            LuaFunctionsBackward.Add(14028176, "enableinvincible");
            LuaFunctionsBackward.Add(14024080, "enablelogic");
            LuaFunctionsBackward.Add(14049744, "enableobjtreasure");
            LuaFunctionsBackward.Add(14031856, "endanimation");
            LuaFunctionsBackward.Add(14029328, "eraseeventspecialeffect");
            LuaFunctionsBackward.Add(14029168, "eraseeventspecialeffect_2");
            LuaFunctionsBackward.Add(14018592, "eventtaginsertstring_forplayerno");
            LuaFunctionsBackward.Add(14032384, "forcechangetarget");
            LuaFunctionsBackward.Add(14050960, "forcedead");
            LuaFunctionsBackward.Add(14032112, "forceplayanimation");
            LuaFunctionsBackward.Add(14032032, "forceplayanimationstaycancel");
            LuaFunctionsBackward.Add(14031952, "forceplayloopanimation");
            LuaFunctionsBackward.Add(14027920, "forceupdatenextframe");
            LuaFunctionsBackward.Add(14025008, "getbountyrankpoint");
            LuaFunctionsBackward.Add(14016176, "getclearbonus");
            LuaFunctionsBackward.Add(14019856, "getenemyplayerid_random");
            LuaFunctionsBackward.Add(14025536, "geteventflagvalue");
            LuaFunctionsBackward.Add(14029552, "geteventgoalstate");
            LuaFunctionsBackward.Add(14030480, "geteventmode");
            LuaFunctionsBackward.Add(14025856, "getfloormaterial");
            LuaFunctionsBackward.Add(14022736, "getglobalqwc");
            LuaFunctionsBackward.Add(14023296, "gethp");
            LuaFunctionsBackward.Add(14017088, "getitem");
            LuaFunctionsBackward.Add(14023536, "getlocalplayerchrtype");
            LuaFunctionsBackward.Add(14023504, "getlocalplayerinvadetype");
            LuaFunctionsBackward.Add(14023456, "getlocalplayervowtype");
            LuaFunctionsBackward.Add(14022768, "getlocalqwc");
            LuaFunctionsBackward.Add(14019888, "getplayerid_random");
            LuaFunctionsBackward.Add(14041344, "getplayerno_lotnitomultiitem");
            LuaFunctionsBackward.Add(14022848, "getqwc");
            LuaFunctionsBackward.Add(14016752, "getrandom");
            LuaFunctionsBackward.Add(14050736, "getrateitem");
            LuaFunctionsBackward.Add(14020480, "getrightcurrentweaponid");
            LuaFunctionsBackward.Add(14016096, "getsoloclearbonus");
            LuaFunctionsBackward.Add(14026896, "getsummonanimid");
            LuaFunctionsBackward.Add(14041440, "gettargetchrid");
            LuaFunctionsBackward.Add(14025792, "gettravelitemparamid");
            LuaFunctionsBackward.Add(14025776, "hassuppleitem");
            LuaFunctionsBackward.Add(14035968, "hovermoveval");
            LuaFunctionsBackward.Add(14043360, "hovermovevaldmy");
            LuaFunctionsBackward.Add(14021072, "incrementcoopplaysuccesscount");
            LuaFunctionsBackward.Add(14021024, "incrementthiefinvadeplaysuccesscount");
            LuaFunctionsBackward.Add(14041360, "infomationmenu");
            LuaFunctionsBackward.Add(14014432, "initdeathstate");
            LuaFunctionsBackward.Add(14028368, "invalidmybloodmarkinfo");
            LuaFunctionsBackward.Add(14028336, "invalidmybloodmarkinfo_tutorial");
            LuaFunctionsBackward.Add(14020704, "invalidpointlight");
            LuaFunctionsBackward.Add(14022528, "invalidsfx");
            LuaFunctionsBackward.Add(14023344, "isaction");
            LuaFunctionsBackward.Add(14030304, "isalive");
            LuaFunctionsBackward.Add(14031664, "isangle");
            LuaFunctionsBackward.Add(14020976, "isappearanceplayer");
            LuaFunctionsBackward.Add(14028528, "isblackghost");
            LuaFunctionsBackward.Add(14028464, "iscoliseumghost");
            LuaFunctionsBackward.Add(14028656, "isdisable");
            LuaFunctionsBackward.Add(14031776, "isdistance");
            LuaFunctionsBackward.Add(14027776, "isdropcheck_only");
            LuaFunctionsBackward.Add(14021872, "isequip");
            LuaFunctionsBackward.Add(14031920, "iseventanim");
            LuaFunctionsBackward.Add(14025728, "isfiredead");
            LuaFunctionsBackward.Add(14028592, "isgreyghost");
            LuaFunctionsBackward.Add(14028496, "isintruder");
            LuaFunctionsBackward.Add(14020416, "isinventoryequip");
            LuaFunctionsBackward.Add(14025808, "island");
            LuaFunctionsBackward.Add(14028624, "isliveplayer");
            LuaFunctionsBackward.Add(14019968, "ismatchingmultiplay");
            LuaFunctionsBackward.Add(14030352, "isplayerstay");
            LuaFunctionsBackward.Add(14027504, "isplaymovie");
            LuaFunctionsBackward.Add(14029632, "isprocesseventgoal");
            LuaFunctionsBackward.Add(14027824, "isregiondrop");
            LuaFunctionsBackward.Add(14028832, "isregionin");
            LuaFunctionsBackward.Add(14022608, "issuccessqwc");
            LuaFunctionsBackward.Add(14021904, "isvalidinstance");
            LuaFunctionsBackward.Add(14028560, "iswhiteghost");
            LuaFunctionsBackward.Add(14035200, "leavesession");
            LuaFunctionsBackward.Add(14020192, "locksession");
            LuaFunctionsBackward.Add(14036064, "luacall");
            LuaFunctionsBackward.Add(14049936, "luacallstart");
            LuaFunctionsBackward.Add(14049888, "luacallstartplus");
            LuaFunctionsBackward.Add(14032224, "multidoping_alleventbody");
            LuaFunctionsBackward.Add(14029952, "noanimeturncharactor");
            LuaFunctionsBackward.Add(14015456, "notnetmessage_begin");
            LuaFunctionsBackward.Add(14015440, "notnetmessage_end");
            LuaFunctionsBackward.Add(14043040, "objrootmtxmove");
            LuaFunctionsBackward.Add(14042976, "objrootmtxmovebychrdmypoly");
            LuaFunctionsBackward.Add(14043008, "objrootmtxmovedmypoly");
            LuaFunctionsBackward.Add(14040176, "onactioneventregion");
            LuaFunctionsBackward.Add(14040032, "onactioneventregionattribute");
            LuaFunctionsBackward.Add(14039136, "oncharacteranimend");
            LuaFunctionsBackward.Add(14039728, "oncharacterdead");
            LuaFunctionsBackward.Add(14039632, "oncharacterhp");
            LuaFunctionsBackward.Add(14039520, "oncharacterhp_checkattacker");
            LuaFunctionsBackward.Add(14042480, "onchranimend");
            LuaFunctionsBackward.Add(14038992, "onchranimendplus");
            LuaFunctionsBackward.Add(14044752, "ondistancejustin");
            LuaFunctionsBackward.Add(14038192, "onfiredamage");
            LuaFunctionsBackward.Add(14034384, "onnetregion");
            LuaFunctionsBackward.Add(14036480, "onnetregionplus");
            LuaFunctionsBackward.Add(14042464, "onobjanimend");
            LuaFunctionsBackward.Add(14042448, "onobjanimendplus");
            LuaFunctionsBackward.Add(14039296, "onobjdestroy");
            LuaFunctionsBackward.Add(14040464, "onplayeractioninregionangle");
            LuaFunctionsBackward.Add(14040320, "onplayeractioninregionangleattribute");
            LuaFunctionsBackward.Add(14046080, "onplayerdistanceintarget");
            LuaFunctionsBackward.Add(14044896, "onplayerdistanceout");
            LuaFunctionsBackward.Add(14038064, "onplayerkill");
            LuaFunctionsBackward.Add(14041168, "onregionin");
            LuaFunctionsBackward.Add(14041024, "onregionjustin");
            LuaFunctionsBackward.Add(14040896, "onregionjustout");
            LuaFunctionsBackward.Add(14037936, "onselfbloodmark");
            LuaFunctionsBackward.Add(14037808, "onselfherobloodmark");
            LuaFunctionsBackward.Add(14037552, "onsessionin");
            LuaFunctionsBackward.Add(14037680, "onsessionjustin");
            LuaFunctionsBackward.Add(14037424, "onsessionjustout");
            LuaFunctionsBackward.Add(14037296, "onsessionout");
            LuaFunctionsBackward.Add(14038336, "onsimpledamage");
            LuaFunctionsBackward.Add(14048048, "ontalkeventdistin");
            LuaFunctionsBackward.Add(14047920, "ontalkeventdistout");
            LuaFunctionsBackward.Add(14034720, "ontexteffectend");
            LuaFunctionsBackward.Add(14035504, "onturncharactorend");
            LuaFunctionsBackward.Add(14033472, "onwanderingdemon");
            LuaFunctionsBackward.Add(14015104, "opencampmenu");
            LuaFunctionsBackward.Add(14018384, "opensosmsg_tutorial");
            LuaFunctionsBackward.Add(14050816, "openingdead");
            LuaFunctionsBackward.Add(14050144, "paraminitialize");
            LuaFunctionsBackward.Add(14016688, "pausetutorial");
            LuaFunctionsBackward.Add(14032144, "playanimation");
            LuaFunctionsBackward.Add(14032064, "playanimationstaycancel");
            LuaFunctionsBackward.Add(14026288, "playerchrresetanimation_remoonly");
            LuaFunctionsBackward.Add(14031984, "playloopanimation");
            LuaFunctionsBackward.Add(14030432, "playobjectse");
            LuaFunctionsBackward.Add(14032640, "playpointse");
            LuaFunctionsBackward.Add(14030384, "playtypese");
            LuaFunctionsBackward.Add(14034816, "recallmenuevent");
            LuaFunctionsBackward.Add(14049392, "reconstructbreak");
            LuaFunctionsBackward.Add(14026560, "recoveryheroin");
            LuaFunctionsBackward.Add(14027888, "removeinventoryequip");
            LuaFunctionsBackward.Add(14015424, "repeatmessage_begin");
            LuaFunctionsBackward.Add(14015408, "repeatmessage_end");
            LuaFunctionsBackward.Add(14015952, "requestending");
            LuaFunctionsBackward.Add(14027424, "requestforceupdatenetwork");
            LuaFunctionsBackward.Add(14015808, "requestfullrecover");
            LuaFunctionsBackward.Add(14021264, "requestgenerate");
            LuaFunctionsBackward.Add(14027376, "requestnormalupdatenetwork");
            LuaFunctionsBackward.Add(14019408, "requestopenbriefingmsg");
            LuaFunctionsBackward.Add(14033504, "requestopenbriefingmsgplus");
            LuaFunctionsBackward.Add(14047056, "requestplaymovie");
            LuaFunctionsBackward.Add(14046928, "requestplaymovieplus");
            LuaFunctionsBackward.Add(14050368, "requestremo");
            LuaFunctionsBackward.Add(14050272, "requestremoplus");
            LuaFunctionsBackward.Add(14019504, "requestunlocktrophy");
            LuaFunctionsBackward.Add(14017504, "reqularleaveplayer");
            LuaFunctionsBackward.Add(14019360, "resetcamangle");
            LuaFunctionsBackward.Add(14032592, "reseteventqwcspeffect");
            LuaFunctionsBackward.Add(14019456, "resetsummonparam");
            LuaFunctionsBackward.Add(14025984, "resetsyncrideobjinfo");
            LuaFunctionsBackward.Add(14028912, "resetthink");
            LuaFunctionsBackward.Add(14044224, "restorepiece");
            LuaFunctionsBackward.Add(14016960, "returnmapselect");
            LuaFunctionsBackward.Add(14042592, "reviveplayer");
            LuaFunctionsBackward.Add(14016672, "reviveplayernext");
            LuaFunctionsBackward.Add(14020240, "saverequest");
            LuaFunctionsBackward.Add(14020208, "saverequest_profile");
            LuaFunctionsBackward.Add(14029104, "sendeventrequest");
            LuaFunctionsBackward.Add(14050464, "setalive");
            LuaFunctionsBackward.Add(14018240, "setalivemotion");
            LuaFunctionsBackward.Add(14026096, "setalwaysdrawforevent");
            LuaFunctionsBackward.Add(14026576, "setalwaysenablebackread_forevent");
            LuaFunctionsBackward.Add(14031488, "setanglefoward");
            LuaFunctionsBackward.Add(14022432, "setareastartmapuid");
            LuaFunctionsBackward.Add(14026496, "setbossgauge");
            LuaFunctionsBackward.Add(14030608, "setbossunitjrhit");
            LuaFunctionsBackward.Add(14044672, "setbountyrankpoint");
            LuaFunctionsBackward.Add(14022560, "setbrokenpiece");
            LuaFunctionsBackward.Add(14016256, "setcammodeparamtargetid");
            LuaFunctionsBackward.Add(14016240, "setcammodeparamtargetidforbosslock");
            LuaFunctionsBackward.Add(14028400, "setchrtype");
            LuaFunctionsBackward.Add(14016432, "setchrtypedatagrey");
            LuaFunctionsBackward.Add(14016336, "setchrtypedatagreynext");
            LuaFunctionsBackward.Add(14021584, "setclearbonus");
            LuaFunctionsBackward.Add(14015696, "setclearitem");
            LuaFunctionsBackward.Add(14017728, "setclearsesiioncount");
            LuaFunctionsBackward.Add(14017888, "setclearstate");
            LuaFunctionsBackward.Add(14024848, "setcolienable");
            LuaFunctionsBackward.Add(14043808, "setcolienablearray");
            LuaFunctionsBackward.Add(14025952, "setcompletelynomove");
            LuaFunctionsBackward.Add(14029872, "setdeadmode");
            LuaFunctionsBackward.Add(14029808, "setdeadmode2");
            LuaFunctionsBackward.Add(14042528, "setdefaultroutepoint");
            LuaFunctionsBackward.Add(14022272, "setdefaultmapuid");
            LuaFunctionsBackward.Add(14028736, "setdisable");
            LuaFunctionsBackward.Add(14027472, "setdisablebackread_forevent");
            LuaFunctionsBackward.Add(14019632, "setdisabledamage");
            LuaFunctionsBackward.Add(14028960, "setdisablegravity");
            LuaFunctionsBackward.Add(14025680, "setdisableweakdamageanim");
            LuaFunctionsBackward.Add(14025616, "setdisableweakdamageanim_light");
            LuaFunctionsBackward.Add(14030848, "setdispmask");
            LuaFunctionsBackward.Add(14024880, "setdrawenable");
            LuaFunctionsBackward.Add(14042416, "setdrawenablearray");
            LuaFunctionsBackward.Add(14031360, "setdrawgroup");
            LuaFunctionsBackward.Add(14017568, "setenableeventpad");
            LuaFunctionsBackward.Add(14018320, "seteventbodymaterialseandsfx");
            LuaFunctionsBackward.Add(14032240, "seteventbodymaxhp");
            LuaFunctionsBackward.Add(14023856, "seteventcommand");
            LuaFunctionsBackward.Add(14023792, "seteventcommandindex");
            LuaFunctionsBackward.Add(14025104, "seteventflag");
            LuaFunctionsBackward.Add(14025568, "seteventflagvalue");
            LuaFunctionsBackward.Add(14025904, "seteventgenerate");
            LuaFunctionsBackward.Add(14027696, "seteventmovepointtype");
            LuaFunctionsBackward.Add(14029440, "seteventspecialeffect");
            LuaFunctionsBackward.Add(14029248, "seteventspecialeffect_2");
            LuaFunctionsBackward.Add(14029376, "seteventspecialeffectowner");
            LuaFunctionsBackward.Add(14029200, "seteventspecialeffectowner_2");
            LuaFunctionsBackward.Add(14031520, "seteventtarget");
            LuaFunctionsBackward.Add(14032528, "setfirstspeed");
            LuaFunctionsBackward.Add(14015472, "setflaginitstate");
            LuaFunctionsBackward.Add(14025488, "setfootikinterpolatetype");
            LuaFunctionsBackward.Add(14048752, "setforcejoinblackrequest");
            LuaFunctionsBackward.Add(14031248, "sethitinfo");
            LuaFunctionsBackward.Add(14043424, "sethitmask");
            LuaFunctionsBackward.Add(14023072, "sethp");
            LuaFunctionsBackward.Add(14030672, "setignorehit");
            LuaFunctionsBackward.Add(14015248, "setinfomationpriority");
            LuaFunctionsBackward.Add(14028880, "setinsidebattlearea");
            LuaFunctionsBackward.Add(14021376, "setisanimpauseonremoplayforevent");
            LuaFunctionsBackward.Add(14034160, "setkeepcommandindex");
            LuaFunctionsBackward.Add(14014784, "setloadwait");
            LuaFunctionsBackward.Add(14026992, "setlockactpntinvalidatemask");
            LuaFunctionsBackward.Add(14042640, "setmapuid");
            LuaFunctionsBackward.Add(14022928, "setmaxhp");
            LuaFunctionsBackward.Add(14015344, "setmenubrake");
            LuaFunctionsBackward.Add(14022128, "setminiblockindex");
            LuaFunctionsBackward.Add(14029712, "setmovepoint");
            LuaFunctionsBackward.Add(14021120, "setmultiwallmapuid");
            LuaFunctionsBackward.Add(14026448, "setnonetsync");
            LuaFunctionsBackward.Add(14020896, "setobjdeactivate");
            LuaFunctionsBackward.Add(14021440, "setobjdisablebreak");
            LuaFunctionsBackward.Add(14024576, "setobjeventcollisionfill");
            LuaFunctionsBackward.Add(14015600, "setreturnpointentityid");
            LuaFunctionsBackward.Add(14018176, "setrevivewait");
            LuaFunctionsBackward.Add(14024688, "setselfbloodmapuid");
            LuaFunctionsBackward.Add(14022000, "setsossignpos");
            LuaFunctionsBackward.Add(14016624, "setsossignwarp");
            LuaFunctionsBackward.Add(14027200, "setspstayanddamageanimid");
            LuaFunctionsBackward.Add(14014592, "setsubmenubrake");
            LuaFunctionsBackward.Add(14016656, "setsummonedpos");
            LuaFunctionsBackward.Add(14026016, "setsyncrideobjinfo");
            LuaFunctionsBackward.Add(14026144, "setsystemignore");
            LuaFunctionsBackward.Add(14016912, "settalkmsg");
            LuaFunctionsBackward.Add(14027600, "setteamtype");
            LuaFunctionsBackward.Add(14027520, "setteamtypedefault");
            LuaFunctionsBackward.Add(14027568, "setteamtypeplus");
            LuaFunctionsBackward.Add(14017584, "settexteffect");
            LuaFunctionsBackward.Add(14016640, "settutorialsummonedpos");
            LuaFunctionsBackward.Add(14017984, "setvalidtalk");
            LuaFunctionsBackward.Add(14014816, "showrankingdialog");
            LuaFunctionsBackward.Add(14024640, "stoploopanimation");
            LuaFunctionsBackward.Add(14027088, "stopplayer");
            LuaFunctionsBackward.Add(14019168, "stoppointse");
            LuaFunctionsBackward.Add(14023616, "subactioncount");
            LuaFunctionsBackward.Add(14024352, "subdispmaskbybit");
            LuaFunctionsBackward.Add(14044320, "subhitmask");
            LuaFunctionsBackward.Add(14044400, "subhitmaskbybit");
            LuaFunctionsBackward.Add(14034896, "summonblackrequest");
            LuaFunctionsBackward.Add(14026832, "summonedmapreload");
            LuaFunctionsBackward.Add(14044080, "summonsuccess");
            LuaFunctionsBackward.Add(14024480, "switchdispmask");
            LuaFunctionsBackward.Add(14044592, "switchhitmask");
            LuaFunctionsBackward.Add(14018112, "talknextpage");
            LuaFunctionsBackward.Add(14043232, "treasuredispmodechange");
            LuaFunctionsBackward.Add(14033824, "turncharactor");
            LuaFunctionsBackward.Add(14016560, "tutorial_begin");
            LuaFunctionsBackward.Add(14016544, "tutorial_end");
            LuaFunctionsBackward.Add(14017520, "unlocksession");
            LuaFunctionsBackward.Add(14049776, "updatebloodmark");
            LuaFunctionsBackward.Add(14014512, "util_requestlevelup");
            LuaFunctionsBackward.Add(14014544, "util_requestlevelupfirst");
            LuaFunctionsBackward.Add(14014496, "util_requestregene");
            LuaFunctionsBackward.Add(14014480, "util_requestrespawn");
            LuaFunctionsBackward.Add(14020640, "validpointlight");
            LuaFunctionsBackward.Add(14020768, "validsfx");
            LuaFunctionsBackward.Add(14032192, "warp");
            LuaFunctionsBackward.Add(14043760, "warpdmy");
            LuaFunctionsBackward.Add(14036224, "warpnextstage");
            LuaFunctionsBackward.Add(14035248, "warpnextstagekick");
            LuaFunctionsBackward.Add(14036128, "warpnextstage_bonfire");
            LuaFunctionsBackward.Add(14034304, "warprestart");
            LuaFunctionsBackward.Add(14034256, "warprestartnogrey");
            LuaFunctionsBackward.Add(14043600, "warpselfbloodmark");

            Dictionary<string, int> ReturnDictionary = new Dictionary<string, int>();
            foreach(var Entry in LuaFunctionsBackward)
            {
                ReturnDictionary.Add(Entry.Value, Entry.Key);
            }

            return ReturnDictionary;
        }
    }
}
