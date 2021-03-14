using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestChangeSecuritySystemAttitudeGroup : redEvent
	{
		private TweakDBID _newAttitudeGroup;

		[Ordinal(0)] 
		[RED("newAttitudeGroup")] 
		public TweakDBID NewAttitudeGroup
		{
			get
			{
				if (_newAttitudeGroup == null)
				{
					_newAttitudeGroup = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "newAttitudeGroup", cr2w, this);
				}
				return _newAttitudeGroup;
			}
			set
			{
				if (_newAttitudeGroup == value)
				{
					return;
				}
				_newAttitudeGroup = value;
				PropertySet(this);
			}
		}

		public QuestChangeSecuritySystemAttitudeGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
