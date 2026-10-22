using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkModioModRating : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CInt64 Id
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(1)] 
		[RED("rating")] 
		public CEnum<inkModioRating> Rating
		{
			get => GetPropertyValue<CEnum<inkModioRating>>();
			set => SetPropertyValue<CEnum<inkModioRating>>(value);
		}

		public inkModioModRating()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
