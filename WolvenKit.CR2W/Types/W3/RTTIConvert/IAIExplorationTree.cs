using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IAIExplorationTree : IAITree
	{
		[Ordinal(0)] [RED("interactionPoint")] 		public Vector3 InteractionPoint { get; set;}

		[Ordinal(0)] [RED("destinationPoint")] 		public Vector3 DestinationPoint { get; set;}

		[Ordinal(0)] [RED("metalinkComponent")] 		public CHandle<CComponent> MetalinkComponent { get; set;}

		public IAIExplorationTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IAIExplorationTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}