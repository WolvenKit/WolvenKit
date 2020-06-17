using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDamageData : CBaseDamage
	{
		[RED("processedDmg")] 		public SProcessedDamage ProcessedDmg { get; set;}

		[RED("additiveHitReactionAnimRequested")] 		public CBool AdditiveHitReactionAnimRequested { get; set;}

		[RED("customHitReactionRequested")] 		public CBool CustomHitReactionRequested { get; set;}

		[RED("isDoTDamage")] 		public CBool IsDoTDamage { get; set;}

		public CDamageData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CDamageData(cr2w);

	}
}