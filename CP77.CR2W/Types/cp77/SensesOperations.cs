using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SensesOperations : DeviceOperations
	{
		[Ordinal(0)]  [RED("components")] public CArray<wCHandle<entIPlacedComponent>> Components { get; set; }
		[Ordinal(1)]  [RED("fxInstances")] public CArray<SVfxInstanceData> FxInstances { get; set; }
		[Ordinal(2)]  [RED("sensesOperations")] public CArray<SSensesOperationData> _SensesOperations { get; set; }

		public SensesOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
