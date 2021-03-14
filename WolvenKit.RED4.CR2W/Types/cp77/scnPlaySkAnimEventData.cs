using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlaySkAnimEventData : CVariable
	{
		private CName _animName;
		private CFloat _blendIn;
		private CFloat _blendOut;
		private CFloat _clipFront;
		private CFloat _stretch;
		private CFloat _weight;
		private CName _bodyPartMask;

		[Ordinal(0)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blendIn")] 
		public CFloat BlendIn
		{
			get
			{
				if (_blendIn == null)
				{
					_blendIn = (CFloat) CR2WTypeManager.Create("Float", "blendIn", cr2w, this);
				}
				return _blendIn;
			}
			set
			{
				if (_blendIn == value)
				{
					return;
				}
				_blendIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blendOut")] 
		public CFloat BlendOut
		{
			get
			{
				if (_blendOut == null)
				{
					_blendOut = (CFloat) CR2WTypeManager.Create("Float", "blendOut", cr2w, this);
				}
				return _blendOut;
			}
			set
			{
				if (_blendOut == value)
				{
					return;
				}
				_blendOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("clipFront")] 
		public CFloat ClipFront
		{
			get
			{
				if (_clipFront == null)
				{
					_clipFront = (CFloat) CR2WTypeManager.Create("Float", "clipFront", cr2w, this);
				}
				return _clipFront;
			}
			set
			{
				if (_clipFront == value)
				{
					return;
				}
				_clipFront = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stretch")] 
		public CFloat Stretch
		{
			get
			{
				if (_stretch == null)
				{
					_stretch = (CFloat) CR2WTypeManager.Create("Float", "stretch", cr2w, this);
				}
				return _stretch;
			}
			set
			{
				if (_stretch == value)
				{
					return;
				}
				_stretch = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("bodyPartMask")] 
		public CName BodyPartMask
		{
			get
			{
				if (_bodyPartMask == null)
				{
					_bodyPartMask = (CName) CR2WTypeManager.Create("CName", "bodyPartMask", cr2w, this);
				}
				return _bodyPartMask;
			}
			set
			{
				if (_bodyPartMask == value)
				{
					return;
				}
				_bodyPartMask = value;
				PropertySet(this);
			}
		}

		public scnPlaySkAnimEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
