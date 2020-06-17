using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.FlowTreeEditors
{
    public partial class SceneSectionEditor : SceneLinkEditor
    {
        private List<Label> lines;

        public SceneSectionEditor()
        {
            InitializeComponent();
        }

        public override void UpdateView()
        {
            base.UpdateView();

            if (lines != null)
            {
                foreach (var l in lines)
                {
                    Controls.Remove(l);
                }
            }

            lines = new List<Label>();

            var y = 21;
            var line = 0;

            CStorySceneSection sceneSection = (CStorySceneSection)Chunk.data;

            CArray<CPtr<CStorySceneElement>> sceneElements = sceneSection.SceneElements;
            if (sceneElements != null)
            {
                foreach (CPtr<CStorySceneElement> element in sceneElements.elements)
                {
                    if (element != null)
                    {
                        switch (element.GetPtrTargetType())
                        {
                            case "CStorySceneLine":
                                line++;
                                var label = new Label
                                {
                                    Width = Width,
                                    Height = 20,
                                    Location = new Point(0, y),
                                    AutoSize = false,
                                    Text = GetDisplayString((CStorySceneLine)element.Reference.data)
                                };
                                lines.Add(label);
                                Controls.Add(label);

                                var texts = TextRenderer.MeasureText(label.Text, label.Font, new Size(Width - 6, 100),
                                    TextFormatFlags.WordBreak);
                                label.Height = texts.Height + 5;
                                label.BackColor = (line % 2) == 0 ? Color.LightBlue : Color.Transparent;

                                label.Click += delegate { FireSelectEvent(element.Reference); };

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

        private string GetDisplayString(CStorySceneLine storySceneLine)
        {
            var str = "";
            if (storySceneLine != null)
            {
                var speaker = storySceneLine.Voicetag;
                if (speaker != null && speaker is CName)
                {
                    str += ((CName)speaker).Value + ": ";
                }

                var line = storySceneLine.DialogLine;
                if (line != null && line is LocalizedString)
                {
                    str += ((LocalizedString)line).Text;
                }
            }

            return str;
        }

        public override List<IPtrAccessor> GetConnections()
        {
            var list = new List<IPtrAccessor>();
            CStorySceneSection sceneSection = (CStorySceneSection)Chunk.data;

            CPtr<CStorySceneChoice> choiceObj = sceneSection.Choice;
            if (choiceObj != null)
            {
                if (choiceObj.Reference != null)
                {
                    list.Add(choiceObj);
                }
            }

            CPtr<CStorySceneLinkElement> nextLinkElementObj = sceneSection.NextLinkElement;
            if (nextLinkElementObj != null)
            {
                if (nextLinkElementObj.Reference != null)
                {
                    list.Add(nextLinkElementObj);
                }
            }

            return list;
        }

        public override string GetCopyText()
        {
            var text = new StringBuilder();
            foreach (var line in lines)
            {
                text.AppendLine(line.Text);
            }

            return text.ToString();
        }
    }
}