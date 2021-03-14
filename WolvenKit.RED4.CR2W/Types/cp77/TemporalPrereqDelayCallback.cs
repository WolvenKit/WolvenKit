using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TemporalPrereqDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private wCHandle<TemporalPrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public wCHandle<TemporalPrereqState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (wCHandle<TemporalPrereqState>) CR2WTypeManager.Create("whandle:TemporalPrereqState", "state", cr2w, this);
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

		public TemporalPrereqDelayCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
