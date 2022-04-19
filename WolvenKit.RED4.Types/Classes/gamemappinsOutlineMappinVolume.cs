using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsOutlineMappinVolume : gamemappinsIMappinVolume
	{
		[Ordinal(0)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("outlinePoints")] 
		public CArray<Vector2> OutlinePoints
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}

		public gamemappinsOutlineMappinVolume()
		{
			OutlinePoints = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
