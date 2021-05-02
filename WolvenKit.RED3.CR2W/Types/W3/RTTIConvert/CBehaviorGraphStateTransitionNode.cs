using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphStateTransitionNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("transitionPriority")] 		public CFloat TransitionPriority { get; set;}

		[Ordinal(2)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(3)] [RED("transitionCondition")] 		public CPtr<IBehaviorStateTransitionCondition> TransitionCondition { get; set;}

		[Ordinal(4)] [RED("setInternalVariables", 2,0)] 		public CArray<SBehaviorGraphTransitionSetInternalVariable> SetInternalVariables { get; set;}

		[Ordinal(5)] [RED("cachedStartStateNode")] 		public CPtr<CBehaviorGraphStateNode> CachedStartStateNode { get; set;}

		[Ordinal(6)] [RED("cachedEndStateNode")] 		public CPtr<CBehaviorGraphStateNode> CachedEndStateNode { get; set;}

		public CBehaviorGraphStateTransitionNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphStateTransitionNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}