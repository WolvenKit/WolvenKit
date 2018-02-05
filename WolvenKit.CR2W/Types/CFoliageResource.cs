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
            for(int j = 0;j < count.val;j++)
            {
                CArray currenttreebundle = new CArray(cr2w);
                CHandle treetype = new CHandle(cr2w);
                treetype.Read(file, 4);
                currenttreebundle.Name = treetype.Handle;
                CArray currentTrees = new CArray(cr2w);
                currentTrees.AddVariable(treetype);
                CDynamicInt treecount = new CDynamicInt(cr2w);
                treecount.Read(file,1);
                for (int i = 0; i < treecount.val; i++)
                {
                    CTree tree = new CTree(cr2w);
                    tree.Read(file, 29);
                    currentTrees.AddVariable(tree);
                }
                currenttreebundle.AddVariable(currentTrees);
                Trees.AddVariable(currenttreebundle);
            }
            file.BaseStream.Seek(1, SeekOrigin.Current);
        }

        public override void Write(BinaryWriter file)
        {
            throw new NotImplementedException();//TODO: Figure out a proper way to write this.
            base.Write(file);
            var count = new CDynamicInt(cr2w);
            count.val = Trees.Count();
            for (int i = 0; i < count.val; i++)
            {
                   
            }
            file.Write(0x80); //END
        }

        public override CVariable SetValue(object val)
        {
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
