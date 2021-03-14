using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemForwardDecal : effectTrackItem
	{
		private rRef<CMesh> _mesh;
		private CName _appearance;
		private CHandle<IEvaluatorVector> _scale;
		private CFloat _additionalRotation;
		private CFloat _sizeThreshold;
		private CBool _randomRotation;
		private CBool _randomAppearance;
		private CBool _isAttached;
		private CUInt32 _subUVx;
		private CUInt32 _subUVy;
		private CUInt32 _frame;
		private CFloat _fadeOutTime;
		private CFloat _fadeInTime;

		[Ordinal(3)] 
		[RED("mesh")] 
		public rRef<CMesh> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (rRef<CMesh>) CR2WTypeManager.Create("rRef:CMesh", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get
			{
				if (_appearance == null)
				{
					_appearance = (CName) CR2WTypeManager.Create("CName", "appearance", cr2w, this);
				}
				return _appearance;
			}
			set
			{
				if (_appearance == value)
				{
					return;
				}
				_appearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CHandle<IEvaluatorVector> Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("additionalRotation")] 
		public CFloat AdditionalRotation
		{
			get
			{
				if (_additionalRotation == null)
				{
					_additionalRotation = (CFloat) CR2WTypeManager.Create("Float", "additionalRotation", cr2w, this);
				}
				return _additionalRotation;
			}
			set
			{
				if (_additionalRotation == value)
				{
					return;
				}
				_additionalRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("sizeThreshold")] 
		public CFloat SizeThreshold
		{
			get
			{
				if (_sizeThreshold == null)
				{
					_sizeThreshold = (CFloat) CR2WTypeManager.Create("Float", "sizeThreshold", cr2w, this);
				}
				return _sizeThreshold;
			}
			set
			{
				if (_sizeThreshold == value)
				{
					return;
				}
				_sizeThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("randomRotation")] 
		public CBool RandomRotation
		{
			get
			{
				if (_randomRotation == null)
				{
					_randomRotation = (CBool) CR2WTypeManager.Create("Bool", "randomRotation", cr2w, this);
				}
				return _randomRotation;
			}
			set
			{
				if (_randomRotation == value)
				{
					return;
				}
				_randomRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("randomAppearance")] 
		public CBool RandomAppearance
		{
			get
			{
				if (_randomAppearance == null)
				{
					_randomAppearance = (CBool) CR2WTypeManager.Create("Bool", "randomAppearance", cr2w, this);
				}
				return _randomAppearance;
			}
			set
			{
				if (_randomAppearance == value)
				{
					return;
				}
				_randomAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isAttached")] 
		public CBool IsAttached
		{
			get
			{
				if (_isAttached == null)
				{
					_isAttached = (CBool) CR2WTypeManager.Create("Bool", "isAttached", cr2w, this);
				}
				return _isAttached;
			}
			set
			{
				if (_isAttached == value)
				{
					return;
				}
				_isAttached = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("subUVx")] 
		public CUInt32 SubUVx
		{
			get
			{
				if (_subUVx == null)
				{
					_subUVx = (CUInt32) CR2WTypeManager.Create("Uint32", "subUVx", cr2w, this);
				}
				return _subUVx;
			}
			set
			{
				if (_subUVx == value)
				{
					return;
				}
				_subUVx = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("subUVy")] 
		public CUInt32 SubUVy
		{
			get
			{
				if (_subUVy == null)
				{
					_subUVy = (CUInt32) CR2WTypeManager.Create("Uint32", "subUVy", cr2w, this);
				}
				return _subUVy;
			}
			set
			{
				if (_subUVy == value)
				{
					return;
				}
				_subUVy = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("frame")] 
		public CUInt32 Frame
		{
			get
			{
				if (_frame == null)
				{
					_frame = (CUInt32) CR2WTypeManager.Create("Uint32", "frame", cr2w, this);
				}
				return _frame;
			}
			set
			{
				if (_frame == value)
				{
					return;
				}
				_frame = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("fadeOutTime")] 
		public CFloat FadeOutTime
		{
			get
			{
				if (_fadeOutTime == null)
				{
					_fadeOutTime = (CFloat) CR2WTypeManager.Create("Float", "fadeOutTime", cr2w, this);
				}
				return _fadeOutTime;
			}
			set
			{
				if (_fadeOutTime == value)
				{
					return;
				}
				_fadeOutTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("fadeInTime")] 
		public CFloat FadeInTime
		{
			get
			{
				if (_fadeInTime == null)
				{
					_fadeInTime = (CFloat) CR2WTypeManager.Create("Float", "fadeInTime", cr2w, this);
				}
				return _fadeInTime;
			}
			set
			{
				if (_fadeInTime == value)
				{
					return;
				}
				_fadeInTime = value;
				PropertySet(this);
			}
		}

		public effectTrackItemForwardDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
