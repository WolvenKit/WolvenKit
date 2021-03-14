using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FixedCapsule : CVariable
	{
		private Vector4 _pointRadius;
		private CFloat _height;

		[Ordinal(0)] 
		[RED("PointRadius")] 
		public Vector4 PointRadius
		{
			get
			{
				if (_pointRadius == null)
				{
					_pointRadius = (Vector4) CR2WTypeManager.Create("Vector4", "PointRadius", cr2w, this);
				}
				return _pointRadius;
			}
			set
			{
				if (_pointRadius == value)
				{
					return;
				}
				_pointRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Height")] 
		public CFloat Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CFloat) CR2WTypeManager.Create("Float", "Height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		public FixedCapsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
