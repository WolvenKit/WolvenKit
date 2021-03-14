using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameQuestDistanceRequestFilter : gameCustomRequestFilter
	{
		private CFloat _distanceSquared;

		[Ordinal(0)] 
		[RED("distanceSquared")] 
		public CFloat DistanceSquared
		{
			get
			{
				if (_distanceSquared == null)
				{
					_distanceSquared = (CFloat) CR2WTypeManager.Create("Float", "distanceSquared", cr2w, this);
				}
				return _distanceSquared;
			}
			set
			{
				if (_distanceSquared == value)
				{
					return;
				}
				_distanceSquared = value;
				PropertySet(this);
			}
		}

		public gameQuestDistanceRequestFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
