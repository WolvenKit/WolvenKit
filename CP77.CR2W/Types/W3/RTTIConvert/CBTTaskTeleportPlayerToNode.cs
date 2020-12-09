using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskTeleportPlayerToNode : IBehTreeTask
	{
		[Ordinal(1)] [RED("nodeToFind")] 		public CName NodeToFind { get; set;}

		[Ordinal(2)] [RED("shouldComplete")] 		public CBool ShouldComplete { get; set;}

		[Ordinal(3)] [RED("node")] 		public CHandle<CNode> Node { get; set;}

		[Ordinal(4)] [RED("pos")] 		public Vector Pos { get; set;}

		[Ordinal(5)] [RED("rot")] 		public EulerAngles Rot { get; set;}

		public CBTTaskTeleportPlayerToNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskTeleportPlayerToNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}