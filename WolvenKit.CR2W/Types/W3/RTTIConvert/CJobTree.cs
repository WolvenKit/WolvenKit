using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJobTree : CResource
	{
		[RED("jobTreeRootNode")] 		public CPtr<CJobTreeNode> JobTreeRootNode { get; set;}

		[RED("movementMode")] 		public CEnum<EJobMovementMode> MovementMode { get; set;}

		[RED("customMovementSpeed")] 		public CFloat CustomMovementSpeed { get; set;}

		[RED("settings")] 		public SJobTreeSettings Settings { get; set;}

		public CJobTree(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CJobTree(cr2w);

	}
}