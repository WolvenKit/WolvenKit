using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShowUIWarningEffector : gameEffector
	{
		private CFloat _duration;
		private CString _primaryText;
		private CString _secondaryText;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("primaryText")] 
		public CString PrimaryText
		{
			get
			{
				if (_primaryText == null)
				{
					_primaryText = (CString) CR2WTypeManager.Create("String", "primaryText", cr2w, this);
				}
				return _primaryText;
			}
			set
			{
				if (_primaryText == value)
				{
					return;
				}
				_primaryText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("secondaryText")] 
		public CString SecondaryText
		{
			get
			{
				if (_secondaryText == null)
				{
					_secondaryText = (CString) CR2WTypeManager.Create("String", "secondaryText", cr2w, this);
				}
				return _secondaryText;
			}
			set
			{
				if (_secondaryText == value)
				{
					return;
				}
				_secondaryText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public ShowUIWarningEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
