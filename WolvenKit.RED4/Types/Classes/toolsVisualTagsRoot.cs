using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsVisualTagsRoot : ISerializable
	{
		[Ordinal(0)] 
		[RED("schemas")] 
		public CArray<toolsVisualTagsSchema> Schemas
		{
			get => GetPropertyValue<CArray<toolsVisualTagsSchema>>();
			set => SetPropertyValue<CArray<toolsVisualTagsSchema>>(value);
		}

		public toolsVisualTagsRoot()
		{
			Schemas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
