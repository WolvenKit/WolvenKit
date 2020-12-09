using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskJumpBack : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(1)] [RED("chance")] 		public CInt32 Chance { get; set;}

		[Ordinal(2)] [RED("checkRotation")] 		public CBool CheckRotation { get; set;}

		[Ordinal(3)] [RED("distance")] 		public CFloat Distance { get; set;}

		public CBTTaskJumpBack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskJumpBack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}