using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interactivity;

namespace WolvenKit
{
    public class Behaviour : Behavior<SfDataGrid>
    {
        protected override void OnAttached()
        {
            this.AssociatedObject.SelectionController = new RowSelectionController(this.AssociatedObject);
        }
    }
}
