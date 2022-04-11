using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entExternalComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("externalComponentName")] 
		public CName ExternalComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entExternalComponent()
		{
			Name = "Component";
		}
	}
}
