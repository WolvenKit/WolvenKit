using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ConstVectorDamper : CObject
	{
		[Ordinal(0)] [RED("destValue")] 		public Vector DestValue { get; set;}

		[Ordinal(0)] [RED("currValue")] 		public Vector CurrValue { get; set;}

		[Ordinal(0)] [RED("deltaValue")] 		public CFloat DeltaValue { get; set;}

		public ConstVectorDamper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ConstVectorDamper(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}