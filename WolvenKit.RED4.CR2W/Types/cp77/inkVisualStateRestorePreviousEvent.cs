using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVisualStateRestorePreviousEvent : redEvent
	{
		private CName _visualState;

		[Ordinal(0)] 
		[RED("visualState")] 
		public CName VisualState
		{
			get
			{
				if (_visualState == null)
				{
					_visualState = (CName) CR2WTypeManager.Create("CName", "visualState", cr2w, this);
				}
				return _visualState;
			}
			set
			{
				if (_visualState == value)
				{
					return;
				}
				_visualState = value;
				PropertySet(this);
			}
		}

		public inkVisualStateRestorePreviousEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
