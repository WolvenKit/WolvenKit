using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetTrackRange : animAnimNode_OnePoseInput
	{
		private CFloat _min;
		private CFloat _max;
		private CFloat _oldMin;
		private CFloat _oldMax;
		private animFloatLink _minLink;
		private animFloatLink _maxLink;
		private animFloatLink _oldMinLink;
		private animFloatLink _oldMaxLink;
		private animNamedTrackIndex _track;
		private CBool _debug;

		[Ordinal(12)] 
		[RED("min")] 
		public CFloat Min
		{
			get
			{
				if (_min == null)
				{
					_min = (CFloat) CR2WTypeManager.Create("Float", "min", cr2w, this);
				}
				return _min;
			}
			set
			{
				if (_min == value)
				{
					return;
				}
				_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("max")] 
		public CFloat Max
		{
			get
			{
				if (_max == null)
				{
					_max = (CFloat) CR2WTypeManager.Create("Float", "max", cr2w, this);
				}
				return _max;
			}
			set
			{
				if (_max == value)
				{
					return;
				}
				_max = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("oldMin")] 
		public CFloat OldMin
		{
			get
			{
				if (_oldMin == null)
				{
					_oldMin = (CFloat) CR2WTypeManager.Create("Float", "oldMin", cr2w, this);
				}
				return _oldMin;
			}
			set
			{
				if (_oldMin == value)
				{
					return;
				}
				_oldMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("oldMax")] 
		public CFloat OldMax
		{
			get
			{
				if (_oldMax == null)
				{
					_oldMax = (CFloat) CR2WTypeManager.Create("Float", "oldMax", cr2w, this);
				}
				return _oldMax;
			}
			set
			{
				if (_oldMax == value)
				{
					return;
				}
				_oldMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("minLink")] 
		public animFloatLink MinLink
		{
			get
			{
				if (_minLink == null)
				{
					_minLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "minLink", cr2w, this);
				}
				return _minLink;
			}
			set
			{
				if (_minLink == value)
				{
					return;
				}
				_minLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("maxLink")] 
		public animFloatLink MaxLink
		{
			get
			{
				if (_maxLink == null)
				{
					_maxLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "maxLink", cr2w, this);
				}
				return _maxLink;
			}
			set
			{
				if (_maxLink == value)
				{
					return;
				}
				_maxLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("oldMinLink")] 
		public animFloatLink OldMinLink
		{
			get
			{
				if (_oldMinLink == null)
				{
					_oldMinLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "oldMinLink", cr2w, this);
				}
				return _oldMinLink;
			}
			set
			{
				if (_oldMinLink == value)
				{
					return;
				}
				_oldMinLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("oldMaxLink")] 
		public animFloatLink OldMaxLink
		{
			get
			{
				if (_oldMaxLink == null)
				{
					_oldMaxLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "oldMaxLink", cr2w, this);
				}
				return _oldMaxLink;
			}
			set
			{
				if (_oldMaxLink == value)
				{
					return;
				}
				_oldMaxLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("track")] 
		public animNamedTrackIndex Track
		{
			get
			{
				if (_track == null)
				{
					_track = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "track", cr2w, this);
				}
				return _track;
			}
			set
			{
				if (_track == value)
				{
					return;
				}
				_track = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("debug")] 
		public CBool Debug
		{
			get
			{
				if (_debug == null)
				{
					_debug = (CBool) CR2WTypeManager.Create("Bool", "debug", cr2w, this);
				}
				return _debug;
			}
			set
			{
				if (_debug == value)
				{
					return;
				}
				_debug = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SetTrackRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
