using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.FlowTreeEditors
{
    public partial class SceneChoiceEditor : ChunkEditor
    {
        public SceneChoiceEditor()
        {
            InitializeComponent();
        }

        public override List<IPtrAccessor> GetConnections()
        {
            var list = new List<IPtrAccessor>();
            CStorySceneChoice sceneChoice = (CStorySceneChoice)Chunk.data;

            CArray<CPtr<CStorySceneChoiceLine>> choiceLines = sceneChoice.ChoiceLines;
            if (choiceLines != null)
            {
                foreach (var choice in choiceLines.Elements)
                {
                    if (choice != null)
                    {
                        if (choice.Reference != null)
                        {
                            CPtr<CStorySceneLinkElement> nextLinkElementObj = (choice.Reference.data as CStorySceneChoiceLine).NextLinkElement;
                            if (nextLinkElementObj != null)
                            {
                                if (nextLinkElementObj.Reference != null)
                                {
                                    list.Add(nextLinkElementObj);
                                }
                            }
                        }
                    }
                }
            }

            return list;
        }

        public override void UpdateView()
        {
            base.UpdateView();

            var y = 21;

            CArray<CPtr<CStorySceneChoiceLine>> sceneElements = (Chunk.data as CStorySceneChoice).ChoiceLines;
            if (sceneElements != null)
            {
                foreach (var element in sceneElements.Elements)
                {
                    if (element != null)
                    {
                        switch (element.GetPtrTargetType())
                        {
                            case "CStorySceneChoiceLine":
                                var choiceLine = (element.Reference.data as CStorySceneChoiceLine).ChoiceLine;

                                var label = new Label
                                {
                                    Width = Width,
                                    Height = 20,
                                    Location = new Point(0, y),
                                    AutoEllipsis = true,
                                    AutoSize = false,
                                    Text = choiceLine != null ? choiceLine.ToString() : "missing choiceLine"
                                };
                                label.Click += delegate { FireSelectEvent(element.Reference); };
                                Controls.Add(label);

                                y += label.Height;
                                break;

                            default:
                                break;
                        }
                    }
                }
            }

            Height = y;
        }

        public override Point GetConnectionLocation(int i)
        {
            return new Point(0, i*20 + 21 + 10);
        }
    }
}