using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEnchantmentFilters : CVariable
	{
		[Ordinal(1)] [RED("showHasIngredients")] 		public CBool ShowHasIngredients { get; set;}

		[Ordinal(2)] [RED("showMissingIngredients")] 		public CBool ShowMissingIngredients { get; set;}

		[Ordinal(3)] [RED("showLevel1")] 		public CBool ShowLevel1 { get; set;}

		[Ordinal(4)] [RED("showLevel2")] 		public CBool ShowLevel2 { get; set;}

		[Ordinal(5)] [RED("showLevel3")] 		public CBool ShowLevel3 { get; set;}

		public SEnchantmentFilters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}