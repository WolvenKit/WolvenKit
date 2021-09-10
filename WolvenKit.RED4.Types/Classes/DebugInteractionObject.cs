using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DebugInteractionObject : gameObject
	{
		[Ordinal(40)] 
		[RED("choices")] 
		public CArray<SDebugChoice> Choices
		{
			get => GetPropertyValue<CArray<SDebugChoice>>();
			set => SetPropertyValue<CArray<SDebugChoice>>(value);
		}

		[Ordinal(41)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		public DebugInteractionObject()
		{
			Choices = new();
		}
	}
}
