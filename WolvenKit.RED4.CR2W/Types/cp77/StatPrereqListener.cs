using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPrereqListener : gameScriptStatsListener
	{
		private wCHandle<StatPrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public wCHandle<StatPrereqState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (wCHandle<StatPrereqState>) CR2WTypeManager.Create("whandle:StatPrereqState", "state", cr2w, this);
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

		public StatPrereqListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
