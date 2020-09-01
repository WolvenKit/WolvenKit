using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SExplorationQueryContext : CVariable
	{
		[Ordinal(0)] [RED("("inputDirectionInWorldSpace")] 		public Vector InputDirectionInWorldSpace { get; set;}

		[Ordinal(0)] [RED("("maxAngleToCheck")] 		public CFloat MaxAngleToCheck { get; set;}

		[Ordinal(0)] [RED("("forJumping")] 		public CBool ForJumping { get; set;}

		[Ordinal(0)] [RED("("forDynamic")] 		public CBool ForDynamic { get; set;}

		[Ordinal(0)] [RED("("dontDoZAndDistChecks")] 		public CBool DontDoZAndDistChecks { get; set;}

		[Ordinal(0)] [RED("("laddersOnly")] 		public CBool LaddersOnly { get; set;}

		[Ordinal(0)] [RED("("forAutoTraverseSmall")] 		public CBool ForAutoTraverseSmall { get; set;}

		[Ordinal(0)] [RED("("forAutoTraverseBig")] 		public CBool ForAutoTraverseBig { get; set;}

		public SExplorationQueryContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SExplorationQueryContext(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}