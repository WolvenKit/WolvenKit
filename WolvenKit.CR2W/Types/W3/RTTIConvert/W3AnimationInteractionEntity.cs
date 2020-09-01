using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AnimationInteractionEntity : CR4MapPinEntity
	{
		[Ordinal(1)] [RED("("animationForAllInteractions")] 		public CBool AnimationForAllInteractions { get; set;}

		[Ordinal(2)] [RED("("interactionName")] 		public CString InteractionName { get; set;}

		[Ordinal(3)] [RED("("holsterWeaponAtTheBeginning")] 		public CBool HolsterWeaponAtTheBeginning { get; set;}

		[Ordinal(4)] [RED("("interactionAnim")] 		public CEnum<EPlayerExplorationAction> InteractionAnim { get; set;}

		[Ordinal(5)] [RED("("slotAnimName")] 		public CName SlotAnimName { get; set;}

		[Ordinal(6)] [RED("("interactionAnimTime")] 		public CFloat InteractionAnimTime { get; set;}

		[Ordinal(7)] [RED("("desiredPlayerToEntityDistance")] 		public CFloat DesiredPlayerToEntityDistance { get; set;}

		[Ordinal(8)] [RED("("matchPlayerHeadingWithHeadingOfTheEntity")] 		public CBool MatchPlayerHeadingWithHeadingOfTheEntity { get; set;}

		[Ordinal(9)] [RED("("attachThisObjectOnAnimEvent")] 		public CBool AttachThisObjectOnAnimEvent { get; set;}

		[Ordinal(10)] [RED("("attachSlotName")] 		public CName AttachSlotName { get; set;}

		[Ordinal(11)] [RED("("attachAnimName")] 		public CName AttachAnimName { get; set;}

		[Ordinal(12)] [RED("("detachAnimName")] 		public CName DetachAnimName { get; set;}

		[Ordinal(13)] [RED("("isPlayingInteractionAnim")] 		public CBool IsPlayingInteractionAnim { get; set;}

		[Ordinal(14)] [RED("("objectAttached")] 		public CBool ObjectAttached { get; set;}

		[Ordinal(15)] [RED("("objectCachedPos")] 		public Vector ObjectCachedPos { get; set;}

		[Ordinal(16)] [RED("("objectCachedRot")] 		public EulerAngles ObjectCachedRot { get; set;}

		public W3AnimationInteractionEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AnimationInteractionEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}