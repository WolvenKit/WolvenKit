using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIScriptableSystemAttributeLevel : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stat")] 
		public CEnum<gamedataStatType> Stat
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public UIScriptableSystemAttributeLevel()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
