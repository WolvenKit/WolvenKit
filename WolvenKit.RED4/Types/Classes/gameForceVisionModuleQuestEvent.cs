using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameForceVisionModuleQuestEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("moduleName")] 
		public CName ModuleName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("meshComponentNames")] 
		public CArray<CName> MeshComponentNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameForceVisionModuleQuestEvent()
		{
			MeshComponentNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
