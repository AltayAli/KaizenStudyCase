using KaizenCase.Models;
using Newtonsoft.Json;

namespace KaizenCase.HelperModels
{
    public class OCRHelper
    {
        private const int verticeIndex = 0;
        private const int defaultOffset = 20;

        public Dictionary<int, string> GetResponseDictionary(string response)
        {
         Dictionary<int, string> fileContent = new();
         Response[] responseArray = GetResponse(response);
            for (int i = 1; i < responseArray.Length; i++)
            {
                int? key = fileContent.Keys.FirstOrDefault(x => x > responseArray[i].BoundingPoly.Vertices[verticeIndex].YPos - defaultOffset);
                if (key.HasValue && key.Value>0)
                {
                    fileContent[key.Value] = fileContent[key.Value] + " " + responseArray[i].Description;
                }
                else
                {
                    fileContent.Add(responseArray[i].BoundingPoly.Vertices[verticeIndex].YPos, responseArray[i].Description);
                }
            }

            return fileContent;
        }

        private Response[] GetResponse(string response)
        {
            try
            {
                Response[]? responseArray = JsonConvert.DeserializeObject<Response[]>(response);
                if (response == null)
                    return Array.Empty<Response>();

                return responseArray;
            }
            catch
            {
                return Array.Empty<Response>();
            }
        }
    }
}
