using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParentInputValueStateTransitionCondition : IBehaviorStateTransitionCondition
	{
		[Ordinal(0)] [RED("parentValueName")] 		public CName ParentValueName { get; set;}

		[Ordinal(0)] [RED("compareFunc")] 		public CEnum<ECompareFunc> CompareFunc { get; set;}

		[Ordinal(0)] [RED("compareParentInputName")] 		public CName CompareParentInputName { get; set;}

		[Ordinal(0)] [RED("socketName")] 		public CName SocketName { get; set;}

		[Ordinal(0)] [RED("compareValue")] 		public CFloat CompareValue { get; set;}

		[Ordinal(0)] [RED("useAbsoluteValue")] 		public CBool UseAbsoluteValue { get; set;}

		[Ordinal(0)] [RED("epsilon")] 		public CFloat Epsilon { get; set;}

		[Ordinal(0)] [RED("cachedParentInput")] 		public CPtr<CBehaviorGraphValueNode> CachedParentInput { get; set;}

		[Ordinal(0)] [RED("cachedCompareParentInput")] 		public CPtr<CBehaviorGraphValueNode> CachedCompareParentInput { get; set;}

		[Ordinal(0)] [RED("cachedTestedValue")] 		public CPtr<CBehaviorGraphValueNode> CachedTestedValue { get; set;}

		public CParentInputValueStateTransitionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParentInputValueStateTransitionCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}