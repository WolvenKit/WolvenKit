using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    class CFoliageResource : CVector
    {
        public CArray Trees;

        public CArray Grasses;

        public CFoliageResource(CR2WFile cr2w) : base(cr2w)
        {
            Trees = new CArray(cr2w)
            {
                Name = "Trees"
            };
            Grasses = new CArray(cr2w)
            {
                Name = "Grasses"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            var count = file.ReadVLQInt32();
            //For each of the treetypes
            for(int j = 0;j < count;j++)
            {
                CArray CTreeCollection = new CArray(cr2w);
                //Read the handle of the trees we are currently reading
                CHandle treetype = new CHandle(cr2w);
                treetype.Read(file, size);
                treetype.Name = "";
                CTreeCollection.AddVariable(treetype);
                //Read the number of trees in this treetype
                var treecount = file.ReadVLQInt32();
                //For each of the trees in the treetype
                for (int i = 0; i < treecount; i++)
                {
                    SFoliageInstance tree = new SFoliageInstance(cr2w)
                    {
                        Name = "Details"
                    };
                    tree.Read(file, size);
                    //Add the tree entry to its handle holder
                    CTreeCollection.AddVariable(tree);
                    tree.Name = i.ToString();
                }
                //Add the handle and the tree subvars into the Trees CArray
                Trees.AddVariable(CTreeCollection);
            }
            //Read Grasses!
            count = file.ReadVLQInt32();
            if (count > 0)
            {
                for(int j = 0;j < count;j++)
                {
                    CArray GrassCollection = new CArray(cr2w);
                    //Read the handle of the Grasses we are currently reading
                    CHandle treetype = new CHandle(cr2w);
                    treetype.Read(file, size);
                    treetype.Name = "";
                    GrassCollection.AddVariable(treetype);
                    //Read the number of Grasses in this treetype
                    var treecount = file.ReadVLQInt32();
                    //For each of the Grasses in the treetype
                    for (int i = 0; i < treecount; i++)
                    {
                        SFoliageInstance grass = new SFoliageInstance(cr2w)
                        {
                            Name = "Details"
                        };
                        grass.Read(file, size);
                        //Add the grass entry to its handle holder
                        GrassCollection.AddVariable(grass);
                        grass.Name = i.ToString();
                    }
                    //Add the handle and the grass subvars into the grasses CArray
                    Grasses.AddVariable(GrassCollection);
                }
            }
            else
            {
                return;
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            if (Trees.Any())
            {
                file.WriteVLQInt32(Trees.array.Count);
                foreach (var t in Trees.array)
                {
                    var currtreetype = (CArray)t;
                    ((CHandle)currtreetype.array[0]).Write(file); //The type of the tree
                    if (currtreetype.array.Count - 1 == 0)
                        file.Write((byte)0x80);
                    else
                        file.WriteVLQInt32(currtreetype.array.Count - 1);
                    for (int i = 1; i < currtreetype.array.Count; i++) //Start from 1 since the 0th elementh is the type
                    {
                        currtreetype.array[i].Write(file);
                    }
                }
            }
            else
                file.Write((byte)0x80);

            if (Grasses.Any())
            {
                file.WriteVLQInt32(Grasses.Count());
                foreach (var t in Grasses.array)
                {
                    var currtreetype = (CArray)t;
                    ((CHandle)currtreetype.array[0]).Write(file); //The type of the Grass
                    if (currtreetype.array.Count - 1 == 0)
                        file.Write((byte)0x80);
                    else
                        file.WriteVLQInt32(currtreetype.array.Count - 1);
                    for (int i = 1; i < currtreetype.array.Count; i++) //Start from 1 since the 0th elementh is the type
                    {
                        currtreetype.array[i].Write(file);
                    }
                }
            }
            else
                file.Write((byte)0x80);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CFoliageResource(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CFoliageResource)base.Copy(context);
            var.Trees = (CArray)Trees.Copy(context);
            var.Grasses = (CArray)Grasses.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables) { Trees, Grasses };
            return list;
        }


    }
}