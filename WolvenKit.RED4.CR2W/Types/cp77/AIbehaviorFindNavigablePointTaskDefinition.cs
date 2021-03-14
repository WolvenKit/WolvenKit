using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindNavigablePointTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _destination;
		private CHandle<AIArgumentMapping> _outAdjustedDestination;
		private CHandle<AIArgumentMapping> _outWasAdjusted;

		[Ordinal(1)] 
		[RED("destination")] 
		public CHandle<AIArgumentMapping> Destination
		{
			get
			{
				if (_destination == null)
				{
					_destination = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "destination", cr2w, this);
				}
				return _destination;
			}
			set
			{
				if (_destination == value)
				{
					return;
				}
				_destination = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outAdjustedDestination")] 
		public CHandle<AIArgumentMapping> OutAdjustedDestination
		{
			get
			{
				if (_outAdjustedDestination == null)
				{
					_outAdjustedDestination = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outAdjustedDestination", cr2w, this);
				}
				return _outAdjustedDestination;
			}
			set
			{
				if (_outAdjustedDestination == value)
				{
					return;
				}
				_outAdjustedDestination = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("outWasAdjusted")] 
		public CHandle<AIArgumentMapping> OutWasAdjusted
		{
			get
			{
				if (_outWasAdjusted == null)
				{
					_outWasAdjusted = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outWasAdjusted", cr2w, this);
				}
				return _outWasAdjusted;
			}
			set
			{
				if (_outWasAdjusted == value)
				{
					return;
				}
				_outWasAdjusted = value;
				PropertySet(this);
			}
		}

		public AIbehaviorFindNavigablePointTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
