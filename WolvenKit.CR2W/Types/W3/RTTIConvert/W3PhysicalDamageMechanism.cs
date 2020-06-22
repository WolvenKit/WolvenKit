using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PhysicalDamageMechanism : CGameplayEntity
	{
		[RED("dmgValue")] 		public CFloat DmgValue { get; set;}

		[RED("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[RED("reactivationTimer")] 		public CFloat ReactivationTimer { get; set;}

		[RED("animName")] 		public CName AnimName { get; set;}

		[RED("shouldRewind")] 		public CBool ShouldRewind { get; set;}

		[RED("isActive")] 		public CBool IsActive { get; set;}

		[RED("isMoving")] 		public CBool IsMoving { get; set;}

		public W3PhysicalDamageMechanism(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PhysicalDamageMechanism(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}