using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFSMTransitionDefinition : CVariable
	{
		private CUInt16 _destination;
		private CUInt16 _condition;

		[Ordinal(0)] 
		[RED("destination")] 
		public CUInt16 Destination
		{
			get
			{
				if (_destination == null)
				{
					_destination = (CUInt16) CR2WTypeManager.Create("Uint16", "destination", cr2w, this);
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

		[Ordinal(1)] 
		[RED("condition")] 
		public CUInt16 Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CUInt16) CR2WTypeManager.Create("Uint16", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		public AIFSMTransitionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
