using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CNode : CObject
	{
		[Ordinal(1)] [RED("tags")] 		public TagList Tags { get; set;}

		[Ordinal(2)] [RED("transform")] 		public EngineTransform Transform { get; set;}

		[Ordinal(3)] [RED("transformParent")] 		public CPtr<CHardAttachment> TransformParent { get; set;}

		[Ordinal(4)] [RED("guid")] 		public CGUID Guid { get; set;}

		public CNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}