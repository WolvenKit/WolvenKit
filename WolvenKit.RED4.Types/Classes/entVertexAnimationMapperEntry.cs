using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVertexAnimationMapperEntry : RedBaseClass
	{
		private CStatic<entVertexAnimationMapperSource> _sources;
		private entVertexAnimationMapperDestination _destination;

		[Ordinal(0)] 
		[RED("sources", 4)] 
		public CStatic<entVertexAnimationMapperSource> Sources
		{
			get => GetProperty(ref _sources);
			set => SetProperty(ref _sources, value);
		}

		[Ordinal(1)] 
		[RED("destination")] 
		public entVertexAnimationMapperDestination Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}
	}
}
