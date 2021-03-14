using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectPrereqListener : gameScriptStatusEffectListener
	{
		private wCHandle<StatusEffectPrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public wCHandle<StatusEffectPrereqState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (wCHandle<StatusEffectPrereqState>) CR2WTypeManager.Create("whandle:StatusEffectPrereqState", "state", cr2w, this);
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

		public StatusEffectPrereqListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
