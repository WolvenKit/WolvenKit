using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RetractableAdControllerPS : BaseAnimatedDeviceControllerPS
	{
		[Ordinal(108)] [RED("isControlled")] public CBool IsControlled { get; set; }

		public RetractableAdControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
