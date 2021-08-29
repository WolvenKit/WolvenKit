using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitDetectionDebugFrameData : RedBaseClass
	{
		private CBool _t;
		private CWeakHandle<gameHitRepresentationComponent> _mponent;
		private netTime _tTime;
		private CArray<gameHitDetectionDebugFrameDataShapeEntry> _apes;

		[Ordinal(0)] 
		[RED("t")] 
		public CBool T
		{
			get => GetProperty(ref _t);
			set => SetProperty(ref _t, value);
		}

		[Ordinal(1)] 
		[RED("mponent")] 
		public CWeakHandle<gameHitRepresentationComponent> Mponent
		{
			get => GetProperty(ref _mponent);
			set => SetProperty(ref _mponent, value);
		}

		[Ordinal(2)] 
		[RED("tTime")] 
		public netTime TTime
		{
			get => GetProperty(ref _tTime);
			set => SetProperty(ref _tTime, value);
		}

		[Ordinal(3)] 
		[RED("apes")] 
		public CArray<gameHitDetectionDebugFrameDataShapeEntry> Apes
		{
			get => GetProperty(ref _apes);
			set => SetProperty(ref _apes, value);
		}
	}
}
