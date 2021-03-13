using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ZoomLevel3Events : ZoomEventsTransition
	{
		public ZoomLevel3Events(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
