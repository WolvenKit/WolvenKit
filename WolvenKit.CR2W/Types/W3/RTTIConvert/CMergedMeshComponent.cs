using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMergedMeshComponent : CMeshComponent
	{
		[RED("objects", 67,0)] 		public CArray<GlobalVisID> Objects { get; set;}

		[RED("renderMask")] 		public CUInt8 RenderMask { get; set;}

		[RED("streamingDistance")] 		public CFloat StreamingDistance { get; set;}

		public CMergedMeshComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMergedMeshComponent(cr2w);

	}
}