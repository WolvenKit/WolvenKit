using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SVerticalMovementParams : CVariable
	{
		[Ordinal(1)] [RED("m_VertImpulseF")] 		public CFloat M_VertImpulseF { get; set;}

		[Ordinal(2)] [RED("m_VertMaxSpeedF")] 		public CFloat M_VertMaxSpeedF { get; set;}

		[Ordinal(3)] [RED("m_GravityUpF")] 		public CFloat M_GravityUpF { get; set;}

		[Ordinal(4)] [RED("m_GravityDownF")] 		public CFloat M_GravityDownF { get; set;}

		public SVerticalMovementParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SVerticalMovementParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}