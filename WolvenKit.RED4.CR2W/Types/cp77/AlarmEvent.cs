using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AlarmEvent : redEvent
	{
		private CBool _isValid;
		private gameDelayID _iD;

		[Ordinal(0)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get
			{
				if (_isValid == null)
				{
					_isValid = (CBool) CR2WTypeManager.Create("Bool", "isValid", cr2w, this);
				}
				return _isValid;
			}
			set
			{
				if (_isValid == value)
				{
					return;
				}
				_isValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ID")] 
		public gameDelayID ID
		{
			get
			{
				if (_iD == null)
				{
					_iD = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "ID", cr2w, this);
				}
				return _iD;
			}
			set
			{
				if (_iD == value)
				{
					return;
				}
				_iD = value;
				PropertySet(this);
			}
		}

		public AlarmEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
