using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehEntityPlayerStateData : RedBaseClass
	{
		private entEntityID _entID;
		private CInt32 _state;

		[Ordinal(0)] 
		[RED("entID")] 
		public entEntityID EntID
		{
			get => GetProperty(ref _entID);
			set => SetProperty(ref _entID, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
