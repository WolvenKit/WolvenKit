using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class graphGraphSocketDefinition : graphIGraphObjectDefinition
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("connections")] 
		public CArray<CHandle<graphGraphConnectionDefinition>> Connections
		{
			get => GetPropertyValue<CArray<CHandle<graphGraphConnectionDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<graphGraphConnectionDefinition>>>(value);
		}

		public graphGraphSocketDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
