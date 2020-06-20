using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGuiEnhancementInfo : CVariable
	{
		[RED("enhancedItem")] 		public CName EnhancedItem { get; set;}

		[RED("enhancement")] 		public CName Enhancement { get; set;}

		[RED("oilItem")] 		public CName OilItem { get; set;}

		[RED("oil")] 		public CName Oil { get; set;}

		[RED("dyeItem")] 		public CName DyeItem { get; set;}

		[RED("dye")] 		public CName Dye { get; set;}

		[RED("dyeColor")] 		public CInt32 DyeColor { get; set;}

		public SGuiEnhancementInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGuiEnhancementInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}