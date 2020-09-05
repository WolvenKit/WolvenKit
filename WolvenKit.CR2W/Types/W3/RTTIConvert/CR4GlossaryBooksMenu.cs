using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GlossaryBooksMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("SORT_WEIGHT_PAINTINGS")] 		public CInt32 SORT_WEIGHT_PAINTINGS { get; set;}

		[Ordinal(2)] [RED("SORT_WEIGHT_BOOKS")] 		public CInt32 SORT_WEIGHT_BOOKS { get; set;}

		[Ordinal(3)] [RED("SORT_WEIGHT_Q")] 		public CInt32 SORT_WEIGHT_Q { get; set;}

		[Ordinal(4)] [RED("SORT_WEIGHT_SQ")] 		public CInt32 SORT_WEIGHT_SQ { get; set;}

		[Ordinal(5)] [RED("SORT_WEIGHT_MQ")] 		public CInt32 SORT_WEIGHT_MQ { get; set;}

		[Ordinal(6)] [RED("SORT_WEIGHT_MH")] 		public CInt32 SORT_WEIGHT_MH { get; set;}

		[Ordinal(7)] [RED("SORT_WEIGHT_TH")] 		public CInt32 SORT_WEIGHT_TH { get; set;}

		public CR4GlossaryBooksMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GlossaryBooksMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}