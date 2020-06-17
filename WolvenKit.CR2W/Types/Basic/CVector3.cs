using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CVector3<T> : CVariable where T : CVariable
    {
        public T x, y, z;
        public Func<CR2WFile, T> elementFactory;

        public CVector3(CR2WFile cr2w, Func<CR2WFile, T> elementFactory) : base(cr2w)
        {
            this.elementFactory = elementFactory;

            x = elementFactory.Invoke(cr2w);
            x.Name = "x";
            y = elementFactory.Invoke(cr2w);
            y.Name = "y";
            z = elementFactory.Invoke(cr2w);
            z.Name = "z";
        }


        public override void Read(BinaryReader file, uint size)
        {
            x.Read(file, size);
            y.Read(file, size);
            z.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            x.Write(file);
            y.Write(file);
            z.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CVector3<T>(cr2w, elementFactory);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = base.Copy(context) as CVector3<T>;

            copy.x = x.Copy(context) as T;
            copy.y = y.Copy(context) as T;
            copy.z = z.Copy(context) as T;
            return copy;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var vars = new List<IEditableVariable>
            {
                x,
                y,
                z
            };
            return vars;
        }

        public override string ToString()
        {
            var builder = new StringBuilder().Append(3);
            builder.Append(":");

            builder.Append(" <").Append(x.ToString()).Append(">");
            builder.Append(" <").Append(y.ToString()).Append(">");
            builder.Append(" <").Append(z.ToString()).Append(">");

            return builder.ToString();
        }
    }
}