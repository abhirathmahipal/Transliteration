using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transliteration
{
    class English
    {
        
        // Only Hindi as of now
        const Vowels[] =
        {
            "a",    2309, 0,    // అ
            "aa",   2310, 2366, // ఆ
            "A",    2310, 2366, // ఆ
            "i",    2311, 2367, // ఇ
            "ee",   2312, 2368, // ఈ
            "ii",   2312, 2368, // ఈ
            "I",    2312, 2368, // ఈ
            "u",    2313, 2369, // ఉ
            "oo",   2314, 2370, // ఊ
            "U",    2314, 2370, // ఊ
            "zr",   0x090B, 0x0943, // ఋ
            "zl",   0x090C, 0x0962, // ఌ
            "e",    0x090D, 0X0945, // ఎ
            "E",    2319, 2375, // ఏ
            "ai",   2320, 2376, // ఐ
            "o",    0X0911, 0X0949, // ఒ
            "O",    2323, 2379, // ఓ
            "au",   2324, 2380, // ఔ
            "zR",   0x0960, 0x0944, // ౠ
            "zL",   0x0961, 0x0963, // ౡ
            "AO",   0x0901, 0x0901, // ఁ
            "M",    2306, 2306, // ం
            "H",    2307, 2307, // ః
			"OM",   2384, 2384	// ॐ
        };

        const Consonants[] =
        {
            "k",    2325,
            "K",    2325,
            "kh",    2326,
            "Kh",    2326,
            "g",    2327,
            "G",    2327,
            "gh",    2328,
            "Gh",    2328,
            "NG",    2329,
            "ch",    2330,
            "Ch",    2331,
            "j",    2332,
            "J",    2332,
            "jh",    2333,
            "Jh",    2333,
            "NY",    2334,
            "T",    2335,
            "Th",    2336,
            "d",    2337,
            "dh",    2338,
            "N",    2339,
            "t",    2340,
            "th",    2341,
            "D",    2342,
            "Dh",    2343,
            "n",    2344,
            "zN",    2345,
            "p",    2346,
            "ph",    2347,
            "f",    2347,
            "b",    2348,
            "B",    2348,
            "bh",    2349,
            "Bh",    2349,
            "m",    2350,
            "y",    2351,
            "r",    2352,
            "R",    2353,
            "l",    2354,
            "L",    2355,
            "zL",    2356,
            "v",    2357,
            "V",    2357,
            "w",    2357,
            "W",    2357,
            "sh",    2358,
            "Sh",    2359,
            "s",    2360,
            "h",    2361,
            "zk",   2392,
            "zkh",  2393,
            "zg",   2394,
            "zj",   2395,
            "zd",   2396,
            "zdh",  2397,
            "zph",  2398,
            "zy",   2399
        };

        const uHalant = 2381;   // The Unicode character code for Virama (Halant)

        const Digits[] =
        {
            "z0",    0x0966,
            "z1",    0x0967,
            "z2",    0x0968,
            "z3",    0x0969,
            "z4",    0x096A,
            "z5",    0x096B,
            "z6",    0x096C,
            "z7",    0x096D,
            "z8",    0x096E,
            "z9",    0x096F
        };

        const SpecialSymbols[] = // Currently no special Symbols, this is just dummy entry. Replace it with any actual content if needed.
		{
            "zS",   2365,
            "|",    2404,
            "||",   2405
        };



    }
}
