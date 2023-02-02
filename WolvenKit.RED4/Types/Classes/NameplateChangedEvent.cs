using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NameplateChangedEvent : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("entity")] 
		public entEntityID Entity
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public NameplateChangedEvent()
		{
			Entity = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
