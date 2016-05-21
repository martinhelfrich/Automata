// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.0
// Machine:  MARGUS-X1
// DateTime: 5/20/2016 6:19:32 PM
// UserName: margus
// Input file <mona.y - 5/20/2016 6:17:28 PM>

// options: babel conflicts lines gplex conflicts

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace Microsoft.Automata.MSO.Mona
{
public enum Tokens {
    error=1,EOF=2,WS1S=3,WS2S=4,M2LSTR=5,M2LTREE=6,
    LT=7,GT=8,LE=9,GE=10,EQ=11,NE=12,
    PLUS=13,MINUS=14,TIMES=15,DIV=16,MOD=17,SETMINUS=18,
    TRUE=19,FALSE=20,NOT=21,AND=22,OR=23,IMPLIES=24,
    EQUIV=25,IN=26,NOTIN=27,SUBSET=28,EMPTY=29,RESTRICT=30,
    EX0=31,EX1=32,EX2=33,ALL0=34,ALL1=35,ALL2=36,
    LET0=37,LET1=38,LET2=39,VAR0=40,VAR1=41,VAR2=42,
    WHERE=43,PREFIX=44,MAX=45,MIN=46,PCONST=47,UNION=48,
    INTER=49,GUIDE=50,UNIVERSE=51,INCLUDE=52,ASSERT=53,EXECUTE=54,
    CONST=55,DEFAULTWHERE1=56,DEFAULTWHERE2=57,TREE=58,MACRO=59,PRED=60,
    ALLPOS=61,TYPE=62,ARROW=63,NAME=64,NUMBER=65,LBRACKET=66,
    RBRACKET=67,LBRACE=68,RBRACE=69,LPAR=70,RPAR=71,COMMA=72,
    COLON=73,SEMICOLON=74,DOT=75,UP=76,BADCHAR=77,maxParseToken=78,
    COMMENT=79};

// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<object,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }

  protected abstract int CurrentSc { get; set; }
  //
  // Override the virtual EolState property if the scanner state is more
  // complicated then a simple copy of the current start state ordinal
  //
  public virtual int EolState { get { return CurrentSc; } set { CurrentSc = value; } }
}

// Interface class for 'colorizing' scanners
public interface IColorScan {
  void SetSource(string source, int offset);
  int GetNext(ref int state, out int start, out int end);
}

