using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningModeEvent : redEvent
	{
		private CEnum<gameScanningMode> _mode;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<gameScanningMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<gameScanningMode>) CR2WTypeManager.Create("gameScanningMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		public gameScanningModeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
