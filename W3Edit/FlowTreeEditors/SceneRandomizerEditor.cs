using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W.Types;
using W3Edit.CR2W;

namespace W3Edit.FlowTreeEditors
{
    public partial class SceneRandomizerEditor : ChunkEditor
    {
        public SceneRandomizerEditor()
        {
            InitializeComponent();
        }

        public override List<CPtr> GetConnections()
        {
            var list = new List<CPtr>();

            var choiceLinesObj = Chunk.GetVariableByName("outputs");
            if (choiceLinesObj != null && choiceLinesObj is CArray)
            {
                var choiceLines = ((CArray)choiceLinesObj);
                foreach (var choice in choiceLines)
                {
                    if (choice != null && choice is CPtr)
                    {
                        var choicePtr = (CPtr)choice;
                        //if (choicePtr.PtrTarget != null)
                        //{
                        //    var nextLinkElementObj = choicePtr.PtrTarget.GetVariableByName("nextLinkElement");
                        //    if (nextLinkElementObj != null && nextLinkElementObj is CPtr)
                        //    {
                        //        var nextLinkElement = (CPtr)nextLinkElementObj;
                        //        if (nextLinkElement.PtrTarget != null)
                        //        {
                        //            list.Add(nextLinkElement);
                        //        }
                        //    }
                        //}
                        list.Add(choicePtr);
                    }
                }
            }

            return list;
        }

        public override void UpdateView()
        {
            base.UpdateView();

            var y = 21;

            var line = 0;

            var sceneElementsObj = Chunk.GetVariableByName("outputs");
            if (sceneElementsObj != null && sceneElementsObj is CArray)
            {
                var sceneElements = (CArray)sceneElementsObj;
                foreach (var element in sceneElements)
                {
                    if (element != null && element is CPtr)
                    {
                        var ptr = (CPtr)element;
                        switch (ptr.PtrTargetType)
                        {
                            default:
                                var label = new Label()
                                {
                                    Width = Width,
                                    Height = 20,
                                    Location = new Point(0, y),
                                    TextAlign = ContentAlignment.TopRight,
                                    AutoSize = false,
                                    Text = line.ToString(),
                                };
                                label.Click += delegate(object sender, EventArgs e)
                                {
                                    FireSelectEvent(ptr.PtrTarget);
                                };
                                Controls.Add(label);
                                line++;

                                y += label.Height;
                            
                                break;
                        }
                    }
                }
            }

            Height = y;
        }

        public override Point GetConnectionLocation(int i)
        {
            return new Point(0, i * 20 + 21 + 10);
        }
    }
}
