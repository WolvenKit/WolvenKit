using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class WeaponHolster : CObject
	{
		[Ordinal(1)] [RED("currentMeleeWeapon")] 		public CEnum<EPlayerWeapon> CurrentMeleeWeapon { get; set;}

		[Ordinal(2)] [RED("queuedMeleeWeapon")] 		public CEnum<EPlayerWeapon> QueuedMeleeWeapon { get; set;}

		[Ordinal(3)] [RED("isQueuedMeleeWeapon")] 		public CBool IsQueuedMeleeWeapon { get; set;}

		[Ordinal(4)] [RED("ownerHandle")] 		public EntityHandle OwnerHandle { get; set;}

		[Ordinal(5)] [RED("automaticUnholster")] 		public CBool AutomaticUnholster { get; set;}

		[Ordinal(6)] [RED("isMeleeWeaponReady")] 		public CBool IsMeleeWeaponReady { get; set;}

		public WeaponHolster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new WeaponHolster(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}