using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddDevelopmentPoints : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("amountOfPoints")] 
		public CInt32 AmountOfPoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("developmentPointType")] 
		public CEnum<gamedataDevelopmentPointType> DevelopmentPointType
		{
			get => GetPropertyValue<CEnum<gamedataDevelopmentPointType>>();
			set => SetPropertyValue<CEnum<gamedataDevelopmentPointType>>(value);
		}

		public AddDevelopmentPoints()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
