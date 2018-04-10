using System;
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
            Trees = new CArray("CTrees",cr2w);
            Trees.Name = "Trees";
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            CDynamicInt count = new CDynamicInt(cr2w);
            count.Read(file,1);
            //For each of the treetypes
            for(int j = 0;j < count.val;j++)
            {
                //Read the handle of the trees we are currently reading
                CHandle treetype = new CHandle(cr2w);
                treetype.Read(file, 4);
                //Read the number of trees in this treetype
                CDynamicInt treecount = new CDynamicInt(cr2w);
                treecount.Read(file,1);
                //For each of the trees in the treetype
                for (int i = 0; i < treecount.val; i++)
                {
                    CTree tree = new CTree(cr2w);
                    tree.Read(file, 29);
                    //Add the tree entry to its handle holder
                    treetype.AddVariable(tree); //BUG: If we add this to a CHandle it won't be editable.
                    tree.Name = i.ToString();
                }
                //Add the handle and the tree subvars into the Trees CArray
                Trees.AddVariable(treetype);
            }
            file.BaseStream.Seek(1, SeekOrigin.Current);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            
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
