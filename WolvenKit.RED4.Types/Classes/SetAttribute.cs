using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetAttribute : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("statLevel")] 
		public CFloat StatLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("attributeType")] 
		public CEnum<gamedataStatType> AttributeType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		public SetAttribute()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
