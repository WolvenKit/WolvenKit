using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsCoverHitEvent : gameeventsHitEvent
	{
		private wCHandle<gameObject> _cover;

		[Ordinal(12)] 
		[RED("cover")] 
		public wCHandle<gameObject> Cover
		{
			get
			{
				if (_cover == null)
				{
					_cover = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "cover", cr2w, this);
				}
				return _cover;
			}
			set
			{
				if (_cover == value)
				{
					return;
				}
				_cover = value;
				PropertySet(this);
			}
		}

		public gameeventsCoverHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
