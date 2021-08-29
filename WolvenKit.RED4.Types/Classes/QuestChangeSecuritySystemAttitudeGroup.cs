using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestChangeSecuritySystemAttitudeGroup : redEvent
	{
		private TweakDBID _newAttitudeGroup;

		[Ordinal(0)] 
		[RED("newAttitudeGroup")] 
		public TweakDBID NewAttitudeGroup
		{
			get => GetProperty(ref _newAttitudeGroup);
			set => SetProperty(ref _newAttitudeGroup, value);
		}
	}
}
