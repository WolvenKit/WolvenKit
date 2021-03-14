using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEntityReuseEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		private CHandle<AIArgumentMapping> _destination;
		private CHandle<AIArgumentMapping> _fastForwardAfterTeleport;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get
			{
				if (_fastForwardAfterTeleport == null)
				{
					_fastForwardAfterTeleport = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "fastForwardAfterTeleport", cr2w, this);
				}
				return _fastForwardAfterTeleport;
			}
			set
			{
				if (_fastForwardAfterTeleport == value)
				{
					return;
				}
				_fastForwardAfterTeleport = value;
				PropertySet(this);
			}
		}

		public AIbehaviorEntityReuseEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
