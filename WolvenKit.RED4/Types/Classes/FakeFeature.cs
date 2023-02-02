using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FakeFeature : gameObject
	{
		[Ordinal(35)] 
		[RED("choices")] 
		public CArray<SFakeFeatureChoice> Choices
		{
			get => GetPropertyValue<CArray<SFakeFeatureChoice>>();
			set => SetPropertyValue<CArray<SFakeFeatureChoice>>(value);
		}

		[Ordinal(36)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(37)] 
		[RED("components")] 
		public CArray<CHandle<entIPlacedComponent>> Components
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(38)] 
		[RED("scaningComponent")] 
		public CHandle<gameScanningComponent> ScaningComponent
		{
			get => GetPropertyValue<CHandle<gameScanningComponent>>();
			set => SetPropertyValue<CHandle<gameScanningComponent>>(value);
		}

		[Ordinal(39)] 
		[RED("was_used")] 
		public CBool Was_used
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FakeFeature()
		{
			Choices = new();
			Components = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
