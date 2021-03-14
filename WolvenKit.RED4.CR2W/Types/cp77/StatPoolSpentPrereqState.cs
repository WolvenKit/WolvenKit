using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolSpentPrereqState : gamePrereqState
	{
		private CFloat _neededValue;
		private CHandle<BaseStatPoolPrereqListener> _listener;

		[Ordinal(0)] 
		[RED("neededValue")] 
		public CFloat NeededValue
		{
			get
			{
				if (_neededValue == null)
				{
					_neededValue = (CFloat) CR2WTypeManager.Create("Float", "neededValue", cr2w, this);
				}
				return _neededValue;
			}
			set
			{
				if (_neededValue == value)
				{
					return;
				}
				_neededValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("listener")] 
		public CHandle<BaseStatPoolPrereqListener> Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (CHandle<BaseStatPoolPrereqListener>) CR2WTypeManager.Create("handle:BaseStatPoolPrereqListener", "listener", cr2w, this);
				}
				return _listener;
			}
			set
			{
				if (_listener == value)
				{
					return;
				}
				_listener = value;
				PropertySet(this);
			}
		}

		public StatPoolSpentPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
