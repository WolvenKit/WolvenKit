using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Herb : W3RefillableContainer
	{
		[Ordinal(1)] [RED("foliageComponent")] 		public CHandle<CSwitchableFoliageComponent> FoliageComponent { get; set;}

		[Ordinal(2)] [RED("isEmptyAppearance")] 		public CBool IsEmptyAppearance { get; set;}

		public W3Herb(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Herb(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}