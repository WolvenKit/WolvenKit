using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPoolSpentPrereqState : gamePrereqState
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
	}
}
