using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ObjectInspectEvent : redEvent
	{
		private CBool _showItem;

		[Ordinal(0)] 
		[RED("showItem")] 
		public CBool ShowItem
		{
			get => GetProperty(ref _showItem);
			set => SetProperty(ref _showItem, value);
		}

		public ObjectInspectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
