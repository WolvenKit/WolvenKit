using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entVertexAnimationMapperEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sources", 4)] 
		public CStatic<entVertexAnimationMapperSource> Sources
		{
			get => GetPropertyValue<CStatic<entVertexAnimationMapperSource>>();
			set => SetPropertyValue<CStatic<entVertexAnimationMapperSource>>(value);
		}

		[Ordinal(1)] 
		[RED("destination")] 
		public entVertexAnimationMapperDestination Destination
		{
			get => GetPropertyValue<entVertexAnimationMapperDestination>();
			set => SetPropertyValue<entVertexAnimationMapperDestination>(value);
		}

		public entVertexAnimationMapperEntry()
		{
			Sources = new(4);
			Destination = new entVertexAnimationMapperDestination();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
