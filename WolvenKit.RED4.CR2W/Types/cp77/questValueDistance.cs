using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questValueDistance : questIDistance
	{
		private CFloat _distanceValue;

		[Ordinal(0)] 
		[RED("distanceValue")] 
		public CFloat DistanceValue
		{
			get
			{
				if (_distanceValue == null)
				{
					_distanceValue = (CFloat) CR2WTypeManager.Create("Float", "distanceValue", cr2w, this);
				}
				return _distanceValue;
			}
			set
			{
				if (_distanceValue == value)
				{
					return;
				}
				_distanceValue = value;
				PropertySet(this);
			}
		}

		public questValueDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
