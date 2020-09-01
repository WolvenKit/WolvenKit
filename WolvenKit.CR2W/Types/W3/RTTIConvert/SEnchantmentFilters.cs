using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEnchantmentFilters : CVariable
	{
		[Ordinal(0)] [RED("("showHasIngredients")] 		public CBool ShowHasIngredients { get; set;}

		[Ordinal(0)] [RED("("showMissingIngredients")] 		public CBool ShowMissingIngredients { get; set;}

		[Ordinal(0)] [RED("("showLevel1")] 		public CBool ShowLevel1 { get; set;}

		[Ordinal(0)] [RED("("showLevel2")] 		public CBool ShowLevel2 { get; set;}

		[Ordinal(0)] [RED("("showLevel3")] 		public CBool ShowLevel3 { get; set;}

		public SEnchantmentFilters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEnchantmentFilters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}