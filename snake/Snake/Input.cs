using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    internal class Input
    {
        //Incarca lista cu toate butoanele folosibile
        private static Hashtable keyTable = new Hashtable();

        //Ruleaza o verificare pentru a cauta ce butoane sunt apasate
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool) keyTable[key];
        }

        //Detecteaza daca s-a apast un buton
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
