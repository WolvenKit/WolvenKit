using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CamberData : animAnimFeatureMarkUnstable
	{
		private CFloat _rightFrontCamber;
		private CFloat _leftFrontCamber;
		private CFloat _rightBackCamber;
		private CFloat _leftBackCamber;
		private Vector4 _rightFrontCamberOffset;
		private Vector4 _leftFrontCamberOffset;
		private Vector4 _rightBackCamberOffset;
		private Vector4 _leftBackCamberOffset;

		[Ordinal(0)] 
		[RED("rightFrontCamber")] 
		public CFloat RightFrontCamber
		{
			get
			{
				if (_rightFrontCamber == null)
				{
					_rightFrontCamber = (CFloat) CR2WTypeManager.Create("Float", "rightFrontCamber", cr2w, this);
				}
				return _rightFrontCamber;
			}
			set
			{
				if (_rightFrontCamber == value)
				{
					return;
				}
				_rightFrontCamber = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("leftFrontCamber")] 
		public CFloat LeftFrontCamber
		{
			get
			{
				if (_leftFrontCamber == null)
				{
					_leftFrontCamber = (CFloat) CR2WTypeManager.Create("Float", "leftFrontCamber", cr2w, this);
				}
				return _leftFrontCamber;
			}
			set
			{
				if (_leftFrontCamber == value)
				{
					return;
				}
				_leftFrontCamber = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rightBackCamber")] 
		public CFloat RightBackCamber
		{
			get
			{
				if (_rightBackCamber == null)
				{
					_rightBackCamber = (CFloat) CR2WTypeManager.Create("Float", "rightBackCamber", cr2w, this);
				}
				return _rightBackCamber;
			}
			set
			{
				if (_rightBackCamber == value)
				{
					return;
				}
				_rightBackCamber = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("leftBackCamber")] 
		public CFloat LeftBackCamber
		{
			get
			{
				if (_leftBackCamber == null)
				{
					_leftBackCamber = (CFloat) CR2WTypeManager.Create("Float", "leftBackCamber", cr2w, this);
				}
				return _leftBackCamber;
			}
			set
			{
				if (_leftBackCamber == value)
				{
					return;
				}
				_leftBackCamber = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rightFrontCamberOffset")] 
		public Vector4 RightFrontCamberOffset
		{
			get
			{
				if (_rightFrontCamberOffset == null)
				{
					_rightFrontCamberOffset = (Vector4) CR2WTypeManager.Create("Vector4", "rightFrontCamberOffset", cr2w, this);
				}
				return _rightFrontCamberOffset;
			}
			set
			{
				if (_rightFrontCamberOffset == value)
				{
					return;
				}
				_rightFrontCamberOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("leftFrontCamberOffset")] 
		public Vector4 LeftFrontCamberOffset
		{
			get
			{
				if (_leftFrontCamberOffset == null)
				{
					_leftFrontCamberOffset = (Vector4) CR2WTypeManager.Create("Vector4", "leftFrontCamberOffset", cr2w, this);
				}
				return _leftFrontCamberOffset;
			}
			set
			{
				if (_leftFrontCamberOffset == value)
				{
					return;
				}
				_leftFrontCamberOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("rightBackCamberOffset")] 
		public Vector4 RightBackCamberOffset
		{
			get
			{
				if (_rightBackCamberOffset == null)
				{
					_rightBackCamberOffset = (Vector4) CR2WTypeManager.Create("Vector4", "rightBackCamberOffset", cr2w, this);
				}
				return _rightBackCamberOffset;
			}
			set
			{
				if (_rightBackCamberOffset == value)
				{
					return;
				}
				_rightBackCamberOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("leftBackCamberOffset")] 
		public Vector4 LeftBackCamberOffset
		{
			get
			{
				if (_leftBackCamberOffset == null)
				{
					_leftBackCamberOffset = (Vector4) CR2WTypeManager.Create("Vector4", "leftBackCamberOffset", cr2w, this);
				}
				return _leftBackCamberOffset;
			}
			set
			{
				if (_leftBackCamberOffset == value)
				{
					return;
				}
				_leftBackCamberOffset = value;
				PropertySet(this);
			}
		}

		public AnimFeature_CamberData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
