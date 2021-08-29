using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LifePath_ScriptConditionType : BluelineConditionTypeBase
	{
		private TweakDBID _lifePathId;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("lifePathId")] 
		public TweakDBID LifePathId
		{
			get => GetProperty(ref _lifePathId);
			set => SetProperty(ref _lifePathId, value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}
	}
}
