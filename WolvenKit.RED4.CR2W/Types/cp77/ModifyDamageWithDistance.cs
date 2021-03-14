using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithDistance : ModifyDamageEffector
	{
		private CBool _increaseWithDistance;
		private CFloat _percentMult;
		private CFloat _unitThreshold;

		[Ordinal(2)] 
		[RED("increaseWithDistance")] 
		public CBool IncreaseWithDistance
		{
			get
			{
				if (_increaseWithDistance == null)
				{
					_increaseWithDistance = (CBool) CR2WTypeManager.Create("Bool", "increaseWithDistance", cr2w, this);
				}
				return _increaseWithDistance;
			}
			set
			{
				if (_increaseWithDistance == value)
				{
					return;
				}
				_increaseWithDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("percentMult")] 
		public CFloat PercentMult
		{
			get
			{
				if (_percentMult == null)
				{
					_percentMult = (CFloat) CR2WTypeManager.Create("Float", "percentMult", cr2w, this);
				}
				return _percentMult;
			}
			set
			{
				if (_percentMult == value)
				{
					return;
				}
				_percentMult = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("unitThreshold")] 
		public CFloat UnitThreshold
		{
			get
			{
				if (_unitThreshold == null)
				{
					_unitThreshold = (CFloat) CR2WTypeManager.Create("Float", "unitThreshold", cr2w, this);
				}
				return _unitThreshold;
			}
			set
			{
				if (_unitThreshold == value)
				{
					return;
				}
				_unitThreshold = value;
				PropertySet(this);
			}
		}

		public ModifyDamageWithDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
