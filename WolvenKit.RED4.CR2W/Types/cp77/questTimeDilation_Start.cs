using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Start : questTimeDilation_Operation
	{
		private CFloat _dilation;
		private CFloat _duration;
		private CName _easeInCurve;
		private CName _easeOutCurve;

		[Ordinal(0)] 
		[RED("dilation")] 
		public CFloat Dilation
		{
			get
			{
				if (_dilation == null)
				{
					_dilation = (CFloat) CR2WTypeManager.Create("Float", "dilation", cr2w, this);
				}
				return _dilation;
			}
			set
			{
				if (_dilation == value)
				{
					return;
				}
				_dilation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("easeInCurve")] 
		public CName EaseInCurve
		{
			get
			{
				if (_easeInCurve == null)
				{
					_easeInCurve = (CName) CR2WTypeManager.Create("CName", "easeInCurve", cr2w, this);
				}
				return _easeInCurve;
			}
			set
			{
				if (_easeInCurve == value)
				{
					return;
				}
				_easeInCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("easeOutCurve")] 
		public CName EaseOutCurve
		{
			get
			{
				if (_easeOutCurve == null)
				{
					_easeOutCurve = (CName) CR2WTypeManager.Create("CName", "easeOutCurve", cr2w, this);
				}
				return _easeOutCurve;
			}
			set
			{
				if (_easeOutCurve == value)
				{
					return;
				}
				_easeOutCurve = value;
				PropertySet(this);
			}
		}

		public questTimeDilation_Start(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
