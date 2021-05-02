using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class graphGraphConnectionDefinition : graphIGraphObjectDefinition
	{
		private wCHandle<graphGraphSocketDefinition> _source;
		private wCHandle<graphGraphSocketDefinition> _destination;

		[Ordinal(0)] 
		[RED("source")] 
		public wCHandle<graphGraphSocketDefinition> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("destination")] 
		public wCHandle<graphGraphSocketDefinition> Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}

		public graphGraphConnectionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
