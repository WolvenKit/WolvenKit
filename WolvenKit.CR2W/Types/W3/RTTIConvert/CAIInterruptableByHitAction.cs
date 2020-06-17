using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIInterruptableByHitAction : IActionDecorator
	{
		[RED("shouldForceHitReaction")] 		public CBool ShouldForceHitReaction { get; set;}

		[RED("hitReactionType")] 		public EHitReactionType HitReactionType { get; set;}

		[RED("hitReactionSide")] 		public EHitReactionSide HitReactionSide { get; set;}

		[RED("hitReactionDirection")] 		public EHitReactionDirection HitReactionDirection { get; set;}

		[RED("hitSwingType")] 		public EAttackSwingType HitSwingType { get; set;}

		[RED("hitSwingDirection")] 		public EAttackSwingDirection HitSwingDirection { get; set;}

		public CAIInterruptableByHitAction(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIInterruptableByHitAction(cr2w);

	}
}