using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InteractionAreaOperations : DeviceOperations
	{
		[Ordinal(0)]  [RED("interactionAreaOperations")] public CArray<SInteractionAreaOperationData> InteractionAreaOperations { get; set; }

		public InteractionAreaOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
