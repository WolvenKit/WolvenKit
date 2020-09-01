using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AnimatedContainer : W3Container
	{
		[Ordinal(0)] [RED("("animationForAllInteractions")] 		public CBool AnimationForAllInteractions { get; set;}

		[Ordinal(0)] [RED("("interactionName")] 		public CString InteractionName { get; set;}

		[Ordinal(0)] [RED("("holsterWeaponAtTheBeginning")] 		public CBool HolsterWeaponAtTheBeginning { get; set;}

		[Ordinal(0)] [RED("("interactionAnim")] 		public CEnum<EPlayerExplorationAction> InteractionAnim { get; set;}

		[Ordinal(0)] [RED("("slotAnimName")] 		public CName SlotAnimName { get; set;}

		[Ordinal(0)] [RED("("interactionAnimTime")] 		public CFloat InteractionAnimTime { get; set;}

		[Ordinal(0)] [RED("("desiredPlayerToEntityDistance")] 		public CFloat DesiredPlayerToEntityDistance { get; set;}

		[Ordinal(0)] [RED("("matchPlayerHeadingWithHeadingOfTheEntity")] 		public CBool MatchPlayerHeadingWithHeadingOfTheEntity { get; set;}

		[Ordinal(0)] [RED("("attachThisObjectOnAnimEvent")] 		public CBool AttachThisObjectOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("attachSlotName")] 		public CName AttachSlotName { get; set;}

		[Ordinal(0)] [RED("("attachAnimName")] 		public CName AttachAnimName { get; set;}

		[Ordinal(0)] [RED("("detachAnimName")] 		public CName DetachAnimName { get; set;}

		[Ordinal(0)] [RED("("objectAttached")] 		public CBool ObjectAttached { get; set;}

		[Ordinal(0)] [RED("("objectCachedPos")] 		public Vector ObjectCachedPos { get; set;}

		[Ordinal(0)] [RED("("objectCachedRot")] 		public EulerAngles ObjectCachedRot { get; set;}

		public W3AnimatedContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AnimatedContainer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}