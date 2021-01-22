using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractionAreaOperations : DeviceOperations
	{
		[Ordinal(0)]  [RED("interactionAreaOperations")] public CArray<SInteractionAreaOperationData> _InteractionAreaOperations { get; set; }

		public InteractionAreaOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
