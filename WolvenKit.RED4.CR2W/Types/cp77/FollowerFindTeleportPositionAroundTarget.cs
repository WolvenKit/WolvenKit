using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FollowerFindTeleportPositionAroundTarget : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _outPositionArgument;
		private CFloat _lastResultTimestamp;

		[Ordinal(0)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get
			{
				if (_outPositionArgument == null)
				{
					_outPositionArgument = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outPositionArgument", cr2w, this);
				}
				return _outPositionArgument;
			}
			set
			{
				if (_outPositionArgument == value)
				{
					return;
				}
				_outPositionArgument = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lastResultTimestamp")] 
		public CFloat LastResultTimestamp
		{
			get
			{
				if (_lastResultTimestamp == null)
				{
					_lastResultTimestamp = (CFloat) CR2WTypeManager.Create("Float", "lastResultTimestamp", cr2w, this);
				}
				return _lastResultTimestamp;
			}
			set
			{
				if (_lastResultTimestamp == value)
				{
					return;
				}
				_lastResultTimestamp = value;
				PropertySet(this);
			}
		}

		public FollowerFindTeleportPositionAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
