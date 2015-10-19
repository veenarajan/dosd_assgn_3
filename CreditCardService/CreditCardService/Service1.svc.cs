using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CreditCardService
{
    public enum CardType
    {
        MasterCard, Visa, AmericanExpress, Discover
    };

    public class Service1 : IService1
    {
       
        public bool creditcardvalidation(CardType card, string ip_card_number)
        {
            byte[] cardno = new byte[16];
            int check_len = 0;

            if (string.IsNullOrEmpty(ip_card_number))
            {
                return false;
            }

            for (int i = 0; i < ip_card_number.Length; i++)
            {
                if (char.IsDigit(ip_card_number,i))
                {
                    if (check_len == 16)
                        return false;
                    cardno[check_len++] = byte.Parse(Convert.ToString(ip_card_number[i]));
                }
            }

            switch (card)
            {
                case CardType.MasterCard:
                    if (check_len!=16)
                    {
                        return false;
                    }
                    if (cardno[0] != 5 || cardno[1] == 0 || cardno[1] > 5)
                    {
                        return false;
                    }
                    break;

                case CardType.Visa:
                    if (check_len!=16 && check_len!=13)
                    {
                        return false;
                    }
                    if (cardno[0]!=4 )
                    {
                        return false;
                    }
                    break;

                case CardType.AmericanExpress:
                    if (check_len!=15)
                    {
                        return false;
                    }
                    if (cardno[0] != 3 || (cardno[1] != 4 && cardno[1] != 7))
                    {
                        return false;
                    }
                    break;

                case CardType.Discover:
                    if (check_len != 16)
                    {
                        return false;
                    }

                    if (cardno[0] != 6 || cardno[1] != 0 || cardno[2] != 1 || cardno[3] != 1)
                    {
                        return false;
                    }
                    break;
            }

            int sum  = ip_card_number.Where((number) => number >= '0' && number <='9').Reverse().Select((number,i) => ((int) number - 48) * (i%2 ==0 ? 1 : 2)).Sum((number) => number / 10 + number % 10);

            return sum % 10 == 0;
            
        }
            
    }
}

