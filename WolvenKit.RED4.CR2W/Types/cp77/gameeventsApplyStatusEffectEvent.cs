using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsApplyStatusEffectEvent : gameeventsStatusEffectEvent
	{
		private CBool _isNewApplication;
		private entEntityID _instigatorEntityID;

		[Ordinal(2)] 
		[RED("isNewApplication")] 
		public CBool IsNewApplication
		{
			get
			{
				if (_isNewApplication == null)
				{
					_isNewApplication = (CBool) CR2WTypeManager.Create("Bool", "isNewApplication", cr2w, this);
				}
				return _isNewApplication;
			}
			set
			{
				if (_isNewApplication == value)
				{
					return;
				}
				_isNewApplication = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("instigatorEntityID")] 
		public entEntityID InstigatorEntityID
		{
			get
			{
				if (_instigatorEntityID == null)
				{
					_instigatorEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "instigatorEntityID", cr2w, this);
				}
				return _instigatorEntityID;
			}
			set
			{
				if (_instigatorEntityID == value)
				{
					return;
				}
				_instigatorEntityID = value;
				PropertySet(this);
			}
		}

		public gameeventsApplyStatusEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
