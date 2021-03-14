using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolPrereqListener : BaseStatPoolPrereqListener
	{
		private wCHandle<StatPoolPrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public wCHandle<StatPoolPrereqState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (wCHandle<StatPoolPrereqState>) CR2WTypeManager.Create("whandle:StatPoolPrereqState", "state", cr2w, this);
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

		public StatPoolPrereqListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
