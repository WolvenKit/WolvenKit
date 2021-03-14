using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCollisionRoundedShape_ : CVariable
	{
		private animTransformIndex _bone;
		private QsTransform _transformLS;
		private CFloat _roundedCornerRadius;
		private CFloat _xBoxExtent;
		private CFloat _yBoxExtent;
		private CFloat _zBoxExtent;

		[Ordinal(0)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get
			{
				if (_bone == null)
				{
					_bone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "bone", cr2w, this);
				}
				return _bone;
			}
			set
			{
				if (_bone == value)
				{
					return;
				}
				_bone = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transformLS")] 
		public QsTransform TransformLS
		{
			get
			{
				if (_transformLS == null)
				{
					_transformLS = (QsTransform) CR2WTypeManager.Create("QsTransform", "transformLS", cr2w, this);
				}
				return _transformLS;
			}
			set
			{
				if (_transformLS == value)
				{
					return;
				}
				_transformLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("roundedCornerRadius")] 
		public CFloat RoundedCornerRadius
		{
			get
			{
				if (_roundedCornerRadius == null)
				{
					_roundedCornerRadius = (CFloat) CR2WTypeManager.Create("Float", "roundedCornerRadius", cr2w, this);
				}
				return _roundedCornerRadius;
			}
			set
			{
				if (_roundedCornerRadius == value)
				{
					return;
				}
				_roundedCornerRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("xBoxExtent")] 
		public CFloat XBoxExtent
		{
			get
			{
				if (_xBoxExtent == null)
				{
					_xBoxExtent = (CFloat) CR2WTypeManager.Create("Float", "xBoxExtent", cr2w, this);
				}
				return _xBoxExtent;
			}
			set
			{
				if (_xBoxExtent == value)
				{
					return;
				}
				_xBoxExtent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("yBoxExtent")] 
		public CFloat YBoxExtent
		{
			get
			{
				if (_yBoxExtent == null)
				{
					_yBoxExtent = (CFloat) CR2WTypeManager.Create("Float", "yBoxExtent", cr2w, this);
				}
				return _yBoxExtent;
			}
			set
			{
				if (_yBoxExtent == value)
				{
					return;
				}
				_yBoxExtent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("zBoxExtent")] 
		public CFloat ZBoxExtent
		{
			get
			{
				if (_zBoxExtent == null)
				{
					_zBoxExtent = (CFloat) CR2WTypeManager.Create("Float", "zBoxExtent", cr2w, this);
				}
				return _zBoxExtent;
			}
			set
			{
				if (_zBoxExtent == value)
				{
					return;
				}
				_zBoxExtent = value;
				PropertySet(this);
			}
		}

		public animCollisionRoundedShape_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
