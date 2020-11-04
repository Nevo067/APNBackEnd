namespace WebApplication.Model
{
    public class Objet
    {
        public int ObjetId { get; set; }
        public string nom { get; set; }
        public string val { get; set; }
        
        public int CharaId { get; set; }
        public Chara chara { get; set; }

        public override string ToString()
        {
            return $"{nameof(ObjetId)}: {ObjetId}, {nameof(nom)}: {nom}, {nameof(val)}: {val}, {nameof(CharaId)}: {CharaId}, {nameof(chara)}: {chara}";
        }
    }
}