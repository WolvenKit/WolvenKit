using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConstantStatPoolPrereqListener : BaseStatPoolPrereqListener
	{
		private wCHandle<ConstantStatPoolPrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public wCHandle<ConstantStatPoolPrereqState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (wCHandle<ConstantStatPoolPrereqState>) CR2WTypeManager.Create("whandle:ConstantStatPoolPrereqState", "state", cr2w, this);
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

		public ConstantStatPoolPrereqListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
