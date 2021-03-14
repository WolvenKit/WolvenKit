using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindAlertedWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _usedTokens;
		private CHandle<AIArgumentMapping> _spots;
		private CHandle<AIArgumentMapping> _radius;
		private CHandle<AIArgumentMapping> _outWorkspotData;

		[Ordinal(1)] 
		[RED("usedTokens")] 
		public CHandle<AIArgumentMapping> UsedTokens
		{
			get
			{
				if (_usedTokens == null)
				{
					_usedTokens = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "usedTokens", cr2w, this);
				}
				return _usedTokens;
			}
			set
			{
				if (_usedTokens == value)
				{
					return;
				}
				_usedTokens = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spots")] 
		public CHandle<AIArgumentMapping> Spots
		{
			get
			{
				if (_spots == null)
				{
					_spots = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "spots", cr2w, this);
				}
				return _spots;
			}
			set
			{
				if (_spots == value)
				{
					return;
				}
				_spots = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CHandle<AIArgumentMapping> Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		public AIbehaviorFindAlertedWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
