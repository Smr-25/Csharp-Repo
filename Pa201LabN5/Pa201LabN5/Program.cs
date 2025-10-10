using Pa201LabN5;
using Pa201LabN5.Enums;

string path = "C:\\Users\\samiraa\\Desktop\\Lab\\Pa201LabN5\\Pa201LabN5\\Data\\";
if (!Directory.Exists(path))
    Directory.CreateDirectory(path);
 path += "cards.json";
if (!File.Exists(path))
    File.Create(path);

CardService cardService = new();
cardService.AddCard();