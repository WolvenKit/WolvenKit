using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCyberspacePixelsortEffectParams : CVariable
	{
		private CBool _fullscreen;
		private CBool _vfx;
		private CFloat _initialDatamosh;
		private CFloat _targetDatamosh;
		private CFloat _initialIntensity;
		private CFloat _targetIntensity;
		private CFloat _timeBlend;

		[Ordinal(0)] 
		[RED("fullscreen")] 
		public CBool Fullscreen
		{
			get
			{
				if (_fullscreen == null)
				{
					_fullscreen = (CBool) CR2WTypeManager.Create("Bool", "fullscreen", cr2w, this);
				}
				return _fullscreen;
			}
			set
			{
				if (_fullscreen == value)
				{
					return;
				}
				_fullscreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vfx")] 
		public CBool Vfx
		{
			get
			{
				if (_vfx == null)
				{
					_vfx = (CBool) CR2WTypeManager.Create("Bool", "vfx", cr2w, this);
				}
				return _vfx;
			}
			set
			{
				if (_vfx == value)
				{
					return;
				}
				_vfx = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("initialDatamosh")] 
		public CFloat InitialDatamosh
		{
			get
			{
				if (_initialDatamosh == null)
				{
					_initialDatamosh = (CFloat) CR2WTypeManager.Create("Float", "initialDatamosh", cr2w, this);
				}
				return _initialDatamosh;
			}
			set
			{
				if (_initialDatamosh == value)
				{
					return;
				}
				_initialDatamosh = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("targetDatamosh")] 
		public CFloat TargetDatamosh
		{
			get
			{
				if (_targetDatamosh == null)
				{
					_targetDatamosh = (CFloat) CR2WTypeManager.Create("Float", "targetDatamosh", cr2w, this);
				}
				return _targetDatamosh;
			}
			set
			{
				if (_targetDatamosh == value)
				{
					return;
				}
				_targetDatamosh = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("initialIntensity")] 
		public CFloat InitialIntensity
		{
			get
			{
				if (_initialIntensity == null)
				{
					_initialIntensity = (CFloat) CR2WTypeManager.Create("Float", "initialIntensity", cr2w, this);
				}
				return _initialIntensity;
			}
			set
			{
				if (_initialIntensity == value)
				{
					return;
				}
				_initialIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("targetIntensity")] 
		public CFloat TargetIntensity
		{
			get
			{
				if (_targetIntensity == null)
				{
					_targetIntensity = (CFloat) CR2WTypeManager.Create("Float", "targetIntensity", cr2w, this);
				}
				return _targetIntensity;
			}
			set
			{
				if (_targetIntensity == value)
				{
					return;
				}
				_targetIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("timeBlend")] 
		public CFloat TimeBlend
		{
			get
			{
				if (_timeBlend == null)
				{
					_timeBlend = (CFloat) CR2WTypeManager.Create("Float", "timeBlend", cr2w, this);
				}
				return _timeBlend;
			}
			set
			{
				if (_timeBlend == value)
				{
					return;
				}
				_timeBlend = value;
				PropertySet(this);
			}
		}

		public gameCyberspacePixelsortEffectParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
