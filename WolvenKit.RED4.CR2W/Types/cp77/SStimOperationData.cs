using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SStimOperationData : CVariable
	{
		[Ordinal(0)] [RED("stimType")] public CEnum<DeviceStimType> StimType { get; set; }
		[Ordinal(1)] [RED("lifeTime")] public CFloat LifeTime { get; set; }
		[Ordinal(2)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(3)] [RED("operationType")] public CEnum<EEffectOperationType> OperationType { get; set; }
		[Ordinal(4)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }

		public SStimOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
