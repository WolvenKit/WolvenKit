using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AnimatedContainer : W3Container
	{
		[RED("animationForAllInteractions")] 		public CBool AnimationForAllInteractions { get; set;}

		[RED("interactionName")] 		public CString InteractionName { get; set;}

		[RED("holsterWeaponAtTheBeginning")] 		public CBool HolsterWeaponAtTheBeginning { get; set;}

		[RED("interactionAnim")] 		public CEnum<EPlayerExplorationAction> InteractionAnim { get; set;}

		[RED("slotAnimName")] 		public CName SlotAnimName { get; set;}

		[RED("interactionAnimTime")] 		public CFloat InteractionAnimTime { get; set;}

		[RED("desiredPlayerToEntityDistance")] 		public CFloat DesiredPlayerToEntityDistance { get; set;}

		[RED("matchPlayerHeadingWithHeadingOfTheEntity")] 		public CBool MatchPlayerHeadingWithHeadingOfTheEntity { get; set;}

		[RED("attachThisObjectOnAnimEvent")] 		public CBool AttachThisObjectOnAnimEvent { get; set;}

		[RED("attachSlotName")] 		public CName AttachSlotName { get; set;}

		[RED("attachAnimName")] 		public CName AttachAnimName { get; set;}

		[RED("detachAnimName")] 		public CName DetachAnimName { get; set;}

		public W3AnimatedContainer(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3AnimatedContainer(cr2w);

	}
}