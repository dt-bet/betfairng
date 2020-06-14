using BetfairNG.Resources;
using System.IO;

namespace BetfairNG
{
    public class EventTypes
    {
        public static Stream EventTypesStream()
        {
            return GenerateStreamFromString(Resource1.EventTypes);
        }

        static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

    }
}
