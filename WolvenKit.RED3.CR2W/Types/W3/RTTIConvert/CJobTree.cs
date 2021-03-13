using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJobTree : CResource
	{
		[Ordinal(1)] [RED("jobTreeRootNode")] 		public CPtr<CJobTreeNode> JobTreeRootNode { get; set;}

		[Ordinal(2)] [RED("movementMode")] 		public CEnum<EJobMovementMode> MovementMode { get; set;}

		[Ordinal(3)] [RED("customMovementSpeed")] 		public CFloat CustomMovementSpeed { get; set;}

		[Ordinal(4)] [RED("settings")] 		public SJobTreeSettings Settings { get; set;}

		public CJobTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJobTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}