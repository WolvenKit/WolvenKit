using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeRoadAdjustmentFactorChangeSection : CVariable
	{
		private CFloat _pos;
		private CFloat _targetFactor;

		[Ordinal(0)] 
		[RED("pos")] 
		public CFloat Pos
		{
			get
			{
				if (_pos == null)
				{
					_pos = (CFloat) CR2WTypeManager.Create("Float", "pos", cr2w, this);
				}
				return _pos;
			}
			set
			{
				if (_pos == value)
				{
					return;
				}
				_pos = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetFactor")] 
		public CFloat TargetFactor
		{
			get
			{
				if (_targetFactor == null)
				{
					_targetFactor = (CFloat) CR2WTypeManager.Create("Float", "targetFactor", cr2w, this);
				}
				return _targetFactor;
			}
			set
			{
				if (_targetFactor == value)
				{
					return;
				}
				_targetFactor = value;
				PropertySet(this);
			}
		}

		public worldSpeedSplineNodeRoadAdjustmentFactorChangeSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
