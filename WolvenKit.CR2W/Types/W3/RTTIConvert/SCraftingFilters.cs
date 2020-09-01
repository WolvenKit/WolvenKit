using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCraftingFilters : CVariable
	{
		[Ordinal(0)] [RED("("showCraftable")] 		public CBool ShowCraftable { get; set;}

		[Ordinal(0)] [RED("("showMissingIngre")] 		public CBool ShowMissingIngre { get; set;}

		[Ordinal(0)] [RED("("showAlreadyCrafted")] 		public CBool ShowAlreadyCrafted { get; set;}

		public SCraftingFilters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCraftingFilters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}