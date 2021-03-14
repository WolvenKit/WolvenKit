using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ZoomBlockedEvents : ZoomEventsTransition
	{
		private CEnum<vehicleCameraPerspective> _previousCameraPerspective;
		private CBool _previousCameraPerspectiveValid;

		[Ordinal(0)] 
		[RED("previousCameraPerspective")] 
		public CEnum<vehicleCameraPerspective> PreviousCameraPerspective
		{
			get
			{
				if (_previousCameraPerspective == null)
				{
					_previousCameraPerspective = (CEnum<vehicleCameraPerspective>) CR2WTypeManager.Create("vehicleCameraPerspective", "previousCameraPerspective", cr2w, this);
				}
				return _previousCameraPerspective;
			}
			set
			{
				if (_previousCameraPerspective == value)
				{
					return;
				}
				_previousCameraPerspective = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("previousCameraPerspectiveValid")] 
		public CBool PreviousCameraPerspectiveValid
		{
			get
			{
				if (_previousCameraPerspectiveValid == null)
				{
					_previousCameraPerspectiveValid = (CBool) CR2WTypeManager.Create("Bool", "previousCameraPerspectiveValid", cr2w, this);
				}
				return _previousCameraPerspectiveValid;
			}
			set
			{
				if (_previousCameraPerspectiveValid == value)
				{
					return;
				}
				_previousCameraPerspectiveValid = value;
				PropertySet(this);
			}
		}

		public ZoomBlockedEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
