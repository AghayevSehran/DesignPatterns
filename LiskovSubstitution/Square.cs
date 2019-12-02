namespace LiskovSubstitution
{
    internal class Square : Rectangle
    {
        //Method hiding that   violate The Liskov
        //
        public override int Width
        {
            set => base.Width = base.Height = value;
        }
        //Method hiding that violate The Liskov
        public  override int Height
        {
            set => base.Width = base.Height = value;
        }
    }
}
