using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelPointsUpdated : redEvent
	{
		private CBool _updateTrackingAlternative;

		[Ordinal(0)] 
		[RED("updateTrackingAlternative")] 
		public CBool UpdateTrackingAlternative
		{
			get
			{
				if (_updateTrackingAlternative == null)
				{
					_updateTrackingAlternative = (CBool) CR2WTypeManager.Create("Bool", "updateTrackingAlternative", cr2w, this);
				}
				return _updateTrackingAlternative;
			}
			set
			{
				if (_updateTrackingAlternative == value)
				{
					return;
				}
				_updateTrackingAlternative = value;
				PropertySet(this);
			}
		}

		public FastTravelPointsUpdated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
