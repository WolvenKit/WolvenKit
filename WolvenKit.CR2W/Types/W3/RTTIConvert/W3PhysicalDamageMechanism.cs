using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PhysicalDamageMechanism : CGameplayEntity
	{
		[RED("dmgValue")] 		public CFloat DmgValue { get; set;}

		[RED("hitReactionType")] 		public EHitReactionType HitReactionType { get; set;}

		[RED("reactivationTimer")] 		public CFloat ReactivationTimer { get; set;}

		[RED("animName")] 		public CName AnimName { get; set;}

		[RED("shouldRewind")] 		public CBool ShouldRewind { get; set;}

		public W3PhysicalDamageMechanism(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3PhysicalDamageMechanism(cr2w);

	}
}