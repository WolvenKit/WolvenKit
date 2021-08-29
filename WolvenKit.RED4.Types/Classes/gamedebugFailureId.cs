using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedebugFailureId : RedBaseClass
	{
		private CUInt32 _threadId;
		private CUInt32 _unsignedId;

		[Ordinal(0)] 
		[RED("threadId")] 
		public CUInt32 ThreadId
		{
			get => GetProperty(ref _threadId);
			set => SetProperty(ref _threadId, value);
		}

		[Ordinal(1)] 
		[RED("unsignedId")] 
		public CUInt32 UnsignedId
		{
			get => GetProperty(ref _unsignedId);
			set => SetProperty(ref _unsignedId, value);
		}
	}
}
