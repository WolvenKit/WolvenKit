using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsObjectMarkerVisibilityUpdated : redEvent
	{
		private CBool _canHaveObjectMarker;
		private CBool _isVisible;

		[Ordinal(0)] 
		[RED("canHaveObjectMarker")] 
		public CBool CanHaveObjectMarker
		{
			get
			{
				if (_canHaveObjectMarker == null)
				{
					_canHaveObjectMarker = (CBool) CR2WTypeManager.Create("Bool", "canHaveObjectMarker", cr2w, this);
				}
				return _canHaveObjectMarker;
			}
			set
			{
				if (_canHaveObjectMarker == value)
				{
					return;
				}
				_canHaveObjectMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get
			{
				if (_isVisible == null)
				{
					_isVisible = (CBool) CR2WTypeManager.Create("Bool", "isVisible", cr2w, this);
				}
				return _isVisible;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				_isVisible = value;
				PropertySet(this);
			}
		}

		public gameeventsObjectMarkerVisibilityUpdated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
