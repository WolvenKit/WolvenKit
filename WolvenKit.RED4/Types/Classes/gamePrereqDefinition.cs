using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePrereqDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("prereqName")] 
		public CName PrereqName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("prereq")] 
		public CHandle<gameIPrereq> Prereq
		{
			get => GetPropertyValue<CHandle<gameIPrereq>>();
			set => SetPropertyValue<CHandle<gameIPrereq>>(value);
		}

		public gamePrereqDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
