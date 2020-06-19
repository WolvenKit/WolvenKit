using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphStateTransitionNode : CBehaviorGraphNode
	{
		[RED("transitionPriority")] 		public CFloat TransitionPriority { get; set;}

		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[RED("transitionCondition")] 		public CPtr<IBehaviorStateTransitionCondition> TransitionCondition { get; set;}

		[RED("setInternalVariables", 2,0)] 		public CArray<SBehaviorGraphTransitionSetInternalVariable> SetInternalVariables { get; set;}

		[RED("cachedStartStateNode")] 		public CPtr<CBehaviorGraphStateNode> CachedStartStateNode { get; set;}

		[RED("cachedEndStateNode")] 		public CPtr<CBehaviorGraphStateNode> CachedEndStateNode { get; set;}

		public CBehaviorGraphStateTransitionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphStateTransitionNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}