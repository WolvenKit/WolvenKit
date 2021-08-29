using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCompiledEffectEventInfo : RedBaseClass
	{
		private CRUID _eventRUID;
		private CUInt64 _placementIndexMask;
		private CUInt64 _componentIndexMask;
		private CUInt8 _flags;

		[Ordinal(0)] 
		[RED("eventRUID")] 
		public CRUID EventRUID
		{
			get => GetProperty(ref _eventRUID);
			set => SetProperty(ref _eventRUID, value);
		}

		[Ordinal(1)] 
		[RED("placementIndexMask")] 
		public CUInt64 PlacementIndexMask
		{
			get => GetProperty(ref _placementIndexMask);
			set => SetProperty(ref _placementIndexMask, value);
		}

		[Ordinal(2)] 
		[RED("componentIndexMask")] 
		public CUInt64 ComponentIndexMask
		{
			get => GetProperty(ref _componentIndexMask);
			set => SetProperty(ref _componentIndexMask, value);
		}

		[Ordinal(3)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}
	}
}
