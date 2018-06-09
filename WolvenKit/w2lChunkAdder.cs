using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit
{

    public class w2lAdderData
    {
        public string chunkType; 
        public CHandle template;
        public CEngineTransform transform;
    }


    class w2lChunkAdder
    {
      

        //reads the file line by line and adds chunk for each line
        public List<w2lAdderData> ReadFile(CR2WFile File)
        {
            string path;
           
            List<w2lAdderData> ChunksList = new List<w2lAdderData>();

            //put this here for now
            //chunkTypes = GetGlobalChunkType();

            //open file dialogue
            var dlg = new OpenFileDialog
            {
                Title = "Open Chunk Data File",
                Filter = "Text files (*.txt)|*.txt",
                InitialDirectory = MainController.Get().Configuration.InitialModDirectory
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.FileName;

            }
            else
            {
                return ChunksList;
            }

            //read lines
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while (file.Peek() >= 0)
            {
                string str;
                string[] strArray;
                str = file.ReadLine();

                strArray = str.Split(';');

                //process only lines with the right heading e.g. '[RFEDIT]'
                if (strArray[0] != "[RFEDIT]")
                {
                    break;
                }

                w2lAdderData currentChunkData = new w2lAdderData();

                if ( strArray.Length == 9 )
                {
                    //Chunk Class (string)
                    //currentChunkData.chunkType = chunkTypes; //get it from dialogue
                    currentChunkData.chunkType = strArray[1]; //get it from file

                    //template (CHandle)
                    var template = new CHandle(File);
                    template.Type = "handle:CEntityTemplate";
                    template.Name = "template";
                    template.FileType = "CEntityTemplate";
                    template.Handle = strArray[2];
                    template.Flags = 2;

                    //transform (CEngineTransform)
                    var transform = new CEngineTransform(File);
                    transform.Type = "EngineTransform";
                    transform.Name = "transform";
                    transform.x.SetValue(float.Parse(strArray[3]));
                    transform.y.SetValue(float.Parse(strArray[4]));
                    transform.z.SetValue(float.Parse(strArray[5]));
                    transform.pitch.SetValue(float.Parse(strArray[6]));
                    transform.yaw.SetValue(float.Parse(strArray[7]));
                    transform.roll.SetValue(float.Parse(strArray[8]));

                    //store
                    currentChunkData.template = template;
                    currentChunkData.transform = transform;
                    ChunksList.Add(currentChunkData);
                }
            }

            file.Close();

            return ChunksList;
        }

        //++
        //Asks for the chunk type to add (applies to all added chunks)
        private string GetGlobalChunkType()
        {
            var dlg = new frmAddChunk();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.ChunkType;
            }
            else
            {
                return "";
            }
        }
        //--

    }
}
