using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetTier2Params_NodeType : questISceneManagerNodeType
	{
		private CEnum<Tier2WalkType> _playerWalkType;
		private CBool _usePlayerWorkspot;
		private CBool _useEnterAnim;
		private CBool _useExitAnim;

		[Ordinal(0)] 
		[RED("playerWalkType")] 
		public CEnum<Tier2WalkType> PlayerWalkType
		{
			get => GetProperty(ref _playerWalkType);
			set => SetProperty(ref _playerWalkType, value);
		}

		[Ordinal(1)] 
		[RED("usePlayerWorkspot")] 
		public CBool UsePlayerWorkspot
		{
			get => GetProperty(ref _usePlayerWorkspot);
			set => SetProperty(ref _usePlayerWorkspot, value);
		}

		[Ordinal(2)] 
		[RED("useEnterAnim")] 
		public CBool UseEnterAnim
		{
			get => GetProperty(ref _useEnterAnim);
			set => SetProperty(ref _useEnterAnim, value);
		}

		[Ordinal(3)] 
		[RED("useExitAnim")] 
		public CBool UseExitAnim
		{
			get => GetProperty(ref _useExitAnim);
			set => SetProperty(ref _useExitAnim, value);
		}

		public questSetTier2Params_NodeType()
		{
			_playerWalkType = new() { Value = Enums.Tier2WalkType.Normal };
		}
	}
}
