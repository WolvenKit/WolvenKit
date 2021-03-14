using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Inspection : animAnimFeature
	{
		private CInt32 _activeInspectionStage;
		private CFloat _rotationX;
		private CFloat _rotationY;
		private CFloat _offsetX;
		private CFloat _offsetY;

		[Ordinal(0)] 
		[RED("activeInspectionStage")] 
		public CInt32 ActiveInspectionStage
		{
			get
			{
				if (_activeInspectionStage == null)
				{
					_activeInspectionStage = (CInt32) CR2WTypeManager.Create("Int32", "activeInspectionStage", cr2w, this);
				}
				return _activeInspectionStage;
			}
			set
			{
				if (_activeInspectionStage == value)
				{
					return;
				}
				_activeInspectionStage = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rotationX")] 
		public CFloat RotationX
		{
			get
			{
				if (_rotationX == null)
				{
					_rotationX = (CFloat) CR2WTypeManager.Create("Float", "rotationX", cr2w, this);
				}
				return _rotationX;
			}
			set
			{
				if (_rotationX == value)
				{
					return;
				}
				_rotationX = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rotationY")] 
		public CFloat RotationY
		{
			get
			{
				if (_rotationY == null)
				{
					_rotationY = (CFloat) CR2WTypeManager.Create("Float", "rotationY", cr2w, this);
				}
				return _rotationY;
			}
			set
			{
				if (_rotationY == value)
				{
					return;
				}
				_rotationY = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("offsetX")] 
		public CFloat OffsetX
		{
			get
			{
				if (_offsetX == null)
				{
					_offsetX = (CFloat) CR2WTypeManager.Create("Float", "offsetX", cr2w, this);
				}
				return _offsetX;
			}
			set
			{
				if (_offsetX == value)
				{
					return;
				}
				_offsetX = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("offsetY")] 
		public CFloat OffsetY
		{
			get
			{
				if (_offsetY == null)
				{
					_offsetY = (CFloat) CR2WTypeManager.Create("Float", "offsetY", cr2w, this);
				}
				return _offsetY;
			}
			set
			{
				if (_offsetY == value)
				{
					return;
				}
				_offsetY = value;
				PropertySet(this);
			}
		}

		public AnimFeature_Inspection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
