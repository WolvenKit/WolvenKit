using System.Collections.Generic;
using System.IO;using System.Runtime.Serialization;
using System.Text;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta()]
	public class CMatrix : CVariable
	{
		[RED("X")] 		public Vector X { get; set;}

		[RED("Y")] 		public Vector Y { get; set;}

		[RED("Z")] 		public Vector Z { get; set;}

		[RED("W")] 		public Vector W { get; set;}

		public CMatrix(CR2WFile cr2w) : base(cr2w)
		{
			X = new Vector(cr2w);
			Y = new Vector(cr2w);
			Z = new Vector(cr2w);
			W = new Vector(cr2w);
		}

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override string ToString()
		{
			var builder = new StringBuilder();

			builder.Append(" <").Append(X.ToString()).Append(",");
			builder.Append(Y.ToString()).Append(",");
			builder.Append(Z.ToString()).Append(",");
			builder.Append(W.ToString()).Append(">");

			return builder.ToString();
		}

		public override CVariable Create(CR2WFile cr2w) => new CMatrix(cr2w);
    }
}