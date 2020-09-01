using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SingleMenuInitData : W3MenuInitData
	{
		[Ordinal(0)] [RED("("fixedMenuName")] 		public CName FixedMenuName { get; set;}

		[Ordinal(0)] [RED("("ignoreMeditationCheck")] 		public CBool IgnoreMeditationCheck { get; set;}

		[Ordinal(0)] [RED("("isBonusMeditationAvailable")] 		public CBool IsBonusMeditationAvailable { get; set;}

		[Ordinal(0)] [RED("("unlockCraftingMenu")] 		public CBool UnlockCraftingMenu { get; set;}

		[Ordinal(0)] [RED("("m_blockOtherPanels")] 		public CBool M_blockOtherPanels { get; set;}

		public W3SingleMenuInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SingleMenuInitData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}