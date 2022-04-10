using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkHudEntryInfo : inkUserData
	{
		[Ordinal(0)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public Vector2 Offset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public inkHudEntryInfo()
		{
			Size = new();
			Offset = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
