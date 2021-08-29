using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddDevelopmentPoints : gamePlayerScriptableSystemRequest
	{
		private CInt32 _amountOfPoints;
		private CEnum<gamedataDevelopmentPointType> _developmentPointType;

		[Ordinal(1)] 
		[RED("amountOfPoints")] 
		public CInt32 AmountOfPoints
		{
			get => GetProperty(ref _amountOfPoints);
			set => SetProperty(ref _amountOfPoints, value);
		}

		[Ordinal(2)] 
		[RED("developmentPointType")] 
		public CEnum<gamedataDevelopmentPointType> DevelopmentPointType
		{
			get => GetProperty(ref _developmentPointType);
			set => SetProperty(ref _developmentPointType, value);
		}
	}
}
