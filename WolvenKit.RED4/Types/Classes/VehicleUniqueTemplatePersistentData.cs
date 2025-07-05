using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleUniqueTemplatePersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("modelName")] 
		public CName ModelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("templatesID")] 
		public CArray<TweakDBID> TemplatesID
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public VehicleUniqueTemplatePersistentData()
		{
			TemplatesID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
