using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DebugInteractionObject : gameObject
	{
		[Ordinal(36)] 
		[RED("choices")] 
		public CArray<SDebugChoice> Choices
		{
			get => GetPropertyValue<CArray<SDebugChoice>>();
			set => SetPropertyValue<CArray<SDebugChoice>>(value);
		}

		[Ordinal(37)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		public DebugInteractionObject()
		{
			Choices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
