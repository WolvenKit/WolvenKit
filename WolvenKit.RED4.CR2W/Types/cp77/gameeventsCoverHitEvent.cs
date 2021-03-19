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
			get => GetProperty(ref _cover);
			set => SetProperty(ref _cover, value);
		}

		public gameeventsCoverHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
