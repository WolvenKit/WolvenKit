using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class C4ControllerPS : ExplosiveDeviceControllerPS
	{
		[Ordinal(119)] [RED("itemTweakDBString")] public CName ItemTweakDBString { get; set; }

		public C4ControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
