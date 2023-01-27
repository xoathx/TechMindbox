

namespace TechMindbox
{
    public interface ITriangle : IFigure
    {
        double EadgeA { get; }
        double EadgeB { get; }
        double EadgeC { get; }

        bool IsRightTriangle { get; }


    }
}
