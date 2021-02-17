using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceOperations : IScriptable
	{
		[Ordinal(0)] [RED("components")] public CArray<wCHandle<entIPlacedComponent>> Components { get; set; }
		[Ordinal(1)] [RED("fxInstances")] public CArray<SVfxInstanceData> FxInstances { get; set; }

		public DeviceOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
