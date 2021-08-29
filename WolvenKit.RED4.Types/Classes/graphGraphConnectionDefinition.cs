using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class graphGraphConnectionDefinition : graphIGraphObjectDefinition
	{
		private CWeakHandle<graphGraphSocketDefinition> _source;
		private CWeakHandle<graphGraphSocketDefinition> _destination;

		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<graphGraphSocketDefinition> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("destination")] 
		public CWeakHandle<graphGraphSocketDefinition> Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}
	}
}
