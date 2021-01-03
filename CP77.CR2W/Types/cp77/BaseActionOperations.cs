using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BaseActionOperations : DeviceOperations
	{
		[Ordinal(0)]  [RED("baseActionsOperations")] public CArray<SBaseActionOperationData> BaseActionsOperations { get; set; }

		public BaseActionOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
