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
			get => GetProperty(ref _neededValue);
			set => SetProperty(ref _neededValue, value);
		}

		[Ordinal(1)] 
		[RED("listener")] 
		public CHandle<BaseStatPoolPrereqListener> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		public StatPoolSpentPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
