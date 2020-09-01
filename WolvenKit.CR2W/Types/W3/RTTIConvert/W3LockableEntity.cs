using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LockableEntity : CGameplayEntity
	{
		[Ordinal(0)] [RED("("isEnabledOnSpawn")] 		public CBool IsEnabledOnSpawn { get; set;}

		[Ordinal(0)] [RED("("lockedByKey")] 		public CBool LockedByKey { get; set;}

		[Ordinal(0)] [RED("("keyItemName")] 		public CName KeyItemName { get; set;}

		[Ordinal(0)] [RED("("removeKeyOnUse")] 		public CBool RemoveKeyOnUse { get; set;}

		[Ordinal(0)] [RED("("enabledByFact")] 		public CString EnabledByFact { get; set;}

		[Ordinal(0)] [RED("("factOnLockedAttempt")] 		public CString FactOnLockedAttempt { get; set;}

		[Ordinal(0)] [RED("("factOnUnlockedByKey")] 		public CString FactOnUnlockedByKey { get; set;}

		[Ordinal(0)] [RED("("mainInteractionComponent")] 		public CHandle<CDoorComponent> MainInteractionComponent { get; set;}

		[Ordinal(0)] [RED("("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(0)] [RED("("isPlayerInActivationRange")] 		public CBool IsPlayerInActivationRange { get; set;}

		[Ordinal(0)] [RED("("isInteractionBlocked")] 		public CBool IsInteractionBlocked { get; set;}

		public W3LockableEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LockableEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}