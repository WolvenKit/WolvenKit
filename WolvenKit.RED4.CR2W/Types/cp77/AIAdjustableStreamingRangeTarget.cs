using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAdjustableStreamingRangeTarget : gameObject
	{
		private CFloat _minStreamingDistance;

		[Ordinal(40)] 
		[RED("minStreamingDistance")] 
		public CFloat MinStreamingDistance
		{
			get
			{
				if (_minStreamingDistance == null)
				{
					_minStreamingDistance = (CFloat) CR2WTypeManager.Create("Float", "minStreamingDistance", cr2w, this);
				}
				return _minStreamingDistance;
			}
			set
			{
				if (_minStreamingDistance == value)
				{
					return;
				}
				_minStreamingDistance = value;
				PropertySet(this);
			}
		}

		public AIAdjustableStreamingRangeTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
