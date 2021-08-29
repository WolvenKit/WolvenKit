using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DebugInteractionObject : gameObject
	{
		private CArray<SDebugChoice> _choices;
		private CHandle<gameinteractionsComponent> _interaction;

		[Ordinal(40)] 
		[RED("choices")] 
		public CArray<SDebugChoice> Choices
		{
			get => GetProperty(ref _choices);
			set => SetProperty(ref _choices, value);
		}

		[Ordinal(41)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetProperty(ref _interaction);
			set => SetProperty(ref _interaction, value);
		}
	}
}
