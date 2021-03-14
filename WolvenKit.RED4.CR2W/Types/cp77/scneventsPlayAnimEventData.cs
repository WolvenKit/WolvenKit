using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayAnimEventData : CVariable
	{
		private CFloat _blendIn;
		private CFloat _blendOut;
		private CFloat _clipFront;
		private CFloat _clipEnd;
		private CFloat _stretch;
		private CEnum<scnEasingType> _blendInCurve;
		private CEnum<scnEasingType> _blendOutCurve;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("clipEnd")] 
		public CFloat ClipEnd
		{
			get
			{
				if (_clipEnd == null)
				{
					_clipEnd = (CFloat) CR2WTypeManager.Create("Float", "clipEnd", cr2w, this);
				}
				return _clipEnd;
			}
			set
			{
				if (_clipEnd == value)
				{
					return;
				}
				_clipEnd = value;
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
		[RED("blendInCurve")] 
		public CEnum<scnEasingType> BlendInCurve
		{
			get
			{
				if (_blendInCurve == null)
				{
					_blendInCurve = (CEnum<scnEasingType>) CR2WTypeManager.Create("scnEasingType", "blendInCurve", cr2w, this);
				}
				return _blendInCurve;
			}
			set
			{
				if (_blendInCurve == value)
				{
					return;
				}
				_blendInCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("blendOutCurve")] 
		public CEnum<scnEasingType> BlendOutCurve
		{
			get
			{
				if (_blendOutCurve == null)
				{
					_blendOutCurve = (CEnum<scnEasingType>) CR2WTypeManager.Create("scnEasingType", "blendOutCurve", cr2w, this);
				}
				return _blendOutCurve;
			}
			set
			{
				if (_blendOutCurve == value)
				{
					return;
				}
				_blendOutCurve = value;
				PropertySet(this);
			}
		}

		public scneventsPlayAnimEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
