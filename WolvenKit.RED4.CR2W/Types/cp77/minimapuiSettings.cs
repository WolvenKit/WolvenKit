using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class minimapuiSettings : CVariable
	{
		private CFloat _showTime;
		private CFloat _hideTime;

		[Ordinal(0)] 
		[RED("showTime")] 
		public CFloat ShowTime
		{
			get
			{
				if (_showTime == null)
				{
					_showTime = (CFloat) CR2WTypeManager.Create("Float", "showTime", cr2w, this);
				}
				return _showTime;
			}
			set
			{
				if (_showTime == value)
				{
					return;
				}
				_showTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hideTime")] 
		public CFloat HideTime
		{
			get
			{
				if (_hideTime == null)
				{
					_hideTime = (CFloat) CR2WTypeManager.Create("Float", "hideTime", cr2w, this);
				}
				return _hideTime;
			}
			set
			{
				if (_hideTime == value)
				{
					return;
				}
				_hideTime = value;
				PropertySet(this);
			}
		}

		public minimapuiSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
