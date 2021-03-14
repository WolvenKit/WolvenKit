using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ContactShadowsConfig : CVariable
	{
		private CFloat _range;
		private CFloat _rangeLimit;
		private CFloat _screenEdgeFadeRange;
		private CFloat _distanceFadeLimit;
		private CFloat _distanceFadeRange;

		[Ordinal(0)] 
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rangeLimit")] 
		public CFloat RangeLimit
		{
			get
			{
				if (_rangeLimit == null)
				{
					_rangeLimit = (CFloat) CR2WTypeManager.Create("Float", "rangeLimit", cr2w, this);
				}
				return _rangeLimit;
			}
			set
			{
				if (_rangeLimit == value)
				{
					return;
				}
				_rangeLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("screenEdgeFadeRange")] 
		public CFloat ScreenEdgeFadeRange
		{
			get
			{
				if (_screenEdgeFadeRange == null)
				{
					_screenEdgeFadeRange = (CFloat) CR2WTypeManager.Create("Float", "screenEdgeFadeRange", cr2w, this);
				}
				return _screenEdgeFadeRange;
			}
			set
			{
				if (_screenEdgeFadeRange == value)
				{
					return;
				}
				_screenEdgeFadeRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("distanceFadeLimit")] 
		public CFloat DistanceFadeLimit
		{
			get
			{
				if (_distanceFadeLimit == null)
				{
					_distanceFadeLimit = (CFloat) CR2WTypeManager.Create("Float", "distanceFadeLimit", cr2w, this);
				}
				return _distanceFadeLimit;
			}
			set
			{
				if (_distanceFadeLimit == value)
				{
					return;
				}
				_distanceFadeLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("distanceFadeRange")] 
		public CFloat DistanceFadeRange
		{
			get
			{
				if (_distanceFadeRange == null)
				{
					_distanceFadeRange = (CFloat) CR2WTypeManager.Create("Float", "distanceFadeRange", cr2w, this);
				}
				return _distanceFadeRange;
			}
			set
			{
				if (_distanceFadeRange == value)
				{
					return;
				}
				_distanceFadeRange = value;
				PropertySet(this);
			}
		}

		public ContactShadowsConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
