using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoyceHealthChangeListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(1)] [RED("royceComponent")] public CHandle<RoyceComponent> RoyceComponent { get; set; }
		[Ordinal(2)] [RED("weakspots")] public CArray<wCHandle<gameWeakspotObject>> Weakspots { get; set; }

		public RoyceHealthChangeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
