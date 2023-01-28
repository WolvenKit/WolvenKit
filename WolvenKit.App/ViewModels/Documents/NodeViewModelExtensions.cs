using System.Collections.Generic;

namespace WolvenKit.ViewModels.Documents
{
    public static class NodeViewModelExtensions
    {
        public static System.Windows.Rect GetBoundingBox(this IList<NodeViewModel> nodes, double padding = 0, int gridCellSize = 15)
        {
            var minX = double.MaxValue;
            var minY = double.MaxValue;

            var maxX = double.MinValue;
            var maxY = double.MinValue;

            for (var i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];
                var width = 200;    //node.Width
                var height = 200;   //node.Height

                if (node.Location.X < minX)
                {
                    minX = node.Location.X;
                }

                if (node.Location.Y < minY)
                {
                    minY = node.Location.Y;
                }

                var sizeX = node.Location.X + width;
                if (sizeX > maxX)
                {
                    maxX = sizeX;
                }

                var sizeY = node.Location.Y + height;
                if (sizeY > maxY)
                {
                    maxY = sizeY;
                }
            }

            var result = new System.Windows.Rect(minX - padding, minY - padding, maxX - minX + (padding * 2), maxY - minY + (padding * 2));
            result.X = (int)result.X / gridCellSize * gridCellSize;
            result.Y = (int)result.Y / gridCellSize * gridCellSize;
            return result;
        }

        public static void AddRange<T>(this ICollection<T> col, IEnumerable<T> items)
        {
            if (items is IList<T> itemsCol)
            {
                for (var i = 0; i < itemsCol.Count; i++)
                {
                    col.Add(itemsCol[i]);
                }
            }
            else if (items is T[] itemsArr)
            {
                for (var i = 0; i < itemsArr.Length; i++)
                {
                    col.Add(itemsArr[i]);
                }
            }
            else
            {
                foreach (var item in items)
                {
                    col.Add(item);
                }
            }
        }
    }
}
