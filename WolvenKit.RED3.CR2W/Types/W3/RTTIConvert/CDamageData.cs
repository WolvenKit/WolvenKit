using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDamageData : CBaseDamage
	{
		[Ordinal(1)] [RED("processedDmg")] 		public SProcessedDamage ProcessedDmg { get; set;}

		[Ordinal(2)] [RED("additiveHitReactionAnimRequested")] 		public CBool AdditiveHitReactionAnimRequested { get; set;}

		[Ordinal(3)] [RED("customHitReactionRequested")] 		public CBool CustomHitReactionRequested { get; set;}

		[Ordinal(4)] [RED("isDoTDamage")] 		public CBool IsDoTDamage { get; set;}

		[Ordinal(5)] [RED("isActionMelee")] 		public CBool IsActionMelee { get; set;}

		public CDamageData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}