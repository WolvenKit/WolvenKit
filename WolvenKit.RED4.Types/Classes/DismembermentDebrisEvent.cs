using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DismembermentDebrisEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("resourcePath")] 
		public CString ResourcePath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DismembermentDebrisEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
