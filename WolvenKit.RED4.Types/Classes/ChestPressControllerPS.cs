using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChestPressControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<EngDemoContainer> _chestPressSkillChecks;
		private CName _factOnQHack;
		private CBool _wasWeighHacked;

		[Ordinal(104)] 
		[RED("chestPressSkillChecks")] 
		public CHandle<EngDemoContainer> ChestPressSkillChecks
		{
			get => GetProperty(ref _chestPressSkillChecks);
			set => SetProperty(ref _chestPressSkillChecks, value);
		}

		[Ordinal(105)] 
		[RED("factOnQHack")] 
		public CName FactOnQHack
		{
			get => GetProperty(ref _factOnQHack);
			set => SetProperty(ref _factOnQHack, value);
		}

		[Ordinal(106)] 
		[RED("wasWeighHacked")] 
		public CBool WasWeighHacked
		{
			get => GetProperty(ref _wasWeighHacked);
			set => SetProperty(ref _wasWeighHacked, value);
		}
	}
}
