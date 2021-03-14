using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectFilter_ReachableByNavigation : gameEffectObjectSingleFilter
	{
		private gameEffectInputParameter_Float _maxPathLength;

		[Ordinal(0)] 
		[RED("maxPathLength")] 
		public gameEffectInputParameter_Float MaxPathLength
		{
			get
			{
				if (_maxPathLength == null)
				{
					_maxPathLength = (gameEffectInputParameter_Float) CR2WTypeManager.Create("gameEffectInputParameter_Float", "maxPathLength", cr2w, this);
				}
				return _maxPathLength;
			}
			set
			{
				if (_maxPathLength == value)
				{
					return;
				}
				_maxPathLength = value;
				PropertySet(this);
			}
		}

		public gameEffectFilter_ReachableByNavigation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
