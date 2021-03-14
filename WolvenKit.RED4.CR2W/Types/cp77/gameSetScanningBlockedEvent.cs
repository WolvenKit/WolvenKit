using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetScanningBlockedEvent : redEvent
	{
		private CBool _isBlocked;

		[Ordinal(0)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get
			{
				if (_isBlocked == null)
				{
					_isBlocked = (CBool) CR2WTypeManager.Create("Bool", "isBlocked", cr2w, this);
				}
				return _isBlocked;
			}
			set
			{
				if (_isBlocked == value)
				{
					return;
				}
				_isBlocked = value;
				PropertySet(this);
			}
		}

		public gameSetScanningBlockedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
