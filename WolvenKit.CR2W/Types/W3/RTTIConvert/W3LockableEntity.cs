using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LockableEntity : CGameplayEntity
	{
		[RED("isEnabledOnSpawn")] 		public CBool IsEnabledOnSpawn { get; set;}

		[RED("lockedByKey")] 		public CBool LockedByKey { get; set;}

		[RED("keyItemName")] 		public CName KeyItemName { get; set;}

		[RED("removeKeyOnUse")] 		public CBool RemoveKeyOnUse { get; set;}

		[RED("enabledByFact")] 		public CString EnabledByFact { get; set;}

		[RED("factOnLockedAttempt")] 		public CString FactOnLockedAttempt { get; set;}

		[RED("factOnUnlockedByKey")] 		public CString FactOnUnlockedByKey { get; set;}

		public W3LockableEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LockableEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}