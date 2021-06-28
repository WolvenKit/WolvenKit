using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectionComponent : gameScriptableComponent
	{
		private CString _slot;
		private CFloat _cumulatedObjRotationX;
		private CFloat _cumulatedObjRotationY;
		private CFloat _maxObjOffset;
		private CFloat _minObjOffset;
		private CFloat _zoomSpeed;
		private CFloat _timeToScan;
		private CBool _isPlayerInspecting;
		private CString _activeClue;
		private CBool _isScanAvailable;
		private CBool _scanningInProgress;
		private CBool _objectScanned;
		private CHandle<AnimFeature_Inspection> _animFeature;
		private CHandle<IScriptable> _listener;
		private entEntityID _lastInspectedObjID;

		[Ordinal(5)] 
		[RED("slot")] 
		public CString Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}

		[Ordinal(6)] 
		[RED("cumulatedObjRotationX")] 
		public CFloat CumulatedObjRotationX
		{
			get => GetProperty(ref _cumulatedObjRotationX);
			set => SetProperty(ref _cumulatedObjRotationX, value);
		}

		[Ordinal(7)] 
		[RED("cumulatedObjRotationY")] 
		public CFloat CumulatedObjRotationY
		{
			get => GetProperty(ref _cumulatedObjRotationY);
			set => SetProperty(ref _cumulatedObjRotationY, value);
		}

		[Ordinal(8)] 
		[RED("maxObjOffset")] 
		public CFloat MaxObjOffset
		{
			get => GetProperty(ref _maxObjOffset);
			set => SetProperty(ref _maxObjOffset, value);
		}

		[Ordinal(9)] 
		[RED("minObjOffset")] 
		public CFloat MinObjOffset
		{
			get => GetProperty(ref _minObjOffset);
			set => SetProperty(ref _minObjOffset, value);
		}

		[Ordinal(10)] 
		[RED("zoomSpeed")] 
		public CFloat ZoomSpeed
		{
			get => GetProperty(ref _zoomSpeed);
			set => SetProperty(ref _zoomSpeed, value);
		}

		[Ordinal(11)] 
		[RED("timeToScan")] 
		public CFloat TimeToScan
		{
			get => GetProperty(ref _timeToScan);
			set => SetProperty(ref _timeToScan, value);
		}

		[Ordinal(12)] 
		[RED("isPlayerInspecting")] 
		public CBool IsPlayerInspecting
		{
			get => GetProperty(ref _isPlayerInspecting);
			set => SetProperty(ref _isPlayerInspecting, value);
		}

		[Ordinal(13)] 
		[RED("activeClue")] 
		public CString ActiveClue
		{
			get => GetProperty(ref _activeClue);
			set => SetProperty(ref _activeClue, value);
		}

		[Ordinal(14)] 
		[RED("isScanAvailable")] 
		public CBool IsScanAvailable
		{
			get => GetProperty(ref _isScanAvailable);
			set => SetProperty(ref _isScanAvailable, value);
		}

		[Ordinal(15)] 
		[RED("scanningInProgress")] 
		public CBool ScanningInProgress
		{
			get => GetProperty(ref _scanningInProgress);
			set => SetProperty(ref _scanningInProgress, value);
		}

		[Ordinal(16)] 
		[RED("objectScanned")] 
		public CBool ObjectScanned
		{
			get => GetProperty(ref _objectScanned);
			set => SetProperty(ref _objectScanned, value);
		}

		[Ordinal(17)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_Inspection> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(18)] 
		[RED("listener")] 
		public CHandle<IScriptable> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(19)] 
		[RED("lastInspectedObjID")] 
		public entEntityID LastInspectedObjID
		{
			get => GetProperty(ref _lastInspectedObjID);
			set => SetProperty(ref _lastInspectedObjID, value);
		}

		public InspectionComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
