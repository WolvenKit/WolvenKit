using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISpiderbotFindBoredMovePosition : AIFindPositionAroundSelf
	{
		private CHandle<AIArgumentMapping> _maxWanderDistance;

		[Ordinal(6)] 
		[RED("maxWanderDistance")] 
		public CHandle<AIArgumentMapping> MaxWanderDistance
		{
			get
			{
				if (_maxWanderDistance == null)
				{
					_maxWanderDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "maxWanderDistance", cr2w, this);
				}
				return _maxWanderDistance;
			}
			set
			{
				if (_maxWanderDistance == value)
				{
					return;
				}
				_maxWanderDistance = value;
				PropertySet(this);
			}
		}

		public AISpiderbotFindBoredMovePosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
