using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AITaggedAIEvent : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public AITaggedAIEvent()
		{
			Tags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
