using System;
using System.IO;
using FastMember;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.TweakDB.Attributes;

namespace WolvenKit.RED4.TweakDB.Types
{
    public abstract class CClass : IType
    {
        public abstract string Name { get; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((byte)0x00); // Garbage, it is read but not used when "Unserialized" is called.

            var type = GetType();
            var accessor = TypeAccessor.Create(type);

            var members = accessor.GetMembers();
            foreach (var member in members)
            {
                var attr = member.GetAttribute(typeof(PropertyAttribute), false) as PropertyAttribute;
                if (attr is not null)
                {
                    var nativeType = accessor[this, member.Name] as IType;
                    if (nativeType is not null)
                    {
                        writer.WriteLengthPrefixedString(attr.Name);
                        writer.WriteLengthPrefixedString(nativeType.Name);

                        var currOffset = writer.BaseStream.Position;

                        // Skip next offset for now.
                        writer.Seek(sizeof(uint), SeekOrigin.Current);

                        // Serialize the type.
                        nativeType.Serialize(writer);
                        var endOffset = writer.BaseStream.Position;

                        // Now let's calculate the next variable offset.
                        var nextOffset = (uint)(endOffset - currOffset);

                        // Move cursor back to size offset and write it.
                        writer.Seek((int)currOffset, SeekOrigin.Begin);
                        writer.Write(nextOffset);

                        // Move cursor to the correct offset to continue writing.
                        writer.Seek((int)endOffset, SeekOrigin.Begin);
                    }
                    else
                    {
                        throw new ApplicationException($"'{type.Name}.{member.Name}' has an unknown type");
                    }
                }
            }

            // This seems to always be "None", need more reversing. Seems to mark the end of properties.
            writer.WriteLengthPrefixedString("None");
        }
    }
}
