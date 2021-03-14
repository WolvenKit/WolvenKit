using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetCyberspacePostFX_NodeType : questIRenderFxManagerNodeType
	{
		private CBool _enabled;
		private CBool _fullScreen;
		private CBool _vfx;
		private CFloat _initialDatamosh;
		private CFloat _targetDatamosh;
		private CFloat _initialTreshold;
		private CFloat _targetTreshold;
		private CFloat _timeBlend;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fullScreen")] 
		public CBool FullScreen
		{
			get
			{
				if (_fullScreen == null)
				{
					_fullScreen = (CBool) CR2WTypeManager.Create("Bool", "fullScreen", cr2w, this);
				}
				return _fullScreen;
			}
			set
			{
				if (_fullScreen == value)
				{
					return;
				}
				_fullScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("initialTreshold")] 
		public CFloat InitialTreshold
		{
			get
			{
				if (_initialTreshold == null)
				{
					_initialTreshold = (CFloat) CR2WTypeManager.Create("Float", "initialTreshold", cr2w, this);
				}
				return _initialTreshold;
			}
			set
			{
				if (_initialTreshold == value)
				{
					return;
				}
				_initialTreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("targetTreshold")] 
		public CFloat TargetTreshold
		{
			get
			{
				if (_targetTreshold == null)
				{
					_targetTreshold = (CFloat) CR2WTypeManager.Create("Float", "targetTreshold", cr2w, this);
				}
				return _targetTreshold;
			}
			set
			{
				if (_targetTreshold == value)
				{
					return;
				}
				_targetTreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		public questSetCyberspacePostFX_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
