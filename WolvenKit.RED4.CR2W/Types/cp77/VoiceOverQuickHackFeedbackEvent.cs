using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VoiceOverQuickHackFeedbackEvent : redEvent
	{
		private CName _voName;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("voName")] 
		public CName VoName
		{
			get
			{
				if (_voName == null)
				{
					_voName = (CName) CR2WTypeManager.Create("CName", "voName", cr2w, this);
				}
				return _voName;
			}
			set
			{
				if (_voName == value)
				{
					return;
				}
				_voName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public VoiceOverQuickHackFeedbackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
