using Colorful;
namespace ExtConsole
{
    internal class FigletFontSolver
    {
        /// <summary>
        /// Encontra e retorna a fonte especificada.
        /// </summary>
        /// <param name="font">Fonte Figlet a ser encontrada</param>
        static public FigletFont SolveFont(FgltFonts font)
        {
            var fontResult = FigletFont.Load(Matchfont(font));

            byte[] Matchfont(FgltFonts fontToMatch)
            {
                switch (font)
                {
                    case FgltFonts.acrobatic: return FigletFonts.acrobatic;
                    case FgltFonts.alligator: return FigletFonts.alligator;
                    case FgltFonts.alligator2: return FigletFonts.alligator2;
                    case FgltFonts.alphabet: return FigletFonts.alphabet;
                    case FgltFonts.avatar: return FigletFonts.avatar;
                    case FgltFonts.banner: return FigletFonts.banner;
                    case FgltFonts.banner3: return FigletFonts.banner3;
                    case FgltFonts.banner3D: return FigletFonts.banner3_D;
                    case FgltFonts.banner4: return FigletFonts.banner4;
                    case FgltFonts.barbwire: return FigletFonts.barbwire;
                    case FgltFonts.basic: return FigletFonts.basic;
                    case FgltFonts._3d: return FigletFonts._3_d;
                    case FgltFonts._3x5: return FigletFonts._3x5;
                    case FgltFonts._5lineoblique: return FigletFonts._5lineoblique;
                    case FgltFonts.bell: return FigletFonts.bell;
                    case FgltFonts.big: return FigletFonts.big;
                    case FgltFonts.bigchief: return FigletFonts.bigchief;
                    case FgltFonts.binary: return FigletFonts.binary;
                    case FgltFonts.block: return FigletFonts.block;
                    case FgltFonts.bubble: return FigletFonts.bubble;
                    case FgltFonts.bulbhead: return FigletFonts.bulbhead;
                    case FgltFonts.calgphy2: return FigletFonts.calgphy2;
                    case FgltFonts.caligraphy: return FigletFonts.caligraphy;
                    case FgltFonts.catwalk: return FigletFonts.catwalk;
                    case FgltFonts.chunky: return FigletFonts.chunky;
                    case FgltFonts.coinstak: return FigletFonts.coinstak;
                    case FgltFonts.colossal: return FigletFonts.colossal;
                    case FgltFonts.computer: return FigletFonts.computer;
                    case FgltFonts.contessa: return FigletFonts.contessa;
                    case FgltFonts.contrast: return FigletFonts.contrast;
                    case FgltFonts.cosmic: return FigletFonts.cosmic;
                    case FgltFonts.cosmike: return FigletFonts.cosmike;
                    case FgltFonts.cricket: return FigletFonts.cricket;
                    case FgltFonts.cursive: return FigletFonts.cursive;
                    case FgltFonts.cyberlarge: return FigletFonts.cyberlarge;
                    case FgltFonts.cybermedium: return FigletFonts.cybermedium;
                    case FgltFonts.cybersmall: return FigletFonts.cybersmall;
                    case FgltFonts.diamond: return FigletFonts.diamond;
                    case FgltFonts.digital: return FigletFonts.digital;
                    case FgltFonts.doh: return FigletFonts.doh;
                    case FgltFonts.doom: return FigletFonts.doom;
                    case FgltFonts.dotmatrix: return FigletFonts.dotmatrix;
                    case FgltFonts.drpepper: return FigletFonts.drpepper;
                    case FgltFonts.eftichess: return FigletFonts.eftichess;
                    case FgltFonts.eftifont: return FigletFonts.eftifont;
                    case FgltFonts.eftipiti: return FigletFonts.eftipiti;
                    case FgltFonts.eftirobot: return FigletFonts.eftirobot;
                    case FgltFonts.eftitalic: return FigletFonts.eftitalic;
                    case FgltFonts.eftiwall: return FigletFonts.eftiwall;
                    case FgltFonts.eftiwater: return FigletFonts.eftiwater;
                    case FgltFonts.epic: return FigletFonts.epic;
                    case FgltFonts.fender: return FigletFonts.fender;
                    case FgltFonts.fourtops: return FigletFonts.fourtops;
                    case FgltFonts.fuzzy: return FigletFonts.fuzzy;
                    case FgltFonts.goofy: return FigletFonts.goofy;
                    case FgltFonts.gothic: return FigletFonts.gothic;
                    case FgltFonts.graffiti: return FigletFonts.graffiti;
                    case FgltFonts.hollywood: return FigletFonts.hollywood;
                    case FgltFonts.invita: return FigletFonts.invita;
                    case FgltFonts.isometric1: return FigletFonts.isometric1;
                    case FgltFonts.isometric2: return FigletFonts.isometric2;
                    case FgltFonts.isometric3: return FigletFonts.isometric3;
                    case FgltFonts.isometric4: return FigletFonts.isometric4;
                    case FgltFonts.italic: return FigletFonts.italic;
                    case FgltFonts.ivrit: return FigletFonts.ivrit;
                    case FgltFonts.jazmine: return FigletFonts.jazmine;
                    case FgltFonts.jerusalem: return FigletFonts.jerusalem;
                    case FgltFonts.katakana: return FigletFonts.katakana;
                    case FgltFonts.kban: return FigletFonts.kban;
                    case FgltFonts.larry3d: return FigletFonts.larry3d;
                    case FgltFonts.lcd: return FigletFonts.lcd;
                    case FgltFonts.lean: return FigletFonts.lean;
                    case FgltFonts.letters: return FigletFonts.letters;
                    case FgltFonts.linux: return FigletFonts.linux;
                    case FgltFonts.lockergnome: return FigletFonts.lockergnome;
                    case FgltFonts.madrid: return FigletFonts.madrid;
                    case FgltFonts.marquee: return FigletFonts.marquee;
                    case FgltFonts.maxfour: return FigletFonts.maxfour;
                    case FgltFonts.mike: return FigletFonts.mike;
                    case FgltFonts.mini: return FigletFonts.mini;
                    case FgltFonts.mirror: return FigletFonts.mirror;
                    case FgltFonts.mnemonic: return FigletFonts.mnemonic;
                    case FgltFonts.morse: return FigletFonts.morse;
                    case FgltFonts.moscow: return FigletFonts.moscow;
                    case FgltFonts.nancyj_fancy: return FigletFonts.nancyj_fancy;
                    case FgltFonts.nancyj_underlined: return FigletFonts.nancyj_underlined;
                    case FgltFonts.nancyj: return FigletFonts.nancyj;
                    case FgltFonts.nipples: return FigletFonts.nipples;
                    case FgltFonts.ntgreek: return FigletFonts.ntgreek;
                    case FgltFonts.o8: return FigletFonts.o8;
                    case FgltFonts.ogre: return FigletFonts.ogre;
                    case FgltFonts.pawp: return FigletFonts.pawp;
                    case FgltFonts.peaks: return FigletFonts.peaks;
                    case FgltFonts.pebbles: return FigletFonts.pebbles;
                    case FgltFonts.poison: return FigletFonts.poison;
                    case FgltFonts.puffy: return FigletFonts.puffy;
                    case FgltFonts.pyramid: return FigletFonts.pyramid;
                    case FgltFonts.rectangles: return FigletFonts.rectangles;
                    case FgltFonts.relief: return FigletFonts.relief;
                    case FgltFonts.relief2: return FigletFonts.relief2;
                    case FgltFonts.rev: return FigletFonts.rev;
                    case FgltFonts.roman: return FigletFonts.roman;
                    case FgltFonts.rot13: return FigletFonts.rot13;
                    case FgltFonts.rounded: return FigletFonts.rounded;
                    case FgltFonts.rowancap: return FigletFonts.rowancap;
                    case FgltFonts.rozzo: return FigletFonts.rozzo;
                    case FgltFonts.runic: return FigletFonts.runic;
                    case FgltFonts.runyc: return FigletFonts.runyc;
                    case FgltFonts.sblood: return FigletFonts.sblood;
                    case FgltFonts.script: return FigletFonts.script;
                    case FgltFonts.serifcap: return FigletFonts.serifcap;
                    case FgltFonts.shadow: return FigletFonts.shadow;
                    case FgltFonts._short: return FigletFonts._short;
                    case FgltFonts.slant: return FigletFonts.slant;
                    case FgltFonts.slide: return FigletFonts.slide;
                    case FgltFonts.slscript: return FigletFonts.slscript;
                    case FgltFonts.small: return FigletFonts.small;
                    case FgltFonts.smisome: return FigletFonts.smisome1;
                    case FgltFonts.smkeyboard: return FigletFonts.smkeyboard;
                    case FgltFonts.smscript: return FigletFonts.smscript;
                    case FgltFonts.smshadow: return FigletFonts.smshadow;
                    case FgltFonts.smslant: return FigletFonts.smslant;
                    case FgltFonts.smtengwar: return FigletFonts.smtengwar;
                    case FgltFonts.speed: return FigletFonts.speed;
                    case FgltFonts.stampatello: return FigletFonts.stampatello;
                    case FgltFonts.standard: return FigletFonts.standard;
                    case FgltFonts.starwars: return FigletFonts.starwars;
                    case FgltFonts.stellar: return FigletFonts.stellar;
                    case FgltFonts.stop: return FigletFonts.stop;
                    case FgltFonts.straight: return FigletFonts.straight;
                    case FgltFonts.tanja: return FigletFonts.tanja;
                    case FgltFonts.tengwar: return FigletFonts.tengwar;
                    case FgltFonts.term: return FigletFonts.term;
                    case FgltFonts.thick: return FigletFonts.thick;
                    case FgltFonts.thin: return FigletFonts.thin;
                    case FgltFonts.threepoint: return FigletFonts.threepoint;
                    case FgltFonts.ticks: return FigletFonts.ticks;
                    case FgltFonts.ticksslant: return FigletFonts.ticksslant;
                    case FgltFonts.tinker_toy: return FigletFonts.tinker_toy;
                    case FgltFonts.tombstone: return FigletFonts.tombstone;
                    case FgltFonts.trek: return FigletFonts.trek;
                    case FgltFonts.tsalagi: return FigletFonts.tsalagi;
                    case FgltFonts.twopoint: return FigletFonts.twopoint;
                    case FgltFonts.univers: return FigletFonts.univers;
                    case FgltFonts.usaflag: return FigletFonts.usaflag;
                    case FgltFonts.wavy: return FigletFonts.wavy;
                    case FgltFonts.weird: return FigletFonts.weird;
                    default: return null;
                }
            }

            return fontResult;
        }
    }
}
