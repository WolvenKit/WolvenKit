using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClearVisibilityInAnimSystemRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public ClearVisibilityInAnimSystemRequest()
		{
			EntityID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
