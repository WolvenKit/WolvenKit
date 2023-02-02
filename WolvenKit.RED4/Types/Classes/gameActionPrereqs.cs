using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionPrereqs : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("prereqs")] 
		public CArray<CHandle<gameIPrereq>> Prereqs
		{
			get => GetPropertyValue<CArray<CHandle<gameIPrereq>>>();
			set => SetPropertyValue<CArray<CHandle<gameIPrereq>>>(value);
		}

		public gameActionPrereqs()
		{
			Prereqs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
