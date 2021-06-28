using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CCurve : CObject
	{
		[Ordinal(1)] [RED("color")] 		public CColor Color { get; set;}

		[Ordinal(2)] [RED("dataBaseType")] 		public CEnum<ECurveBaseType> DataBaseType { get; set;}

		[Ordinal(3)] [RED("data.m_loop")] 		public CBool Data_m_loop { get; set;}

		public CCurve(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}