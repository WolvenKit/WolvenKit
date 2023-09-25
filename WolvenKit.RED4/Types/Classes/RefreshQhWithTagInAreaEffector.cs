using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RefreshQhWithTagInAreaEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public RefreshQhWithTagInAreaEffector()
		{
			Tags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
