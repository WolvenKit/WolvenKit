using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerksMenuProficiencyItemClicked : PerksMenuAttributeItemClicked
	{
		[Ordinal(4)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PerksMenuProficiencyItemClicked()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
