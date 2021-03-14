using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_IK : animAnimFeature
	{
		private Vector4 _point;
		private Vector4 _normal;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("point")] 
		public Vector4 Point
		{
			get
			{
				if (_point == null)
				{
					_point = (Vector4) CR2WTypeManager.Create("Vector4", "point", cr2w, this);
				}
				return _point;
			}
			set
			{
				if (_point == value)
				{
					return;
				}
				_point = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("normal")] 
		public Vector4 Normal
		{
			get
			{
				if (_normal == null)
				{
					_normal = (Vector4) CR2WTypeManager.Create("Vector4", "normal", cr2w, this);
				}
				return _normal;
			}
			set
			{
				if (_normal == value)
				{
					return;
				}
				_normal = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_IK(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
