using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBehaviourSpot : AISmartSpot
	{
		private CHandle<AIResourceReference> _behaviour;

		[Ordinal(0)] 
		[RED("behaviour")] 
		public CHandle<AIResourceReference> Behaviour
		{
			get => GetProperty(ref _behaviour);
			set => SetProperty(ref _behaviour, value);
		}

		public AIBehaviourSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
