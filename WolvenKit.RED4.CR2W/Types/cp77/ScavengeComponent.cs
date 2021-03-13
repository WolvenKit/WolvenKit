using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScavengeComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("scavengeTargets")] public CArray<wCHandle<gameObject>> ScavengeTargets { get; set; }

		public ScavengeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
