using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Linq;

namespace WolvenKit.CR2W.Types
{
    public class CEntity : CVector
    {
        public CArray components;
        public CUInt32 unk1;
        public CUInt32 unk2;
        public CBytes tail;

        public bool hasComponents { get; set; } = false;
        public CVector compressedComponents { get; set; }
        private bool isW2l = false;

        public CEntity(CR2WFile cr2w) :
            base(cr2w)
        {
            unk1 = new CUInt32(cr2w)
            {
                Name = "unk1"
            };
            unk2 = new CUInt32(cr2w)
            {
                Name = "unk2"
            };
            tail = new CBytes(cr2w)
            {
                Name = "tail",
            };
            compressedComponents = new CVector(cr2w)
            {
                Name = "compressedComponents"
            };

            components = new CArray("[]handle:Component", "handle:Component", true, cr2w);
            components.Name = "components";
        }

        public override void Read(BinaryReader file, uint size)
        {
            var startPos = file.BaseStream.Position;

            base.Read(file, size);

            // check for w2l
            isW2l = cr2w.chunks.FirstOrDefault().typeName.Value == "CLayer";

            unk1.Read(file, 0);
            unk2.Read(file, 0);

            // CEntities with components have a component-handle array
            // which is prefixed with a DynamicInt that stores the component count
            // this component array has a size of: 1 + (elementcount * 4) bytes
            // sometimes this dynamicInt is not present
            // HACk workaround, check if no components and if bytes left are exactly 3, 
            // then chances are, the it reads dynamicInt == 128, so no componentsarray

            var endPos = file.BaseStream.Position;
            var bytesleft = size - (endPos - startPos);
            if (bytesleft > 0)
            {
                if (hasComponents || 
                    !isW2l || 
                    (isW2l && !hasComponents && bytesleft == 3) )
                {
                    var elementcount = file.ReadBit6();
                    for (var i = 0; i < elementcount; i++)
                    {
                        var handle = new CHandle(cr2w);
                        handle.Read(file, 0);
                        components.AddVariable(handle);
                    }
                }
            }
            else
            {
                throw new EndOfStreamException("unknown CEntity Fileformat.");
            }

            // all CEntities have 2 null bytes at the end 
            endPos = file.BaseStream.Position;
            bytesleft = size - (endPos - startPos);
            if (bytesleft > 0)
            {
                tail.Bytes = file.ReadBytes(2);
            }
            else
            {
                throw new EndOfStreamException("unknown CEntity Fileformat.");
            }

            // some CEntities (in w2l files) have components stored after the null bytes in a compressed format
            
            //
            // !! FIXME handle how to deal with real unknown bytes... !!
            //
            /*
            endPos = file.BaseStream.Position;
            bytesleft = size - (endPos - startPos);
            if (bytesleft > 0 && isW2l)
            {
                // parse compressed databuffer
                //variables.Add(compressedComponents);
                UInt32 componentsCount = file.ReadUInt32();
                for (int i = 0; i < componentsCount; i++)
                {
                    var compressedComponent = new CVector(cr2w) { Name = i.ToString() };
                    
                    UInt32 componentSize = file.ReadUInt32();
                    var buffer = file.ReadBytes((int)componentSize - 4);
                    using (var ms = new MemoryStream(buffer))
                    using (var br = new BinaryReader(ms))
                    {
                        var componentName = new CName(cr2w) { Name = "componentName" };
                        componentName.Read(br, 2);
                        compressedComponent.AddVariable(componentName);

                        compressedComponents.AddVariable(compressedComponent);

                        var variablesCount = br.ReadUInt32();
                        for (int j = 0; j < variablesCount; j++)
                        {
                            compressedComponent.AddVariable(ReadCompressedVariable(br));
                        }

                        var overhang = ms.Length - ms.Position;
                        if (overhang > 0)
                            compressedComponent.AddVariable(new CByteArray(cr2w) { Bytes = br.ReadBytes((int)overhang) });
                    }
                }
            }
            */

            CVariable ReadCompressedVariable(BinaryReader br)
            {
                CVariable parsedvar = null;
                var varsize = br.ReadUInt32();
                var buffer = br.ReadBytes((int)varsize - 4);
                using (var ms = new MemoryStream(buffer))
                using (var br2 = new BinaryReader(ms))
                {

                    var typeId = br2.ReadUInt16();
                    var nameId = br2.ReadUInt16();

                    if (nameId == 0)
                    {
                        return null;
                    }

                    var typename = cr2w.names[typeId].str;
                    var varname = cr2w.names[nameId].str;

                    parsedvar = CR2WTypeManager.Get().GetByName(typename, varname, cr2w);

                    parsedvar.Read(br2, size);

                    parsedvar.nameId = nameId;
                    parsedvar.typeId = typeId;

                    // Enums are behaving weird
                    // they seem to have size 4 ( 2 for the actual Enum Cname, and 2 null bytes)
                    // however, they can come as arrays? e.g. 2 bytes first enum, 2 bytes second enum, 2 null bytes
                    // but the variable name is not an array, so I don't know what to do with them
                    // and not all enums do that (ELightUsageMask does it)
                }

                return parsedvar;
            }
        }

