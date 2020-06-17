using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SExplorationQueryContext : CVariable
	{
		[RED("inputDirectionInWorldSpace")] 		public Vector InputDirectionInWorldSpace { get; set;}

		[RED("maxAngleToCheck")] 		public CFloat MaxAngleToCheck { get; set;}

		[RED("forJumping")] 		public CBool ForJumping { get; set;}

		[RED("forDynamic")] 		public CBool ForDynamic { get; set;}

		[RED("dontDoZAndDistChecks")] 		public CBool DontDoZAndDistChecks { get; set;}

		[RED("laddersOnly")] 		public CBool LaddersOnly { get; set;}

		[RED("forAutoTraverseSmall")] 		public CBool ForAutoTraverseSmall { get; set;}

		[RED("forAutoTraverseBig")] 		public CBool ForAutoTraverseBig { get; set;}

		public SExplorationQueryContext(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SExplorationQueryContext(cr2w);

	}
}