using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CVariableValueStateTransitionCondition : IBehaviorStateTransitionCondition
	{
		[Ordinal(1)] [RED("compareValue")] 		public CFloat CompareValue { get; set;}

		[Ordinal(2)] [RED("compareFunc")] 		public CEnum<ECompareFunc> CompareFunc { get; set;}

		[Ordinal(3)] [RED("socketName")] 		public CName SocketName { get; set;}

		[Ordinal(4)] [RED("useAbsoluteValue")] 		public CBool UseAbsoluteValue { get; set;}

		[Ordinal(5)] [RED("cachedVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedVariableNode { get; set;}

		public CVariableValueStateTransitionCondition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CVariableValueStateTransitionCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}