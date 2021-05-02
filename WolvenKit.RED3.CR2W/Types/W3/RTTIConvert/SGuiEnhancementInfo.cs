using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGuiEnhancementInfo : CVariable
	{
		[Ordinal(1)] [RED("enhancedItem")] 		public CName EnhancedItem { get; set;}

		[Ordinal(2)] [RED("enhancement")] 		public CName Enhancement { get; set;}

		[Ordinal(3)] [RED("oilItem")] 		public CName OilItem { get; set;}

		[Ordinal(4)] [RED("oil")] 		public CName Oil { get; set;}

		[Ordinal(5)] [RED("dyeItem")] 		public CName DyeItem { get; set;}

		[Ordinal(6)] [RED("dye")] 		public CName Dye { get; set;}

		[Ordinal(7)] [RED("dyeColor")] 		public CInt32 DyeColor { get; set;}

		public SGuiEnhancementInfo(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGuiEnhancementInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}