// Utility class for encapsulating token information
public class ScanObj {
  public int token;
  public object yylval;
  public LexLocation yylloc;
  public ScanObj( int t, object val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

public partial class MonaParser: ShiftReduceParser<object, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[90];
  private static State[] states = new State[180];
  private static string[] nonTerms = new string[] {
      "program", "$accept", "header", "decls", "decl", "formula", "univargs", 
      "intterm", "names", "univs", "vws", "univarg", "term", "Q0", "Q", "exps", 
      "exp", "univs_", };

  static MonaParser() {
    states[0] = new State(new int[]{3,175,4,176,5,177,6,178,19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44,51,117,53,126,54,128,55,130,56,149,57,155,40,161,41,163,42,167,58,171},new int[]{-1,1,-3,3,-4,179,-5,6,-6,10,-14,72,-15,78,-13,87});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{74,4});
    states[4] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44,51,117,53,126,54,128,55,130,56,149,57,155,40,161,41,163,42,167,58,171},new int[]{-4,5,-5,6,-6,10,-14,72,-15,78,-13,87});
    states[5] = new State(-2);
    states[6] = new State(new int[]{74,7});
    states[7] = new State(new int[]{2,8,19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44,51,117,53,126,54,128,55,130,56,149,57,155,40,161,41,163,42,167,58,171},new int[]{-4,9,-5,6,-6,10,-14,72,-15,78,-13,87});
    states[8] = new State(-8);
    states[9] = new State(-9);
    states[10] = new State(new int[]{22,11,23,13,24,15,25,17,74,-10});
    states[11] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,12,-14,72,-15,78,-13,87});
    states[12] = new State(-50);
    states[13] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,14,-14,72,-15,78,-13,87});
    states[14] = new State(new int[]{22,11,23,-51,24,-51,25,-51,74,-51,71,-51,72,-51,73,-51});
    states[15] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,16,-14,72,-15,78,-13,87});
    states[16] = new State(new int[]{22,11,23,13,24,15,25,-52,74,-52,71,-52,72,-52,73,-52});
    states[17] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,18,-14,72,-15,78,-13,87});
    states[18] = new State(new int[]{22,11,23,13,24,15,25,17,74,-53,71,-53,72,-53,73,-53});
    states[19] = new State(-41);
    states[20] = new State(-42);
    states[21] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,22,-13,24,-14,72,-15,78});
    states[22] = new State(new int[]{71,23,22,11,23,13,24,15,25,17});
    states[23] = new State(-43);
    states[24] = new State(new int[]{71,25,11,26,13,28,14,30,15,32,16,34,17,36,12,46,8,48,10,50,7,52,9,54,26,56,27,58,28,60});
    states[25] = new State(-82);
    states[26] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,27});
    states[27] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,22,-54,23,-54,24,-54,25,-54,74,-54,71,-54,72,-54,73,-54});
    states[28] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,29});
    states[29] = new State(new int[]{13,-83,14,-83,15,32,16,34,17,36,11,-83,12,-83,8,-83,10,-83,7,-83,9,-83,26,-83,27,-83,28,-83,71,-83,22,-83,23,-83,24,-83,25,-83,74,-83,72,-83,73,-83});
    states[30] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,31});
    states[31] = new State(new int[]{13,-84,14,-84,15,32,16,34,17,36,11,-84,12,-84,8,-84,10,-84,7,-84,9,-84,26,-84,27,-84,28,-84,71,-84,22,-84,23,-84,24,-84,25,-84,74,-84,72,-84,73,-84});
    states[32] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,33});
    states[33] = new State(-85);
    states[34] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,35});
    states[35] = new State(-86);
    states[36] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,37});
    states[37] = new State(-87);
    states[38] = new State(-80);
    states[39] = new State(-81);
    states[40] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,41});
    states[41] = new State(new int[]{71,25,13,28,14,30,15,32,16,34,17,36});
    states[42] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,43});
    states[43] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,11,-88,12,-88,8,-88,10,-88,7,-88,9,-88,26,-88,27,-88,28,-88,71,-88,22,-88,23,-88,24,-88,25,-88,74,-88,72,-88,73,-88});
    states[44] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,45});
    states[45] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,11,-89,12,-89,8,-89,10,-89,7,-89,9,-89,26,-89,27,-89,28,-89,71,-89,22,-89,23,-89,24,-89,25,-89,74,-89,72,-89,73,-89});
    states[46] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,47});
    states[47] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,22,-55,23,-55,24,-55,25,-55,74,-55,71,-55,72,-55,73,-55});
    states[48] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,49});
    states[49] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,22,-56,23,-56,24,-56,25,-56,74,-56,71,-56,72,-56,73,-56});
    states[50] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,51});
    states[51] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,22,-57,23,-57,24,-57,25,-57,74,-57,71,-57,72,-57,73,-57});
    states[52] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,53});
    states[53] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,22,-58,23,-58,24,-58,25,-58,74,-58,71,-58,72,-58,73,-58});
    states[54] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,55});
    states[55] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,22,-59,23,-59,24,-59,25,-59,74,-59,71,-59,72,-59,73,-59});
    states[56] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,57});
    states[57] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,22,-60,23,-60,24,-60,25,-60,74,-60,71,-60,72,-60,73,-60});
    states[58] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,59});
    states[59] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,22,-61,23,-61,24,-61,25,-61,74,-61,71,-61,72,-61,73,-61});
    states[60] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,61});
    states[61] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,22,-62,23,-62,24,-62,25,-62,74,-62,71,-62,72,-62,73,-62});
    states[62] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,63,-14,72,-15,78,-13,87});
    states[63] = new State(-44);
    states[64] = new State(new int[]{70,65});
    states[65] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,66,-14,72,-15,78,-13,87});
    states[66] = new State(new int[]{71,67,22,11,23,13,24,15,25,17});
    states[67] = new State(-45);
    states[68] = new State(new int[]{70,69});
    states[69] = new State(new int[]{64,38,65,39,70,40,46,42,45,44},new int[]{-13,70});
    states[70] = new State(new int[]{71,71,13,28,14,30,15,32,16,34,17,36});
    states[71] = new State(-46);
    states[72] = new State(new int[]{64,114},new int[]{-9,73});
    states[73] = new State(new int[]{73,74});
    states[74] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,75,-14,72,-15,78,-13,87});
    states[75] = new State(new int[]{22,11,23,13,24,15,25,17,74,-47,71,-47,72,-47,73,-47});
    states[76] = new State(-69);
    states[77] = new State(-70);
    states[78] = new State(new int[]{66,107,64,97},new int[]{-10,79,-11,104});
    states[79] = new State(new int[]{64,97},new int[]{-11,80});
    states[80] = new State(new int[]{73,81});
    states[81] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,82,-14,72,-15,78,-13,87});
    states[82] = new State(new int[]{22,11,23,13,24,15,25,17,74,-48,71,-48,72,-48,73,-48});
    states[83] = new State(-65);
    states[84] = new State(-66);
    states[85] = new State(-67);
    states[86] = new State(-68);
    states[87] = new State(new int[]{11,26,13,28,14,30,15,32,16,34,17,36,12,46,8,48,10,50,7,52,9,54,26,56,27,58,28,60});
    states[88] = new State(new int[]{70,89,11,-80,13,-80,14,-80,15,-80,16,-80,17,-80,12,-80,8,-80,10,-80,7,-80,9,-80,26,-80,27,-80,28,-80,71,-64,72,-64,22,-64,23,-64,24,-64,25,-64,74,-64,73,-64});
    states[89] = new State(new int[]{71,91,72,92},new int[]{-16,90});
    states[90] = new State(-63);
    states[91] = new State(-71);
    states[92] = new State(new int[]{64,88,65,39,70,21,46,42,45,44,19,19,20,20,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86},new int[]{-17,93,-13,95,-6,96,-14,72,-15,78});
    states[93] = new State(new int[]{71,91,72,92},new int[]{-16,94});
    states[94] = new State(-72);
    states[95] = new State(new int[]{13,28,14,30,15,32,16,34,17,36,11,26,12,46,8,48,10,50,7,52,9,54,26,56,27,58,28,60,71,-73,72,-73});
    states[96] = new State(new int[]{22,11,23,13,24,15,25,17,71,-74,72,-74});
    states[97] = new State(new int[]{72,98,43,100,73,-40,74,-40});
    states[98] = new State(new int[]{64,97},new int[]{-11,99});
    states[99] = new State(-37);
    states[100] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,101,-14,72,-15,78,-13,87});
    states[101] = new State(new int[]{72,102,22,11,23,13,24,15,25,17,73,-39,74,-39});
    states[102] = new State(new int[]{64,97},new int[]{-11,103});
    states[103] = new State(-38);
    states[104] = new State(new int[]{73,105});
    states[105] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,106,-14,72,-15,78,-13,87});
    states[106] = new State(new int[]{22,11,23,13,24,15,25,17,74,-49,71,-49,72,-49,73,-49});
    states[107] = new State(new int[]{64,108});
    states[108] = new State(new int[]{67,110,72,111},new int[]{-18,109});
    states[109] = new State(-77);
    states[110] = new State(-78);
    states[111] = new State(new int[]{64,112});
    states[112] = new State(new int[]{67,110,72,111},new int[]{-18,113});
    states[113] = new State(-79);
    states[114] = new State(new int[]{72,115,73,-76,74,-76});
    states[115] = new State(new int[]{64,114},new int[]{-9,116});
    states[116] = new State(-75);
    states[117] = new State(new int[]{64,122},new int[]{-7,118,-12,119});
    states[118] = new State(-11);
    states[119] = new State(new int[]{72,120,74,-33});
    states[120] = new State(new int[]{64,122},new int[]{-7,121,-12,119});
    states[121] = new State(-32);
    states[122] = new State(new int[]{73,123,72,-36,74,-36});
    states[123] = new State(new int[]{64,124,65,125});
    states[124] = new State(-34);
    states[125] = new State(-35);
    states[126] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,127,-14,72,-15,78,-13,87});
    states[127] = new State(new int[]{22,11,23,13,24,15,25,17,74,-12});
    states[128] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,129,-14,72,-15,78,-13,87});
    states[129] = new State(new int[]{22,11,23,13,24,15,25,17,74,-13});
    states[130] = new State(new int[]{64,131});
    states[131] = new State(new int[]{11,132});
    states[132] = new State(new int[]{70,144,64,147,65,148},new int[]{-8,133});
    states[133] = new State(new int[]{13,134,14,136,15,138,16,140,17,142,74,-14});
    states[134] = new State(new int[]{70,144,64,147,65,148},new int[]{-8,135});
    states[135] = new State(new int[]{13,-25,14,-25,15,138,16,140,17,142,74,-25,71,-25});
    states[136] = new State(new int[]{70,144,64,147,65,148},new int[]{-8,137});
    states[137] = new State(new int[]{13,-26,14,-26,15,138,16,140,17,142,74,-26,71,-26});
    states[138] = new State(new int[]{70,144,64,147,65,148},new int[]{-8,139});
    states[139] = new State(-27);
    states[140] = new State(new int[]{70,144,64,147,65,148},new int[]{-8,141});
    states[141] = new State(-28);
    states[142] = new State(new int[]{70,144,64,147,65,148},new int[]{-8,143});
    states[143] = new State(-29);
    states[144] = new State(new int[]{70,144,64,147,65,148},new int[]{-8,145});
    states[145] = new State(new int[]{71,146,13,134,14,136,15,138,16,140,17,142});
    states[146] = new State(-24);
    states[147] = new State(-30);
    states[148] = new State(-31);
    states[149] = new State(new int[]{70,150});
    states[150] = new State(new int[]{64,151});
    states[151] = new State(new int[]{71,152});
    states[152] = new State(new int[]{11,153});
    states[153] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,154,-14,72,-15,78,-13,87});
    states[154] = new State(new int[]{22,11,23,13,24,15,25,17,74,-15});
    states[155] = new State(new int[]{70,156});
    states[156] = new State(new int[]{64,157});
    states[157] = new State(new int[]{71,158});
    states[158] = new State(new int[]{11,159});
    states[159] = new State(new int[]{19,19,20,20,70,21,21,62,30,64,29,68,31,76,34,77,32,83,33,84,35,85,36,86,64,88,65,39,46,42,45,44},new int[]{-6,160,-14,72,-15,78,-13,87});
    states[160] = new State(new int[]{22,11,23,13,24,15,25,17,74,-16});
    states[161] = new State(new int[]{64,114},new int[]{-9,162});
    states[162] = new State(-17);
    states[163] = new State(new int[]{66,107,64,97},new int[]{-10,164,-11,166});
    states[164] = new State(new int[]{64,97},new int[]{-11,165});
    states[165] = new State(-18);
    states[166] = new State(-21);
    states[167] = new State(new int[]{66,107,64,97},new int[]{-10,168,-11,170});
    states[168] = new State(new int[]{64,97},new int[]{-11,169});
    states[169] = new State(-19);
    states[170] = new State(-22);
    states[171] = new State(new int[]{66,107,64,97},new int[]{-10,172,-11,174});
    states[172] = new State(new int[]{64,97},new int[]{-11,173});
    states[173] = new State(-20);
    states[174] = new State(-23);
    states[175] = new State(-4);
    states[176] = new State(-5);
    states[177] = new State(-6);
    states[178] = new State(-7);
    states[179] = new State(-3);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,2});
    rules[2] = new Rule(-1, new int[]{-3,74,-4});
    rules[3] = new Rule(-1, new int[]{-4});
    rules[4] = new Rule(-3, new int[]{3});
    rules[5] = new Rule(-3, new int[]{4});
    rules[6] = new Rule(-3, new int[]{5});
    rules[7] = new Rule(-3, new int[]{6});
    rules[8] = new Rule(-4, new int[]{-5,74,2});
    rules[9] = new Rule(-4, new int[]{-5,74,-4});
    rules[10] = new Rule(-5, new int[]{-6});
    rules[11] = new Rule(-5, new int[]{51,-7});
    rules[12] = new Rule(-5, new int[]{53,-6});
    rules[13] = new Rule(-5, new int[]{54,-6});
    rules[14] = new Rule(-5, new int[]{55,64,11,-8});
    rules[15] = new Rule(-5, new int[]{56,70,64,71,11,-6});
    rules[16] = new Rule(-5, new int[]{57,70,64,71,11,-6});
    rules[17] = new Rule(-5, new int[]{40,-9});
    rules[18] = new Rule(-5, new int[]{41,-10,-11});
    rules[19] = new Rule(-5, new int[]{42,-10,-11});
    rules[20] = new Rule(-5, new int[]{58,-10,-11});
    rules[21] = new Rule(-5, new int[]{41,-11});
    rules[22] = new Rule(-5, new int[]{42,-11});
    rules[23] = new Rule(-5, new int[]{58,-11});
    rules[24] = new Rule(-8, new int[]{70,-8,71});
    rules[25] = new Rule(-8, new int[]{-8,13,-8});
    rules[26] = new Rule(-8, new int[]{-8,14,-8});
    rules[27] = new Rule(-8, new int[]{-8,15,-8});
    rules[28] = new Rule(-8, new int[]{-8,16,-8});
    rules[29] = new Rule(-8, new int[]{-8,17,-8});
    rules[30] = new Rule(-8, new int[]{64});
    rules[31] = new Rule(-8, new int[]{65});
    rules[32] = new Rule(-7, new int[]{-12,72,-7});
    rules[33] = new Rule(-7, new int[]{-12});
    rules[34] = new Rule(-12, new int[]{64,73,64});
    rules[35] = new Rule(-12, new int[]{64,73,65});
    rules[36] = new Rule(-12, new int[]{64});
    rules[37] = new Rule(-11, new int[]{64,72,-11});
    rules[38] = new Rule(-11, new int[]{64,43,-6,72,-11});
    rules[39] = new Rule(-11, new int[]{64,43,-6});
    rules[40] = new Rule(-11, new int[]{64});
    rules[41] = new Rule(-6, new int[]{19});
    rules[42] = new Rule(-6, new int[]{20});
    rules[43] = new Rule(-6, new int[]{70,-6,71});
    rules[44] = new Rule(-6, new int[]{21,-6});
    rules[45] = new Rule(-6, new int[]{30,70,-6,71});
    rules[46] = new Rule(-6, new int[]{29,70,-13,71});
    rules[47] = new Rule(-6, new int[]{-14,-9,73,-6});
    rules[48] = new Rule(-6, new int[]{-15,-10,-11,73,-6});
    rules[49] = new Rule(-6, new int[]{-15,-11,73,-6});
    rules[50] = new Rule(-6, new int[]{-6,22,-6});
    rules[51] = new Rule(-6, new int[]{-6,23,-6});
    rules[52] = new Rule(-6, new int[]{-6,24,-6});
    rules[53] = new Rule(-6, new int[]{-6,25,-6});
    rules[54] = new Rule(-6, new int[]{-13,11,-13});
    rules[55] = new Rule(-6, new int[]{-13,12,-13});
    rules[56] = new Rule(-6, new int[]{-13,8,-13});
    rules[57] = new Rule(-6, new int[]{-13,10,-13});
    rules[58] = new Rule(-6, new int[]{-13,7,-13});
    rules[59] = new Rule(-6, new int[]{-13,9,-13});
    rules[60] = new Rule(-6, new int[]{-13,26,-13});
    rules[61] = new Rule(-6, new int[]{-13,27,-13});
    rules[62] = new Rule(-6, new int[]{-13,28,-13});
    rules[63] = new Rule(-6, new int[]{64,70,-16});
    rules[64] = new Rule(-6, new int[]{64});
    rules[65] = new Rule(-15, new int[]{32});
    rules[66] = new Rule(-15, new int[]{33});
    rules[67] = new Rule(-15, new int[]{35});
    rules[68] = new Rule(-15, new int[]{36});
    rules[69] = new Rule(-14, new int[]{31});
    rules[70] = new Rule(-14, new int[]{34});
    rules[71] = new Rule(-16, new int[]{71});
    rules[72] = new Rule(-16, new int[]{72,-17,-16});
    rules[73] = new Rule(-17, new int[]{-13});
    rules[74] = new Rule(-17, new int[]{-6});
    rules[75] = new Rule(-9, new int[]{64,72,-9});
    rules[76] = new Rule(-9, new int[]{64});
    rules[77] = new Rule(-10, new int[]{66,64,-18});
    rules[78] = new Rule(-18, new int[]{67});
    rules[79] = new Rule(-18, new int[]{72,64,-18});
    rules[80] = new Rule(-13, new int[]{64});
    rules[81] = new Rule(-13, new int[]{65});
    rules[82] = new Rule(-13, new int[]{70,-13,71});
    rules[83] = new Rule(-13, new int[]{-13,13,-13});
    rules[84] = new Rule(-13, new int[]{-13,14,-13});
    rules[85] = new Rule(-13, new int[]{-13,15,-13});
    rules[86] = new Rule(-13, new int[]{-13,16,-13});
    rules[87] = new Rule(-13, new int[]{-13,17,-13});
    rules[88] = new Rule(-13, new int[]{46,-13});
    rules[89] = new Rule(-13, new int[]{45,-13});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 2: // program -> header, SEMICOLON, decls
