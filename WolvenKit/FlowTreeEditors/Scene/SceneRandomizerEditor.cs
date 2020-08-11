using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.FlowTreeEditors
{
    public partial class SceneRandomizerEditor : ChunkEditor
    {
        public SceneRandomizerEditor()
        {
            InitializeComponent();
        }

        public override List<IPtrAccessor> GetConnections()
        {
            var list = new List<IPtrAccessor>();
            CStorySceneRandomizer resource = (CStorySceneRandomizer)Chunk.data;

            CArray<CPtr<CStorySceneLinkElement>> outputs = resource.Outputs;
            if (outputs != null)
            {
                foreach (CPtr<CStorySceneLinkElement> choice in outputs.Elements)
                {
                    if (choice != null)
                    {
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
                        list.Add(choice);
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

            CStorySceneRandomizer resource = (CStorySceneRandomizer)Chunk.data;

            CArray<CPtr<CStorySceneLinkElement>> outputs = resource.Outputs;
            if (outputs != null)
            {
                foreach (var element in outputs.Elements)
                {
                    if (element != null)
                    {
                        switch (element.GetPtrTargetType())
                        {
                            default:
                                var label = new Label
                                {
                                    Width = Width,
                                    Height = 20,
                                    Location = new Point(0, y),
                                    TextAlign = ContentAlignment.TopRight,
                                    AutoSize = false,
                                    Text = line.ToString()
                                };
                                label.Click += delegate { FireSelectEvent(element.Reference); };
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