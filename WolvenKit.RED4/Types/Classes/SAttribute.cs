using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SAttribute : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("attributeName")] 
		public CEnum<gamedataStatType> AttributeName
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public SAttribute()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
