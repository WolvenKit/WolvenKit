using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionMinMaxHeatLevels : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("minLvl")] 
		public CInt32 MinLvl
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("maxLvl")] 
		public CInt32 MaxLvl
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("isDefault")] 
		public CBool IsDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PreventionMinMaxHeatLevels()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
