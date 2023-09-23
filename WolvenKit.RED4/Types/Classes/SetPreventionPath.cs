using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetPreventionPath : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("blockSpawnFrom")] 
		public CEnum<EVehicleSpawnBlockSide> BlockSpawnFrom
		{
			get => GetPropertyValue<CEnum<EVehicleSpawnBlockSide>>();
			set => SetPropertyValue<CEnum<EVehicleSpawnBlockSide>>(value);
		}

		[Ordinal(1)] 
		[RED("resetToDefault")] 
		public CBool ResetToDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SetPreventionPath()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
