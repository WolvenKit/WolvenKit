using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSceneRecordingContentObserverNode : worldNode
	{
		private worldSceneRecordingNodeFilter _filter;

		[Ordinal(4)] 
		[RED("filter")] 
		public worldSceneRecordingNodeFilter Filter
		{
			get
			{
				if (_filter == null)
				{
					_filter = (worldSceneRecordingNodeFilter) CR2WTypeManager.Create("worldSceneRecordingNodeFilter", "filter", cr2w, this);
				}
				return _filter;
			}
			set
			{
				if (_filter == value)
				{
					return;
				}
				_filter = value;
				PropertySet(this);
			}
		}

		public worldSceneRecordingContentObserverNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
