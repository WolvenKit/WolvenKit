using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIsquadsOrder : RedBaseClass
	{
		private CName _squadAction;
		private CUInt32 _state;
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("squadAction")] 
		public CName SquadAction
		{
			get => GetProperty(ref _squadAction);
			set => SetProperty(ref _squadAction, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CUInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public AIsquadsOrder()
		{
			_state = 64;
		}
	}
}
