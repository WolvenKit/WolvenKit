using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FakeFeature : gameObject
	{
		private CArray<SFakeFeatureChoice> _choices;
		private CHandle<gameinteractionsComponent> _interaction;
		private CArray<CHandle<entIPlacedComponent>> _components;
		private CHandle<gameScanningComponent> _scaningComponent;
		private CBool _was_used;

		[Ordinal(40)] 
		[RED("choices")] 
		public CArray<SFakeFeatureChoice> Choices
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

		[Ordinal(42)] 
		[RED("components")] 
		public CArray<CHandle<entIPlacedComponent>> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}

		[Ordinal(43)] 
		[RED("scaningComponent")] 
		public CHandle<gameScanningComponent> ScaningComponent
		{
			get => GetProperty(ref _scaningComponent);
			set => SetProperty(ref _scaningComponent, value);
		}

		[Ordinal(44)] 
		[RED("was_used")] 
		public CBool Was_used
		{
			get => GetProperty(ref _was_used);
			set => SetProperty(ref _was_used, value);
		}
	}
}
