using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadeAnimFeatureChangeEvent : redEvent
	{
		[Ordinal(0)] [RED("newState")] public CInt32 NewState { get; set; }

		public GrenadeAnimFeatureChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
