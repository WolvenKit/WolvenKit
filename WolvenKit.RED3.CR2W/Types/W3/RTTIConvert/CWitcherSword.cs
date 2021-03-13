using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWitcherSword : CItemEntity
	{
		[Ordinal(1)] [RED("swordType")] 		public CEnum<EWitcherSwordType> SwordType { get; set;}

		[Ordinal(2)] [RED("runeCount")] 		public CInt32 RuneCount { get; set;}

		[Ordinal(3)] [RED("padBacklightColor")] 		public Vector PadBacklightColor { get; set;}

		public CWitcherSword(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWitcherSword(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}