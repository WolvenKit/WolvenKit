using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AgentMovingHitPrereqCondition : BaseHitPrereqCondition
	{
		private CBool _isMoving;
		private CName _object;

		[Ordinal(1)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get => GetProperty(ref _isMoving);
			set => SetProperty(ref _isMoving, value);
		}

		[Ordinal(2)] 
		[RED("object")] 
		public CName Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}
	}
}
