using Microsoft.AspNetCore.Mvc;
using TestCodeApi.Model;

namespace TestCodeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokeController : ControllerBase
    {
        public JokeController() { }

        [HttpPost("GetListJoke")]
        public async Task<IActionResult> ListJoke()
        {
            var listJoke = new List<MJoke>();
            listJoke.Add(new MJoke { Id = 0, Content = $@"A child asked his father, ""How were people born?"" So his father said, ""Adam and Eve made babies, then their babies became adults and made babies, and so on.""The child then went to his mother,asked her the same question and she told him,""We were monkeys then we evolved to become like we are now.""The child ran back to his father and said, ""You lied to me!"" His father replied, ""No, your mom was talking about her side of the family."});
            listJoke.Add(new MJoke { Id = 1, Content = $@"Teacher: ""Kids, what does the chicken give you ? "" Student: ""Meat!"" Teacher: ""Very good! Now what does the pig give you ? "" Student: ""Bacon!"" Teacher: ""Great! And what does the fat cow give you ? "" Student: ""Homework!"""});
            listJoke.Add(new MJoke { Id = 2, Content = $@"The teacher asked Jimmy, ""Why is your cat at school today Jimmy ? "" Jimmy replied crying, ""Because I heard my daddy tell my mommy, 'I am going to eat that pussy once Jimmy leaves for school today!'"""});
            listJoke.Add(new MJoke { Id = 3, Content = $@"A housewife, an accountant and a lawyer were asked ""How much is 2 + 2 ? "" The housewife replies: ""Four!"". The accountant says: ""I think it's either 3 or 4. Let me run those figures through my spreadsheet one more time."" The lawyer pulls the drapes, dims the lights and asks in a hushed voice, ""How much do you want it to be?"""});
            return Ok(listJoke);
        }

        [HttpPost("Algorithm")]
        public async Task<IActionResult> Algorithm(int[] array)
        {
            if(array!= null && array.Length > 0)
            {
                long max = array.Sum() - array[0], min = array.Sum() - array[0];

                for (int i = 1; i < array.Length; i++)
                {

                    if (array.Sum() - array[i] > max) max = array.Sum() - array[i];

                    if (array.Sum() - array[i] < min) min = array.Sum() - array[i];

                }

                string arrEven = string.Empty;
                string arrOdd = string.Empty;
                int Count = 0;
                foreach (var item in array)
                {
                    if (item % 2 == 0)
                    {
                        arrEven += item.ToString() + " ";
                    }
                    else
                    {
                        arrOdd += item.ToString() + " ";
                    }
                    Count++;
                }
                var result = $"Count total of array {array.Length} \n";
                result += $"Value min {min} \n";
                result += $"Value max {max} \n";
                result += $"Even elements in array {arrEven} \n";
                result += $"Odd elements in array {arrOdd} \n";
                return Ok(result);
            }
            return Ok("");
        }
    }
}
