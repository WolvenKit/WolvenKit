using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationMapperEntry : CVariable
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

		public entVertexAnimationMapperEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
