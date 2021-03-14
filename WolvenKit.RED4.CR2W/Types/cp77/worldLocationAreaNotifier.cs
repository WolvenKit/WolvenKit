using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldLocationAreaNotifier : worldITriggerAreaNotifer
	{
		private TweakDBID _districtID;
		private CBool _sendNewLocationNotification;

		[Ordinal(3)] 
		[RED("districtID")] 
		public TweakDBID DistrictID
		{
			get
			{
				if (_districtID == null)
				{
					_districtID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "districtID", cr2w, this);
				}
				return _districtID;
			}
			set
			{
				if (_districtID == value)
				{
					return;
				}
				_districtID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		public worldLocationAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
