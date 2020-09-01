using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPoseCompressionCharacter : CPoseCompressionDefault
	{
		[Ordinal(0)] [RED("leftWeaponName")] 		public CString LeftWeaponName { get; set;}

		[Ordinal(0)] [RED("rightWeaponName")] 		public CString RightWeaponName { get; set;}

		[Ordinal(0)] [RED("leftWeapon")] 		public CInt32 LeftWeapon { get; set;}

		[Ordinal(0)] [RED("rightWeapon")] 		public CInt32 RightWeapon { get; set;}

		public CPoseCompressionCharacter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPoseCompressionCharacter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}