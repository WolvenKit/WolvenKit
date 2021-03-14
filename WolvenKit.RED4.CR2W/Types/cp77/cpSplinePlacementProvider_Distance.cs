using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpSplinePlacementProvider_Distance : cpSplinePlacementProvider
	{
		private CFloat _distance;

		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		public cpSplinePlacementProvider_Distance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
