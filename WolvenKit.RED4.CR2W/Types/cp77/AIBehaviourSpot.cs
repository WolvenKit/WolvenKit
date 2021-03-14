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
			get
			{
				if (_behaviour == null)
				{
					_behaviour = (CHandle<AIResourceReference>) CR2WTypeManager.Create("handle:AIResourceReference", "behaviour", cr2w, this);
				}
				return _behaviour;
			}
			set
			{
				if (_behaviour == value)
				{
					return;
				}
				_behaviour = value;
				PropertySet(this);
			}
		}

		public AIBehaviourSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
