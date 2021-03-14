using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerLimitsMapItem : CVariable
	{
		private CName _name;
		private audioVoiceTriggerLimits _limits;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("limits")] 
		public audioVoiceTriggerLimits Limits
		{
			get
			{
				if (_limits == null)
				{
					_limits = (audioVoiceTriggerLimits) CR2WTypeManager.Create("audioVoiceTriggerLimits", "limits", cr2w, this);
				}
				return _limits;
			}
			set
			{
				if (_limits == value)
				{
					return;
				}
				_limits = value;
				PropertySet(this);
			}
		}

		public audioVoiceTriggerLimitsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
