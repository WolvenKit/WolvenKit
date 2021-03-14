using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaEvent : ActionBool
	{
		private SecurityAreaData _securityAreaData;
		private wCHandle<gameObject> _whoBreached;

		[Ordinal(25)] 
		[RED("securityAreaData")] 
		public SecurityAreaData SecurityAreaData
		{
			get
			{
				if (_securityAreaData == null)
				{
					_securityAreaData = (SecurityAreaData) CR2WTypeManager.Create("SecurityAreaData", "securityAreaData", cr2w, this);
				}
				return _securityAreaData;
			}
			set
			{
				if (_securityAreaData == value)
				{
					return;
				}
				_securityAreaData = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("whoBreached")] 
		public wCHandle<gameObject> WhoBreached
		{
			get
			{
				if (_whoBreached == null)
				{
					_whoBreached = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "whoBreached", cr2w, this);
				}
				return _whoBreached;
			}
			set
			{
				if (_whoBreached == value)
				{
					return;
				}
				_whoBreached = value;
				PropertySet(this);
			}
		}

		public SecurityAreaEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
