using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseActionOperations : DeviceOperations
	{
		[Ordinal(2)] [RED("baseActionsOperations")] public CArray<SBaseActionOperationData> BaseActionsOperations { get; set; }

		public BaseActionOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
