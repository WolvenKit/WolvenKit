using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestroyWeakspot : AIActionHelperTask
	{
		[Ordinal(5)] [RED("weakspotIndex")] public CInt32 WeakspotIndex { get; set; }
		[Ordinal(6)] [RED("weakspotComponent")] public CHandle<gameWeakspotComponent> WeakspotComponent { get; set; }
		[Ordinal(7)] [RED("weakspotArray")] public CArray<wCHandle<gameWeakspotObject>> WeakspotArray { get; set; }

		public DestroyWeakspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
