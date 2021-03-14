using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSaveEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		private CHandle<AIArgumentMapping> _eventData;

		[Ordinal(0)] 
		[RED("eventData")] 
		public CHandle<AIArgumentMapping> EventData
		{
			get
			{
				if (_eventData == null)
				{
					_eventData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "eventData", cr2w, this);
				}
				return _eventData;
			}
			set
			{
				if (_eventData == value)
				{
					return;
				}
				_eventData = value;
				PropertySet(this);
			}
		}

		public AIbehaviorSaveEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
