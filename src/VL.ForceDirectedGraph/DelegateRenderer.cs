using EpForceDirectedGraph.cs;

public class DelegateRenderer : AbstractRenderer
{
    public delegate void ConstructorDelegate(IForceDirected iForceDirected);
    public delegate void ClearDelegate();
    public delegate void DrawEdgeDelegate(Edge iEdge, AbstractVector iPosition1, AbstractVector iPosition2);
    public delegate void DrawNodeDelegate(Node iNode, AbstractVector iPosition);

    public ClearDelegate clearDelegate;
    public DrawEdgeDelegate drawEdgeDelegate;
    public DrawNodeDelegate drawNodeDelegate;

    public DelegateRenderer(IForceDirected iForceDirected, ClearDelegate clearDelegate, DrawEdgeDelegate drawEdgeDelegate, DrawNodeDelegate drawNodeDelegate) : base(iForceDirected)
    {
        this.clearDelegate = clearDelegate;
        this.drawEdgeDelegate = drawEdgeDelegate;
        this.drawNodeDelegate = drawNodeDelegate;
    }

    public override void Clear()
    {
        clearDelegate();
    }

    protected override void drawEdge(Edge iEdge, AbstractVector iPosition1, AbstractVector iPosition2)
    {
        drawEdgeDelegate(iEdge, iPosition1, iPosition2);
    }

    protected override void drawNode(Node iNode, AbstractVector iPosition)
    {
        drawNodeDelegate(iNode, iPosition);
    }
}
