using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphStateNode : CBehaviorGraphContainerNode
	{
		[RED("groups")] 		public TagList Groups { get; set;}

		[RED("behaviorGraphSyncInfo")] 		public SBehaviorGraphStateBehaviorGraphSyncInfo BehaviorGraphSyncInfo { get; set;}

		[RED("cachedStateTransitions", 2,0)] 		public CArray<CPtr<CBehaviorGraphStateTransitionNode>> CachedStateTransitions { get; set;}

		public CBehaviorGraphStateNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphStateNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}