using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphStateTransitionGlobalBlendNode : CBehaviorGraphStateTransitionBlendNode
	{
		[RED("includeGroup")] 		public TagList IncludeGroup { get; set;}

		[RED("excludeGroup")] 		public TagList ExcludeGroup { get; set;}

		[RED("generateEventForDestState")] 		public CName GenerateEventForDestState { get; set;}

		[RED("generateForcedEventForDestState")] 		public CName GenerateForcedEventForDestState { get; set;}

		[RED("cachePoseFromPrevSampling")] 		public CBool CachePoseFromPrevSampling { get; set;}

		[RED("useProgressiveSampilngForBlending")] 		public CBool UseProgressiveSampilngForBlending { get; set;}

		public CBehaviorGraphStateTransitionGlobalBlendNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphStateTransitionGlobalBlendNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}