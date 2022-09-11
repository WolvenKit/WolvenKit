using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FilterRadioItemHoverOut : redEvent
	{
		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<inkWidget> Target
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(1)] 
		[RED("identifier")] 
		public CInt32 Identifier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public FilterRadioItemHoverOut()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
