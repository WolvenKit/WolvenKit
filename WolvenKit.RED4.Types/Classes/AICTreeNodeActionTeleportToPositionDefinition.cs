using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeActionTeleportToPositionDefinition : AICTreeNodeActionDefinition
	{
		private CName _positionName;
		private CBool _doNavTest;

		[Ordinal(1)] 
		[RED("positionName")] 
		public CName PositionName
		{
			get => GetProperty(ref _positionName);
			set => SetProperty(ref _positionName, value);
		}

		[Ordinal(2)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get => GetProperty(ref _doNavTest);
			set => SetProperty(ref _doNavTest, value);
		}

		public AICTreeNodeActionTeleportToPositionDefinition()
		{
			_positionName = "MovementTarget";
		}
	}
}
