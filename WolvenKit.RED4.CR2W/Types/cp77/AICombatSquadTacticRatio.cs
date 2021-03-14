using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICombatSquadTacticRatio : CVariable
	{
		private CFloat _ratioSum;
		private CFloat _reachSum;
		private CFloat _area;

		[Ordinal(0)] 
		[RED("ratioSum")] 
		public CFloat RatioSum
		{
			get
			{
				if (_ratioSum == null)
				{
					_ratioSum = (CFloat) CR2WTypeManager.Create("Float", "ratioSum", cr2w, this);
				}
				return _ratioSum;
			}
			set
			{
				if (_ratioSum == value)
				{
					return;
				}
				_ratioSum = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reachSum")] 
		public CFloat ReachSum
		{
			get
			{
				if (_reachSum == null)
				{
					_reachSum = (CFloat) CR2WTypeManager.Create("Float", "reachSum", cr2w, this);
				}
				return _reachSum;
			}
			set
			{
				if (_reachSum == value)
				{
					return;
				}
				_reachSum = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("area")] 
		public CFloat Area
		{
			get
			{
				if (_area == null)
				{
					_area = (CFloat) CR2WTypeManager.Create("Float", "area", cr2w, this);
				}
				return _area;
			}
			set
			{
				if (_area == value)
				{
					return;
				}
				_area = value;
				PropertySet(this);
			}
		}

		public AICombatSquadTacticRatio(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
