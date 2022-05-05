using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInputHintGroupData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("iconReference")] 
		public TweakDBID IconReference
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("localizedTitle")] 
		public CString LocalizedTitle
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("localizedDescription")] 
		public CString LocalizedDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("sortingPriority")] 
		public CInt32 SortingPriority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiInputHintGroupData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
