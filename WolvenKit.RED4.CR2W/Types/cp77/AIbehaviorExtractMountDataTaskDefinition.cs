using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExtractMountDataTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _mountEventData;
		private CHandle<AIArgumentMapping> _outWorkspotData;
		private CHandle<AIArgumentMapping> _outIsInstant;

		[Ordinal(1)] 
		[RED("mountEventData")] 
		public CHandle<AIArgumentMapping> MountEventData
		{
			get
			{
				if (_mountEventData == null)
				{
					_mountEventData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "mountEventData", cr2w, this);
				}
				return _mountEventData;
			}
			set
			{
				if (_mountEventData == value)
				{
					return;
				}
				_mountEventData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("outIsInstant")] 
		public CHandle<AIArgumentMapping> OutIsInstant
		{
			get
			{
				if (_outIsInstant == null)
				{
					_outIsInstant = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outIsInstant", cr2w, this);
				}
				return _outIsInstant;
			}
			set
			{
				if (_outIsInstant == value)
				{
					return;
				}
				_outIsInstant = value;
				PropertySet(this);
			}
		}

		public AIbehaviorExtractMountDataTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
