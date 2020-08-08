using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using EpForceDirectedGraph.cs;

namespace VL.ForceDirectedGraph
{
    public class EdgeBundle
    {
        public Edge edge;
        public AbstractVector from;
        public AbstractVector to;

        public EdgeBundle(Edge edge, AbstractVector from, AbstractVector to)
        {
            this.edge = edge;
            this.from = from;
            this.to = to;
        }
    }

    public class NodeBundle
    {
        public Node node;
        public AbstractVector position;

        public NodeBundle(Node node, AbstractVector position)
        {
            this.node = node;
            this.position = position;
        }
    }

    public class ListRenderer : AbstractRenderer
    {
        public List<EdgeBundle> edges;
        public List<NodeBundle> nodes;

        public ListRenderer(IForceDirected iForceDirected) : base(iForceDirected) {
            Clear();
        }

        public override void Clear()
        {
            edges = new List<EdgeBundle>();
            nodes = new List<NodeBundle>();
        }

        protected override void drawEdge(Edge iEdge, AbstractVector iPosition1, AbstractVector iPosition2)
        {
            edges.Add(new EdgeBundle(iEdge, iPosition1, iPosition2));
        }

        protected override void drawNode(Node iNode, AbstractVector iPosition)
        {
            nodes.Add(new NodeBundle(iNode, iPosition));
        }
    }
}
