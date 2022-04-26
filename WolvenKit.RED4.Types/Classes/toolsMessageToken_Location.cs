using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsMessageToken_Location : toolsIMessageToken
	{
		[Ordinal(0)] 
		[RED("location")] 
		public CHandle<toolsIMessageLocation> Location
		{
			get => GetPropertyValue<CHandle<toolsIMessageLocation>>();
			set => SetPropertyValue<CHandle<toolsIMessageLocation>>(value);
		}

		public toolsMessageToken_Location()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
