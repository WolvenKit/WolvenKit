using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StaticPlatform : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("componentsToToggleNames")] 
		public CArray<CName> ComponentsToToggleNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(99)] 
		[RED("meshName")] 
		public CName MeshName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(100)] 
		[RED("sfxOnEnable")] 
		public CName SfxOnEnable
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(101)] 
		[RED("componentsToToggle")] 
		public CArray<CHandle<entIComponent>> ComponentsToToggle
		{
			get => GetPropertyValue<CArray<CHandle<entIComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIComponent>>>(value);
		}

		public StaticPlatform()
		{
			ControllerTypeName = "StaticPlatformController";
			ComponentsToToggleNames = new();
			ComponentsToToggle = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
