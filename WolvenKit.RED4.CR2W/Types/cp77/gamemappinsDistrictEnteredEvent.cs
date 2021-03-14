using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsDistrictEnteredEvent : gameScriptableSystemRequest
	{
		private CBool _entered;
		private CBool _sendNewLocationNotification;
		private TweakDBID _district;

		[Ordinal(0)] 
		[RED("entered")] 
		public CBool Entered
		{
			get
			{
				if (_entered == null)
				{
					_entered = (CBool) CR2WTypeManager.Create("Bool", "entered", cr2w, this);
				}
				return _entered;
			}
			set
			{
				if (_entered == value)
				{
					return;
				}
				_entered = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sendNewLocationNotification")] 
		public CBool SendNewLocationNotification
		{
			get
			{
				if (_sendNewLocationNotification == null)
				{
					_sendNewLocationNotification = (CBool) CR2WTypeManager.Create("Bool", "sendNewLocationNotification", cr2w, this);
				}
				return _sendNewLocationNotification;
			}
			set
			{
				if (_sendNewLocationNotification == value)
				{
					return;
				}
				_sendNewLocationNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("district")] 
		public TweakDBID District
		{
			get
			{
				if (_district == null)
				{
					_district = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "district", cr2w, this);
				}
				return _district;
			}
			set
			{
				if (_district == value)
				{
					return;
				}
				_district = value;
				PropertySet(this);
			}
		}

		public gamemappinsDistrictEnteredEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
