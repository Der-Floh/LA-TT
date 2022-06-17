using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LA_TT
{
    public class JsonHandler
    {
        public async Task WriteCCards(List<CCard> ccards, bool your, byte rarity)
        {
            string yourString = "";
            if (your) yourString = "Y";

            string rareString = "";
            switch (rarity)
            {
                case 1: rareString = "B"; break;
                case 2: rareString = "S"; break;
                case 3: rareString = "G"; break;
                case 4: rareString = "D"; break;
                case 5: rareString = "O"; break;
            }

            string fileName = @"Resources/"+ yourString +"CCards"+ rareString +".json";

            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            using FileStream createStream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(createStream, ccards, jsonOptions);
            await createStream.DisposeAsync();
        }
        public async Task WriteFCards(List<FCard> fcards, bool your, byte rarity)
        {
            string yourString = "";
            if (your) yourString = "Y";

            string rareString = "";
            switch (rarity)
            {
                case 1: rareString = "B"; break;
                case 2: rareString = "S"; break;
                case 3: rareString = "G"; break;
                case 4: rareString = "D"; break;
                case 5: rareString = "O"; break;
            }

            string fileName = @"Resources/"+ yourString +"FCards"+ rareString +".json";

            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            using FileStream createStream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(createStream, fcards, jsonOptions);
            await createStream.DisposeAsync();
        }

        public async Task<List<CCard>> GetCCards(bool your, byte rarity)
        {
            string yourString = "";
            if (your) yourString = "Y";

            string rareString = "";
            switch (rarity)
            {
                case 1: rareString = "B"; break;
                case 2: rareString = "S"; break;
                case 3: rareString = "G"; break;
                case 4: rareString = "D"; break;
                case 5: rareString = "O"; break;
            }

            string fileName = @"Resources/"+ yourString +"CCards"+ rareString +".json";
            if (File.Exists(fileName))
            {
                using FileStream openStream = File.OpenRead(fileName);
                List<CCard> ccards = await JsonSerializer.DeserializeAsync<List<CCard>>(openStream);
                await openStream.DisposeAsync();
                return ccards;
            }
            else
            {
                //MessageBox.Show("Failed to Load: "+ yourString +"CCards"+ rareString +".json", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public async Task<List<FCard>> GetFCards(bool your, byte rarity)
        {
            string yourString = "";
            if (your) yourString = "Y";

            string rareString = "";
            switch (rarity)
            {
                case 1: rareString = "B"; break;
                case 2: rareString = "S"; break;
                case 3: rareString = "G"; break;
                case 4: rareString = "D"; break;
                case 5: rareString = "O"; break;
            }

            string fileName = @"Resources/"+ yourString +"FCards"+ rareString +".json";
            if (File.Exists(fileName))
            {
                using FileStream openStream = File.OpenRead(fileName);
                List<FCard> fcards = await JsonSerializer.DeserializeAsync<List<FCard>>(openStream);
                await openStream.DisposeAsync();
                return fcards;
            }
            else
            {
                //MessageBox.Show("Failed to Load: " + yourString + "FCards" + rareString + ".json", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public async Task WriteSettings(Settings settings)
        {
            string fileName = @"Resources/config.json";

            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            using FileStream createStream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(createStream, settings, jsonOptions);
            await createStream.DisposeAsync();
        }

        public Settings GetSettings()
        {
            string fileName = @"Resources/config.json";
            if (File.Exists(fileName))
            {
                using FileStream openStream = File.OpenRead(fileName);
                Settings settings = JsonSerializer.Deserialize<Settings>(openStream);
                openStream.Dispose();
                return settings;
            }
            return null;
        }

        public async Task DeleteHtmlFiles()
        {
            DirectoryInfo directory = new DirectoryInfo("Resources/Html");
            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Name == "create") continue;
                file.Delete();
            }

            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}
