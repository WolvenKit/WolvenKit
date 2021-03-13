using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3RefillableContainer : W3Container
	{
		[Ordinal(1)] [RED("isEmpty")] 		public CBool IsEmpty { get; set;}

		[Ordinal(2)] [RED("checkedForBonusHerbs")] 		public CBool CheckedForBonusHerbs { get; set;}

		public W3RefillableContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3RefillableContainer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}