using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericDeviceActionsData : CVariable
	{
		[Ordinal(0)] [RED("stateActionsOverrides")] public SGenericDeviceActionsData StateActionsOverrides { get; set; }
		[Ordinal(1)] [RED("customActions")] public SCustomDeviceActionsData CustomActions { get; set; }

		public GenericDeviceActionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
