using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskTeleportPlayerToNodeDef : IBehTreeTaskDefinition
	{
		[RED("nodeToFind")] 		public CName NodeToFind { get; set;}

		[RED("shouldComplete")] 		public CBool ShouldComplete { get; set;}

		[RED("node")] 		public CHandle<CNode> Node { get; set;}

		[RED("pos")] 		public Vector Pos { get; set;}

		[RED("rot")] 		public EulerAngles Rot { get; set;}

		public CBTTaskTeleportPlayerToNodeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskTeleportPlayerToNodeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}