using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class EP1Chandelier : CGameplayEntity
	{
		[Ordinal(1)] [RED("m_fallSpeed")] 		public CFloat M_fallSpeed { get; set;}

		[Ordinal(2)] [RED("m_damagePercent")] 		public CFloat M_damagePercent { get; set;}

		[Ordinal(3)] [RED("m_fallDelay")] 		public CFloat M_fallDelay { get; set;}

		[Ordinal(4)] [RED("m_floorLevel")] 		public CFloat M_floorLevel { get; set;}

		[Ordinal(5)] [RED("m_radius")] 		public CFloat M_radius { get; set;}

		[Ordinal(6)] [RED("m_height")] 		public CFloat M_height { get; set;}

		[Ordinal(7)] [RED("m_falling")] 		public CBool M_falling { get; set;}

		[Ordinal(8)] [RED("m_currTime")] 		public CFloat M_currTime { get; set;}

		public EP1Chandelier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EP1Chandelier(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}