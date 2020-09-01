using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBiesChargeDef : CBTTask3StateAttackDef
	{
		[Ordinal(0)] [RED("endStuck")] 		public CEnum<EAttackType> EndStuck { get; set;}

		[Ordinal(0)] [RED("endHit")] 		public CEnum<EAttackType> EndHit { get; set;}

		[Ordinal(0)] [RED("stuckTime")] 		public CFloat StuckTime { get; set;}

		public CBTTaskBiesChargeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskBiesChargeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}