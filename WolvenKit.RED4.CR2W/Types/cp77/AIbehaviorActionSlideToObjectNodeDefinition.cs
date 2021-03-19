using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSlideToObjectNodeDefinition : AIbehaviorActionSlideNodeDefinition
	{
		private CHandle<AIArgumentMapping> _destination;
		private CHandle<AIArgumentMapping> _offset;

		[Ordinal(4)] 
		[RED("destination")] 
		public CHandle<AIArgumentMapping> Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}

		[Ordinal(5)] 
		[RED("offset")] 
		public CHandle<AIArgumentMapping> Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		public AIbehaviorActionSlideToObjectNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
