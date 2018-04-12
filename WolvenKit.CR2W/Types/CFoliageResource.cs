using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.GameEntity;

namespace WolvenKit.CR2W.Types
{
    class CFoliageResource : CVector
    {
        public CArray Trees;

        public CFoliageResource(CR2WFile cr2w) : base(cr2w)
        {
            Trees = new CArray("array:2,0,CTree",cr2w);
            Trees.Name = "Trees";
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            var count = file.ReadByte();
            //For each of the treetypes
            for(int j = 0;j < count;j++)
            {
                CArray CTreeCollection = new CArray("CTree",cr2w);
                //Read the handle of the trees we are currently reading
                CHandle treetype = new CHandle(cr2w);
                treetype.Read(file, 4);
                treetype.Name = "Type";
                CTreeCollection.AddVariable(treetype);
                //Read the number of trees in this treetype
                var treecount = file.ReadByte();
                //For each of the trees in the treetype
                for (int i = 0; i < treecount; i++)
                {
                    CTree tree = new CTree(cr2w);
                    tree.Read(file, 29);
                    //Add the tree entry to its handle holder
                    CTreeCollection.AddVariable(tree);
                    tree.Name = i.ToString();
                }
                //Add the handle and the tree subvars into the Trees CArray
                Trees.AddVariable(CTreeCollection);
            }
            file.BaseStream.Seek(1, SeekOrigin.Current); //END MARK
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            file.Write((byte)(Trees.array.Count));
            for (int j = 0; j < Trees.array.Count; j++)
            {
                var currtreetype = (CArray)Trees.array[j]; //The current treetype CArray
                ((CHandle)currtreetype.array[0]).Write(file);
                file.Write((byte)(currtreetype.array.Count-1));
                for (int i = 1; i < currtreetype.array.Count;i++)
                {
                    var currtree = currtreetype.array[i]; //The current tree
                    currtree.Write(file);
                }
            }
            file.Write((byte)0x80); //END MARK
        }

        public override CVariable SetValue(object val)
        {
            if (val is CArray)
            {
                Trees = (CArray) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CFoliageResource(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CFoliageResource)base.Copy(context);
            var.Trees = (CArray)Trees.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables) { Trees };
            return list;
        }


    }
}
