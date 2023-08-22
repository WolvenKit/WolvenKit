using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entTemplateComponentBackendDataOverrideInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public Vector2 Offset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public entTemplateComponentBackendDataOverrideInfo()
		{
			Offset = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
