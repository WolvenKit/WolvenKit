using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningEvent : redEvent
	{
		private CEnum<gameScanningState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameScanningState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameScanningState>) CR2WTypeManager.Create("gameScanningState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		public gameScanningEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
