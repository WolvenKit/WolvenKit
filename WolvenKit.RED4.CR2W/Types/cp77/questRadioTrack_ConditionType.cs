using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRadioTrack_ConditionType : questISystemConditionType
	{
		private CName _radioTrack;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("radioTrack")] 
		public CName RadioTrack
		{
			get
			{
				if (_radioTrack == null)
				{
					_radioTrack = (CName) CR2WTypeManager.Create("CName", "radioTrack", cr2w, this);
				}
				return _radioTrack;
			}
			set
			{
				if (_radioTrack == value)
				{
					return;
				}
				_radioTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		public questRadioTrack_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
