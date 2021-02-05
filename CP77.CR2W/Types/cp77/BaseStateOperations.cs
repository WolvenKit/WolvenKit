using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseStateOperations : DeviceOperations
	{
		[Ordinal(0)]  [RED("components")] public CArray<wCHandle<entIPlacedComponent>> Components { get; set; }
		[Ordinal(1)]  [RED("fxInstances")] public CArray<SVfxInstanceData> FxInstances { get; set; }
		[Ordinal(2)]  [RED("stateActionsOverrides")] public SGenericDeviceActionsData StateActionsOverrides { get; set; }
		[Ordinal(3)]  [RED("baseStateOperations")] public CArray<SBaseStateOperationData> _BaseStateOperations { get; set; }
		[Ordinal(4)]  [RED("wasStateCached")] public CBool WasStateCached { get; set; }
		[Ordinal(5)]  [RED("cachedState")] public CEnum<EDeviceStatus> CachedState { get; set; }

		public BaseStateOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
