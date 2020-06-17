using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPoseCompressionCharacter : CPoseCompressionDefault
	{
		[RED("leftWeaponName")] 		public CString LeftWeaponName { get; set;}

		[RED("rightWeaponName")] 		public CString RightWeaponName { get; set;}

		[RED("leftWeapon")] 		public CInt32 LeftWeapon { get; set;}

		[RED("rightWeapon")] 		public CInt32 RightWeapon { get; set;}

		public CPoseCompressionCharacter(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CPoseCompressionCharacter(cr2w);

	}
}