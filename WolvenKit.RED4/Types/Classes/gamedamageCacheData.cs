using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedamageCacheData : IScriptable
	{
		[Ordinal(0)] 
		[RED("targetImmortalityMode")] 
		public CEnum<gameGodModeType> TargetImmortalityMode
		{
			get => GetPropertyValue<CEnum<gameGodModeType>>();
			set => SetPropertyValue<CEnum<gameGodModeType>>(value);
		}

		[Ordinal(1)] 
		[RED("TEMP_ImmortalityCached")] 
		public CBool TEMP_ImmortalityCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("logFlags")] 
		public CInt64 LogFlags
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		public gamedamageCacheData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
