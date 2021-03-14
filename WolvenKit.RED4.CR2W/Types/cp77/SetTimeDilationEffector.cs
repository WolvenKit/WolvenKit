using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTimeDilationEffector : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private CName _reason;
		private CName _easeInCurve;
		private CName _easeOutCurve;
		private CFloat _dilation;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CName) CR2WTypeManager.Create("CName", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		public SetTimeDilationEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
