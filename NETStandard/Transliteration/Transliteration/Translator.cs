using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transliteration
{
    public class Translator
    {
        Translator(string target_lang)
        {
            // Try finding source lang without having the user to input
            // if the language map does not exist, (say Eng -> Tamil)
            // notify the user.

            // right now just transliterate from English to given language
        }
        
        string translate(string text_to_translate)
        {
            return "text_in_target_language";
        }
        
        string detect_source_lang()
        {
            return "source lang";
        }

        bool does_map_exist()
        {
            return true;
        }

        /*IDictionary<int, int> get_appropriate_map()
        {
           
        }*/

    }
}
