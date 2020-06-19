using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CNode : CObject
	{
		[RED("tags")] 		public TagList Tags { get; set;}

		[RED("transform")] 		public EngineTransform Transform { get; set;}

		[RED("transformParent")] 		public CPtr<CHardAttachment> TransformParent { get; set;}

		[RED("guid")] 		public CGUID Guid { get; set;}

		public CNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}