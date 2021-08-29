using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSceneTier2Data : gameSceneTierData
	{
		private CEnum<Tier2WalkType> _walkType;

		[Ordinal(2)] 
		[RED("walkType")] 
		public CEnum<Tier2WalkType> WalkType
		{
			get => GetProperty(ref _walkType);
			set => SetProperty(ref _walkType, value);
		}
	}
}
