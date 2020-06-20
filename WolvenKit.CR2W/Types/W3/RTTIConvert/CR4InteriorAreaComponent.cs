using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4InteriorAreaComponent : CTriggerAreaComponent
	{
		[RED("entranceTag")] 		public CName EntranceTag { get; set;}

		[RED("texture")] 		public CString Texture { get; set;}

		[RED("isDarkPlace")] 		public CBool IsDarkPlace { get; set;}

		[RED("allowHorseInThisInterior")] 		public CBool AllowHorseInThisInterior { get; set;}

		[RED("movementLock")] 		public CEnum<EPlayerMovementLockType> MovementLock { get; set;}

		public CR4InteriorAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4InteriorAreaComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}