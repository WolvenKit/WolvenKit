using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FactInvokerControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("factDataEntries")] 
		public CArray<CHandle<FactInvokerDataEntry>> FactDataEntries
		{
			get => GetPropertyValue<CArray<CHandle<FactInvokerDataEntry>>>();
			set => SetPropertyValue<CArray<CHandle<FactInvokerDataEntry>>>(value);
		}

		[Ordinal(109)] 
		[RED("passwords")] 
		public CArray<CName> Passwords
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(110)] 
		[RED("arePasswordsInitialized")] 
		public CBool ArePasswordsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FactInvokerControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
