using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveDOTStatusEffectsEffector : gameEffector
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)] [RED("delay")] public CFloat Delay { get; set; }

		public RemoveDOTStatusEffectsEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
