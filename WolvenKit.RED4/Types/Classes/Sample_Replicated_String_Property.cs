using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Sample_Replicated_String_Property : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("property")] 
		public CString Property
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public Sample_Replicated_String_Property()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
