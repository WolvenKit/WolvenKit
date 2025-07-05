using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entVertexAnimationMapper : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<entVertexAnimationMapperEntry> Entries
		{
			get => GetPropertyValue<CArray<entVertexAnimationMapperEntry>>();
			set => SetPropertyValue<CArray<entVertexAnimationMapperEntry>>(value);
		}

		public entVertexAnimationMapper()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
