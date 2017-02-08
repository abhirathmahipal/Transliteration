using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transliteration
{
    public class Translator
    {
        string text_to_translate, text_in_target_language;
        // Dictionary for the language map

        Translator(string text, string target_lang)
        {
            // Try finding target lang without having the user to input
            // if the language map does not exist, (say Eng -> Tamil)
            // notify the user.
        }
        
        string translate()
        {
            return text_in_target_language;
        }
        
        // string detect_source_lang() 
        // bool does_map_exist()

    }
}