        public override void Write(BinaryWriter file)
        {
            //CVector compressedbuffer = variables.FirstOrDefault(_ => _.Name == "compressedComponents" ) as CVector;
            var compressedbytes = new List<byte>();
            if (compressedComponents.variables != null && compressedComponents.variables.Count > 0)
            {
                compressedbytes = ToCompressed(compressedComponents).ToList();
                variables.Remove(variables.First(_ => _.Name == "compressedComponents"));
            }
            

            base.Write(file);

            unk1.Write(file);
            unk2.Write(file);

            if (hasComponents || !isW2l)
            {
                file.WriteBit6(components.array.Count);
                for (var i = 0; i < components.array.Count; i++)
                {
                    components.array[i].Write(file);
                }
            }

            tail.Write(file);



            file.Write(compressedbytes.ToArray());


            byte[] ToCompressed(CVector var)
            {
                using (var ms = new MemoryStream())
                using (var bw = new BinaryWriter(ms))
                {
                    UInt32 componentsCount = (UInt32)var.variables.Count;
                    bw.Write(componentsCount);

                    for (int i = 0; i < componentsCount; i++)
                    {
                        CVector comp = var.variables[i] as CVector;
                        UInt32 componentSize = 4 + 2 + 4; // 4 dor the uint32 varsize, 2 for the cname, 4 for the variablescount
                        byte[] compbytes;

                        // use a temporary stream to write the variables and get the overall length of the component
                        using (var temp_ms1 = new MemoryStream())
                        using (var temp_bw1 = new BinaryWriter(temp_ms1))
                        {
                            var name = comp.variables.FirstOrDefault(_ => _.Name == "componentName") as CName;
                            UInt16 nameID = name.val;
                            temp_bw1.Write((UInt16)nameID);

                            UInt32 variablesCount = (UInt32)comp.variables.Count - 1;
                            temp_bw1.Write(variablesCount);

                            for (int j = 1; j < variablesCount; j++)
                            {
                                CVariable variable = comp.variables[j];
                                UInt32 varsize = 4 + 4; //4 for the uint32 varsize, 4 for 2 x uint16 typeID and nameID
                                byte[] varvalue;

                                // use a temporary stream to write the variable and get the length of the variable
                                using (var temp_ms2 = new MemoryStream())
                                using (var temp_bw2 = new BinaryWriter(temp_ms2))
                                {
                                    variable.Write(temp_bw2);
                                    varsize += (UInt32)temp_ms2.Length;
                                    varvalue = temp_ms2.ToArray();
                                }

                                // write variable
                                temp_bw1.Write(varsize);
                                temp_bw1.Write(variable.typeId);
                                temp_bw1.Write(variable.nameId);
                                temp_bw1.Write(varvalue);
                            }

                            componentSize += (UInt32)temp_ms1.Length;
                            compbytes = temp_ms1.ToArray();
                        }

                        bw.Write(componentSize);
                        bw.Write(compbytes);
                        
                    }
                    return ms.ToArray();
                }
            }
            
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CEntity(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CEntity) base.Copy(context);

            var.unk1 = (CUInt32) unk1.Copy(context);
            var.unk2 = (CUInt32) unk2.Copy(context);
            var.components = (CArray) components.Copy(context);
            var.tail = tail;
            var.compressedComponents = compressedComponents;

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);

            list.Add(unk1);
            list.Add(unk2);
            list.Add(components);
            if (tail.Bytes != null)
                list.Add(tail);
            if (compressedComponents.variables != null)
                list.Add(compressedComponents);

            return list;
        }
    }
}