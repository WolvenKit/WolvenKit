using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPoseCompressionCharacter : CPoseCompressionDefault
	{
		[Ordinal(1)] [RED("leftWeaponName")] 		public CString LeftWeaponName { get; set;}

		[Ordinal(2)] [RED("rightWeaponName")] 		public CString RightWeaponName { get; set;}

		[Ordinal(3)] [RED("leftWeapon")] 		public CInt32 LeftWeapon { get; set;}

		[Ordinal(4)] [RED("rightWeapon")] 		public CInt32 RightWeapon { get; set;}

		public CPoseCompressionCharacter(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}