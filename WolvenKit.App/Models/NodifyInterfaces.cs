using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WolvenKit.Functionality.Interfaces
{
    public interface INode
    {
        public Point Location { get; set; }

        public IList<INodeSocket> Inputs { get; set; }

        public IList<INodeSocket> Outputs { get; set; }
    }

    public interface INode<T> : INode where T : INodeSocket
    {
        public new IList<T> Inputs { get; set; }

        public new IList<T> Outputs { get; set; }

        IList<INodeSocket> INode.Inputs
        {
            get => Inputs.Cast<INodeSocket>().ToList();
            set => Inputs = value.Cast<T>().ToList();
        }

        IList<INodeSocket> INode.Outputs
        {
            get => Outputs.Cast<INodeSocket>().ToList();
            set => Outputs = value.Cast<T>().ToList();
        }
    }

    public interface INodeSocket
    {
        public Point Anchor { get; set; }
    }

    public interface INodeSocket<T> : INodeSocket where T : INode
    {
        public T? Node { get; set; }
    }

    public interface INodeConnection
    {
        public INodeSocket Destination { get; set; }

        public INodeSocket Source { get; set; }
    }

    public interface INodeConnection<T> : INodeConnection where T : INodeSocket
    {
        public new T Destination { get; set; }

        public new T Source { get; set; }

        INodeSocket INodeConnection.Destination
        {
            get => Destination;
            set => Destination = (T)value;
        }

        INodeSocket INodeConnection.Source
        {
            get => Source;
            set => Source = (T)value;
        }
    }
}
