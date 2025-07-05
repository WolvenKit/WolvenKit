using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsQueryPresetDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("queryGroups")] 
		public CArray<CName> QueryGroups
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public physicsQueryPresetDefinition()
		{
			QueryGroups = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
