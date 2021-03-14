using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Bump : animAnimFeature
	{
		private CFloat _direction;
		private CFloat _source;
		private CFloat _intensity;
		private CBool _isBumping;
		private CInt32 _bumpType;

		[Ordinal(0)] 
		[RED("direction")] 
		public CFloat Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CFloat) CR2WTypeManager.Create("Float", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CFloat Source
		{
			get
			{
				if (_source == null)
				{
					_source = (CFloat) CR2WTypeManager.Create("Float", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get
			{
				if (_intensity == null)
				{
					_intensity = (CFloat) CR2WTypeManager.Create("Float", "intensity", cr2w, this);
				}
				return _intensity;
			}
			set
			{
				if (_intensity == value)
				{
					return;
				}
				_intensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isBumping")] 
		public CBool IsBumping
		{
			get
			{
				if (_isBumping == null)
				{
					_isBumping = (CBool) CR2WTypeManager.Create("Bool", "isBumping", cr2w, this);
				}
				return _isBumping;
			}
			set
			{
				if (_isBumping == value)
				{
					return;
				}
				_isBumping = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bumpType")] 
		public CInt32 BumpType
		{
			get
			{
				if (_bumpType == null)
				{
					_bumpType = (CInt32) CR2WTypeManager.Create("Int32", "bumpType", cr2w, this);
				}
				return _bumpType;
			}
			set
			{
				if (_bumpType == value)
				{
					return;
				}
				_bumpType = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_Bump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
