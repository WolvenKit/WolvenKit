using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ParentTransform : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("mapping")] 
		public CArray<animAnimTransformMappingEntry> Mapping
		{
			get => GetPropertyValue<CArray<animAnimTransformMappingEntry>>();
			set => SetPropertyValue<CArray<animAnimTransformMappingEntry>>(value);
		}

		public animAnimNode_ParentTransform()
		{
			Id = 4294967295;
			InputLink = new();
			Mapping = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
