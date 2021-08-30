using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questConditionItem : RedBaseClass
	{
		private CHandle<questIBaseCondition> _condition;
		private CUInt32 _socketId;

		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(1)] 
		[RED("socketId")] 
		public CUInt32 SocketId
		{
			get => GetProperty(ref _socketId);
			set => SetProperty(ref _socketId, value);
		}

		public questConditionItem()
		{
			_socketId = 1734736146;
		}
	}
}
