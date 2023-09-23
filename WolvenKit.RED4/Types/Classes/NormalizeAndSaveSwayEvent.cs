using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NormalizeAndSaveSwayEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("sway")] 
		public Vector2 Sway
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public NormalizeAndSaveSwayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
