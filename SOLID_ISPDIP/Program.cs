namespace SOLID_ISPDIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISPViolation.IShape[] shapes = {
                new ISPViolation.Circle(),
                new ISPViolation.Rectangle()
            };
            DrawTheShapes( shapes );

            ISP.IShape[] shapes2 = {
                new ISP.Circle(),
                new ISP.Rectangle()
            };

            DrawTheShapes(shapes2);

        private static void DrawTheShapes(ISPViolation.IShape[] shapes)
        { 
            foreach(var shape in shapes) 
            {
                shape.Draw();
                shape.GetArea();
        }

        private static void DrawTheShapes(ISP.IDrawable[] shapes)
        { 
            foreach(var shape in shapes) 
            {
                shape.Draw();
                shape.GetArea();
        }
    }
}