#line 44 "mona.y"
{ CurrentSemanticValue = MkProgram(ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 3: // program -> decls
#line 45 "mona.y"
{ CurrentSemanticValue = MkProgram(ValueStack[ValueStack.Depth-1]); }
        break;
      case 8: // decls -> decl, SEMICOLON, EOF
#line 53 "mona.y"
{ CurrentSemanticValue = MkList<Decl>(ValueStack[ValueStack.Depth-3], MkList<Decl>()); }
        break;
      case 9: // decls -> decl, SEMICOLON, decls
#line 54 "mona.y"
{ CurrentSemanticValue = MkList<Decl>(ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 10: // decl -> formula
#line 58 "mona.y"
{ CurrentSemanticValue = MkFormulaDecl(ValueStack[ValueStack.Depth-1]); }
        break;
      case 11: // decl -> UNIVERSE, univargs
#line 59 "mona.y"
{ CurrentSemanticValue = MkUnivDecl(ValueStack[ValueStack.Depth-1]); }
        break;
      case 12: // decl -> ASSERT, formula
#line 60 "mona.y"
{ CurrentSemanticValue = MkAssertDecl(ValueStack[ValueStack.Depth-1]); }
        break;
      case 13: // decl -> EXECUTE, formula
#line 61 "mona.y"
{ CurrentSemanticValue = MkExecuteDecl(ValueStack[ValueStack.Depth-1]); }
        break;
      case 14: // decl -> CONST, NAME, EQ, intterm
#line 62 "mona.y"
{ CurrentSemanticValue = MkConstDecl(ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 15: // decl -> DEFAULTWHERE1, LPAR, NAME, RPAR, EQ, formula
#line 63 "mona.y"
{ CurrentSemanticValue = MkDefaultWhere1Decl(ValueStack[ValueStack.Depth-4], ValueStack[ValueStack.Depth-1]); }
        break;
      case 16: // decl -> DEFAULTWHERE2, LPAR, NAME, RPAR, EQ, formula
#line 64 "mona.y"
{ CurrentSemanticValue = MkDefaultWhere2Decl(ValueStack[ValueStack.Depth-4], ValueStack[ValueStack.Depth-1]); }
        break;
      case 17: // decl -> VAR0, names
#line 65 "mona.y"
{ CurrentSemanticValue = MkVar0Decl(ValueStack[ValueStack.Depth-1]); }
        break;
      case 18: // decl -> VAR1, univs, vws
#line 66 "mona.y"
{ CurrentSemanticValue = MkVar1Decl(ValueStack[ValueStack.Depth-1], ValueStack[ValueStack.Depth-2]); }
        break;
      case 19: // decl -> VAR2, univs, vws
#line 67 "mona.y"
{ CurrentSemanticValue = MkVar2Decl(ValueStack[ValueStack.Depth-1], ValueStack[ValueStack.Depth-2]); }
        break;
      case 20: // decl -> TREE, univs, vws
#line 68 "mona.y"
{ CurrentSemanticValue = MkTreeDecl(ValueStack[ValueStack.Depth-1], ValueStack[ValueStack.Depth-2]); }
        break;
      case 21: // decl -> VAR1, vws
#line 69 "mona.y"
{ CurrentSemanticValue = MkVar1Decl(ValueStack[ValueStack.Depth-1]); }
        break;
      case 22: // decl -> VAR2, vws
#line 70 "mona.y"
{ CurrentSemanticValue = MkVar2Decl(ValueStack[ValueStack.Depth-1]); }
        break;
      case 23: // decl -> TREE, vws
#line 71 "mona.y"
{ CurrentSemanticValue = MkTreeDecl(ValueStack[ValueStack.Depth-1]); }
        break;
      case 24: // intterm -> LPAR, intterm, RPAR
#line 75 "mona.y"
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-2]; }
        break;
      case 25: // intterm -> intterm, PLUS, intterm
#line 76 "mona.y"
{ CurrentSemanticValue = MkArithmFuncApp(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 26: // intterm -> intterm, MINUS, intterm
#line 77 "mona.y"
{ CurrentSemanticValue = MkArithmFuncApp(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 27: // intterm -> intterm, TIMES, intterm
#line 78 "mona.y"
{ CurrentSemanticValue = MkArithmFuncApp(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 28: // intterm -> intterm, DIV, intterm
#line 79 "mona.y"
{ CurrentSemanticValue = MkArithmFuncApp(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 29: // intterm -> intterm, MOD, intterm
#line 80 "mona.y"
{ CurrentSemanticValue = MkArithmFuncApp(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 30: // intterm -> NAME
#line 81 "mona.y"
{ CurrentSemanticValue = MkConstRef(ValueStack[ValueStack.Depth-1]); }
        break;
      case 31: // intterm -> NUMBER
#line 82 "mona.y"
{ CurrentSemanticValue = MkInt(ValueStack[ValueStack.Depth-1]); }
        break;
      case 32: // univargs -> univarg, COMMA, univargs
#line 86 "mona.y"
{ CurrentSemanticValue = MkList<UnivArg>(ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 33: // univargs -> univarg
#line 87 "mona.y"
{ CurrentSemanticValue = MkList<UnivArg>(ValueStack[ValueStack.Depth-1], MkList<UnivArg>()); }
        break;
      case 34: // univarg -> NAME, COLON, NAME
#line 91 "mona.y"
{ CurrentSemanticValue = MkUnivArgWithType(ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 35: // univarg -> NAME, COLON, NUMBER
#line 92 "mona.y"
{ CurrentSemanticValue = MkUnivArgWithSucc(ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 36: // univarg -> NAME
#line 93 "mona.y"
{ CurrentSemanticValue = MkUnivArg(ValueStack[ValueStack.Depth-1]); }
        break;
      case 37: // vws -> NAME, COMMA, vws
#line 97 "mona.y"
{ CurrentSemanticValue = MkList<VarWhere>(MkVarWhere(ValueStack[ValueStack.Depth-3]), ValueStack[ValueStack.Depth-1]); }
        break;
      case 38: // vws -> NAME, WHERE, formula, COMMA, vws
#line 98 "mona.y"
{ CurrentSemanticValue = MkList<VarWhere>(MkVarWhere(ValueStack[ValueStack.Depth-5], ValueStack[ValueStack.Depth-3]), ValueStack[ValueStack.Depth-2]); }
        break;
      case 39: // vws -> NAME, WHERE, formula
#line 99 "mona.y"
{ CurrentSemanticValue = MkList<VarWhere>(MkVarWhere(ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]), MkList<VarWhere>()); }
        break;
      case 40: // vws -> NAME
#line 100 "mona.y"
{ CurrentSemanticValue = MkList<VarWhere>(MkVarWhere(ValueStack[ValueStack.Depth-1]), MkList<VarWhere>()); }
        break;
      case 41: // formula -> TRUE
#line 104 "mona.y"
{ CurrentSemanticValue = MkBooleanConstant(ValueStack[ValueStack.Depth-1]) ; }
        break;
      case 42: // formula -> FALSE
#line 105 "mona.y"
{ CurrentSemanticValue = MkBooleanConstant(ValueStack[ValueStack.Depth-1]) ; }
        break;
      case 43: // formula -> LPAR, formula, RPAR
#line 106 "mona.y"
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-2]; }
        break;
      case 44: // formula -> NOT, formula
#line 107 "mona.y"
{ CurrentSemanticValue = MkBooleanFormula(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
        break;
      case 45: // formula -> RESTRICT, LPAR, formula, RPAR
#line 108 "mona.y"
{ CurrentSemanticValue = MkRestrict(ValueStack[ValueStack.Depth-4], ValueStack[ValueStack.Depth-2]); }
        break;
      case 46: // formula -> EMPTY, LPAR, term, RPAR
#line 109 "mona.y"
{ CurrentSemanticValue = MkIsEmpty(ValueStack[ValueStack.Depth-4], ValueStack[ValueStack.Depth-2]); }
        break;
      case 47: // formula -> Q0, names, COLON, formula
#line 110 "mona.y"
{ CurrentSemanticValue = MkQ0Formula(ValueStack[ValueStack.Depth-4], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 48: // formula -> Q, univs, vws, COLON, formula
#line 111 "mona.y"
{ CurrentSemanticValue = MkQFormula(ValueStack[ValueStack.Depth-5], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1], ValueStack[ValueStack.Depth-4]); }
        break;
      case 49: // formula -> Q, vws, COLON, formula
#line 112 "mona.y"
{ CurrentSemanticValue = MkQFormula(ValueStack[ValueStack.Depth-4], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 50: // formula -> formula, AND, formula
#line 113 "mona.y"
{ CurrentSemanticValue = MkBooleanFormula(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 51: // formula -> formula, OR, formula
#line 114 "mona.y"
{ CurrentSemanticValue = MkBooleanFormula(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 52: // formula -> formula, IMPLIES, formula
#line 115 "mona.y"
{ CurrentSemanticValue = MkBooleanFormula(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 53: // formula -> formula, EQUIV, formula
#line 116 "mona.y"
{ CurrentSemanticValue = MkBooleanFormula(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 54: // formula -> term, EQ, term
#line 117 "mona.y"
{ CurrentSemanticValue = MkAtom2(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 55: // formula -> term, NE, term
#line 118 "mona.y"
{ CurrentSemanticValue = MkAtom2(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 56: // formula -> term, GT, term
#line 119 "mona.y"
{ CurrentSemanticValue = MkAtom2(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 57: // formula -> term, GE, term
#line 120 "mona.y"
{ CurrentSemanticValue = MkAtom2(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 58: // formula -> term, LT, term
#line 121 "mona.y"
{ CurrentSemanticValue = MkAtom2(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 59: // formula -> term, LE, term
#line 122 "mona.y"
{ CurrentSemanticValue = MkAtom2(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 60: // formula -> term, IN, term
#line 123 "mona.y"
{ CurrentSemanticValue = MkAtom2(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 61: // formula -> term, NOTIN, term
#line 124 "mona.y"
{ CurrentSemanticValue = MkAtom2(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 62: // formula -> term, SUBSET, term
#line 125 "mona.y"
{ CurrentSemanticValue = MkAtom2(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 63: // formula -> NAME, LPAR, exps
#line 126 "mona.y"
{ CurrentSemanticValue = MkPredApp(ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 64: // formula -> NAME
#line 127 "mona.y"
{ CurrentSemanticValue = MkBooleanVariable(ValueStack[ValueStack.Depth-1]); }
        break;
      case 71: // exps -> RPAR
#line 139 "mona.y"
{ CurrentSemanticValue = MkList<Expression>();}
        break;
      case 72: // exps -> COMMA, exp, exps
#line 140 "mona.y"
{ CurrentSemanticValue = MkList<Expression>(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]);}
        break;
      case 75: // names -> NAME, COMMA, names
#line 148 "mona.y"
{ CurrentSemanticValue = MkList<Token>(ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 76: // names -> NAME
#line 149 "mona.y"
{ CurrentSemanticValue = MkList<Token>(ValueStack[ValueStack.Depth-1], MkList<Token>()); }
        break;
      case 77: // univs -> LBRACKET, NAME, univs_
#line 153 "mona.y"
{ CurrentSemanticValue = MkList<Token>(ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-2]); }
        break;
      case 78: // univs_ -> RBRACKET
#line 156 "mona.y"
{ CurrentSemanticValue = MkList<Token>(); }
        break;
      case 79: // univs_ -> COMMA, NAME, univs_
#line 157 "mona.y"
{ CurrentSemanticValue = MkList<Token>(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
        break;
      case 80: // term -> NAME
#line 161 "mona.y"
{ CurrentSemanticValue = MkName(ValueStack[ValueStack.Depth-1]); }
        break;
      case 81: // term -> NUMBER
#line 162 "mona.y"
{ CurrentSemanticValue = MkInt(ValueStack[ValueStack.Depth-1]); }
        break;
      case 82: // term -> LPAR, term, RPAR
#line 163 "mona.y"
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-2]; }
        break;
      case 83: // term -> term, PLUS, term
#line 164 "mona.y"
{ CurrentSemanticValue = MkArithmFuncApp(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 84: // term -> term, MINUS, term
#line 165 "mona.y"
{ CurrentSemanticValue = MkArithmFuncApp(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 85: // term -> term, TIMES, term
#line 166 "mona.y"
{ CurrentSemanticValue = MkArithmFuncApp(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 86: // term -> term, DIV, term
#line 167 "mona.y"
{ CurrentSemanticValue = MkArithmFuncApp(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 87: // term -> term, MOD, term
#line 168 "mona.y"
{ CurrentSemanticValue = MkArithmFuncApp(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 88: // term -> MIN, term
#line 169 "mona.y"
{ CurrentSemanticValue = MkMinOrMax(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
        break;
      case 89: // term -> MAX, term
#line 170 "mona.y"
{ CurrentSemanticValue = MkMinOrMax(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}