using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SVerticalMovementParams : CVariable
	{
		[RED("m_VertImpulseF")] 		public CFloat M_VertImpulseF { get; set;}

		[RED("m_VertMaxSpeedF")] 		public CFloat M_VertMaxSpeedF { get; set;}

		[RED("m_GravityUpF")] 		public CFloat M_GravityUpF { get; set;}

		[RED("m_GravityDownF")] 		public CFloat M_GravityDownF { get; set;}

		public SVerticalMovementParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SVerticalMovementParams(cr2w);

	}
}