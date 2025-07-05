using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTaggedSignalUserDataDefinition : gameSignalUserDataDefinition
	{
		[Ordinal(0)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameTaggedSignalUserDataDefinition()
		{
			Tags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
