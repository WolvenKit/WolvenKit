using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorWidgetCustomData : WidgetCustomData
	{
		private CInt32 _passcode;
		private CName _card;
		private CBool _isPasswordKnown;

		[Ordinal(0)] 
		[RED("passcode")] 
		public CInt32 Passcode
		{
			get
			{
				if (_passcode == null)
				{
					_passcode = (CInt32) CR2WTypeManager.Create("Int32", "passcode", cr2w, this);
				}
				return _passcode;
			}
			set
			{
				if (_passcode == value)
				{
					return;
				}
				_passcode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("card")] 
		public CName Card
		{
			get
			{
				if (_card == null)
				{
					_card = (CName) CR2WTypeManager.Create("CName", "card", cr2w, this);
				}
				return _card;
			}
			set
			{
				if (_card == value)
				{
					return;
				}
				_card = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isPasswordKnown")] 
		public CBool IsPasswordKnown
		{
			get
			{
				if (_isPasswordKnown == null)
				{
					_isPasswordKnown = (CBool) CR2WTypeManager.Create("Bool", "isPasswordKnown", cr2w, this);
				}
				return _isPasswordKnown;
			}
			set
			{
				if (_isPasswordKnown == value)
				{
					return;
				}
				_isPasswordKnown = value;
				PropertySet(this);
			}
		}

		public DoorWidgetCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
