using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceAnimSetup : CVariable
	{
		[Ordinal(0)] [RED("animationTime")] public CFloat AnimationTime { get; set; }

		public ActivatedDeviceAnimSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
