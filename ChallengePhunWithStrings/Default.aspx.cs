using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //1. Reverse your name

            string name = "James Knorr";
            /*
            string result = "";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                result += name[i];
            }

            resultLabel.Text = result;
            */


            //2. Reverse this sequence
            string names = "Luke,Leia,Han,Chewbacca";

            /*
            string[] namesArray = names.Split(',');

            string result = "";

            for (int i = namesArray.Length - 1; i >= 0; i--)
            {
                result += namesArray[i] + ",";
            }

            result = result.Remove(result.Length - 1, 1);
            resultLabel.Text = result;
            */


            //3. Use the sequence to create ascii art:

            /*
            string[] namesArray = names.Split(',');

            string result = "";

            for (int i = 0; i < namesArray.Length; i++)
            {
                int padLeft = (14 - namesArray[i].Length) / 2;
                string temp = namesArray[i].PadLeft(namesArray[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*') + "<br />";
            }

            resultLabel.Text = result;
            */

            //4. Solve This puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            int index = puzzle.IndexOf("remove-me");
            puzzle = puzzle.Remove(index,puzzle.Length - (puzzle.Length - index)-1);
            puzzle = puzzle.Replace("Z", "T");
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");


            resultLabel.Text = puzzle;


        }
    }
}