using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExtractVehicleSlotWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _outWorkspotData;

		[Ordinal(1)] 
		[RED("outWorkspotData")] 
		public CHandle<AIArgumentMapping> OutWorkspotData
		{
			get
			{
				if (_outWorkspotData == null)
				{
					_outWorkspotData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outWorkspotData", cr2w, this);
				}
				return _outWorkspotData;
			}
			set
			{
				if (_outWorkspotData == value)
				{
					return;
				}
				_outWorkspotData = value;
				PropertySet(this);
			}
		}

		public AIbehaviorExtractVehicleSlotWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
