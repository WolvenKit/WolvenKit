using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimeSkipPopupCloseData : inkGameNotificationData
	{
		private CBool _timeChanged;

		[Ordinal(6)] 
		[RED("timeChanged")] 
		public CBool TimeChanged
		{
			get
			{
				if (_timeChanged == null)
				{
					_timeChanged = (CBool) CR2WTypeManager.Create("Bool", "timeChanged", cr2w, this);
				}
				return _timeChanged;
			}
			set
			{
				if (_timeChanged == value)
				{
					return;
				}
				_timeChanged = value;
				PropertySet(this);
			}
		}

		public TimeSkipPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
