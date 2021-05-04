using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphStateTransitionGlobalBlendNode : CBehaviorGraphStateTransitionBlendNode
	{
		[Ordinal(1)] [RED("includeGroup")] 		public TagList IncludeGroup { get; set;}

		[Ordinal(2)] [RED("excludeGroup")] 		public TagList ExcludeGroup { get; set;}

		[Ordinal(3)] [RED("generateEventForDestState")] 		public CName GenerateEventForDestState { get; set;}

		[Ordinal(4)] [RED("generateForcedEventForDestState")] 		public CName GenerateForcedEventForDestState { get; set;}

		[Ordinal(5)] [RED("cachePoseFromPrevSampling")] 		public CBool CachePoseFromPrevSampling { get; set;}

		[Ordinal(6)] [RED("useProgressiveSampilngForBlending")] 		public CBool UseProgressiveSampilngForBlending { get; set;}

		public CBehaviorGraphStateTransitionGlobalBlendNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}