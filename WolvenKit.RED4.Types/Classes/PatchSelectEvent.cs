using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PatchSelectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PatchSelectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
