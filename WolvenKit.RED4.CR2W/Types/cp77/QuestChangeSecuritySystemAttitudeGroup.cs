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
			get => GetProperty(ref _newAttitudeGroup);
			set => SetProperty(ref _newAttitudeGroup, value);
		}

		public QuestChangeSecuritySystemAttitudeGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
