using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DOFControl : animAnimFeature
	{
		private CFloat _dofIntensity;
		private CFloat _dofNearBlur;
		private CFloat _dofNearFocus;
		private CFloat _dofFarBlur;
		private CFloat _dofFarFocus;
		private CFloat _dofBlendInTime;
		private CFloat _dofBlendOutTime;

		[Ordinal(0)] 
		[RED("dofIntensity")] 
		public CFloat DofIntensity
		{
			get
			{
				if (_dofIntensity == null)
				{
					_dofIntensity = (CFloat) CR2WTypeManager.Create("Float", "dofIntensity", cr2w, this);
				}
				return _dofIntensity;
			}
			set
			{
				if (_dofIntensity == value)
				{
					return;
				}
				_dofIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("dofNearBlur")] 
		public CFloat DofNearBlur
		{
			get
			{
				if (_dofNearBlur == null)
				{
					_dofNearBlur = (CFloat) CR2WTypeManager.Create("Float", "dofNearBlur", cr2w, this);
				}
				return _dofNearBlur;
			}
			set
			{
				if (_dofNearBlur == value)
				{
					return;
				}
				_dofNearBlur = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("dofNearFocus")] 
		public CFloat DofNearFocus
		{
			get
			{
				if (_dofNearFocus == null)
				{
					_dofNearFocus = (CFloat) CR2WTypeManager.Create("Float", "dofNearFocus", cr2w, this);
				}
				return _dofNearFocus;
			}
			set
			{
				if (_dofNearFocus == value)
				{
					return;
				}
				_dofNearFocus = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dofFarBlur")] 
		public CFloat DofFarBlur
		{
			get
			{
				if (_dofFarBlur == null)
				{
					_dofFarBlur = (CFloat) CR2WTypeManager.Create("Float", "dofFarBlur", cr2w, this);
				}
				return _dofFarBlur;
			}
			set
			{
				if (_dofFarBlur == value)
				{
					return;
				}
				_dofFarBlur = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("dofFarFocus")] 
		public CFloat DofFarFocus
		{
			get
			{
				if (_dofFarFocus == null)
				{
					_dofFarFocus = (CFloat) CR2WTypeManager.Create("Float", "dofFarFocus", cr2w, this);
				}
				return _dofFarFocus;
			}
			set
			{
				if (_dofFarFocus == value)
				{
					return;
				}
				_dofFarFocus = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("dofBlendInTime")] 
		public CFloat DofBlendInTime
		{
			get
			{
				if (_dofBlendInTime == null)
				{
					_dofBlendInTime = (CFloat) CR2WTypeManager.Create("Float", "dofBlendInTime", cr2w, this);
				}
				return _dofBlendInTime;
			}
			set
			{
				if (_dofBlendInTime == value)
				{
					return;
				}
				_dofBlendInTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("dofBlendOutTime")] 
		public CFloat DofBlendOutTime
		{
			get
			{
				if (_dofBlendOutTime == null)
				{
					_dofBlendOutTime = (CFloat) CR2WTypeManager.Create("Float", "dofBlendOutTime", cr2w, this);
				}
				return _dofBlendOutTime;
			}
			set
			{
				if (_dofBlendOutTime == value)
				{
					return;
				}
				_dofBlendOutTime = value;
				PropertySet(this);
			}
		}

		public AnimFeature_DOFControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
