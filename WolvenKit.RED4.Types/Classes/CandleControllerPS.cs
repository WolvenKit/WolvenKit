using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CandleControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<EngDemoContainer> _candleSkillChecks;

		[Ordinal(104)] 
		[RED("candleSkillChecks")] 
		public CHandle<EngDemoContainer> CandleSkillChecks
		{
			get => GetProperty(ref _candleSkillChecks);
			set => SetProperty(ref _candleSkillChecks, value);
		}
	}
}
