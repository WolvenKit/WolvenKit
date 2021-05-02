using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnVehicleMoveOnSpline_Overrides : questIVehicleMoveOnSpline_Overrides
	{
		private CBool _useEntry;
		private CBool _useExit;
		private CFloat _entrySpeed;
		private CFloat _exitSpeed;
		private Transform _entryTransform;
		private Transform _exitTransform;
		private scnMarker _entryMarker;
		private scnMarker _exitMarker;

		[Ordinal(0)] 
		[RED("useEntry")] 
		public CBool UseEntry
		{
			get => GetProperty(ref _useEntry);
			set => SetProperty(ref _useEntry, value);
		}

		[Ordinal(1)] 
		[RED("useExit")] 
		public CBool UseExit
		{
			get => GetProperty(ref _useExit);
			set => SetProperty(ref _useExit, value);
		}

		[Ordinal(2)] 
		[RED("entrySpeed")] 
		public CFloat EntrySpeed
		{
			get => GetProperty(ref _entrySpeed);
			set => SetProperty(ref _entrySpeed, value);
		}

		[Ordinal(3)] 
		[RED("exitSpeed")] 
		public CFloat ExitSpeed
		{
			get => GetProperty(ref _exitSpeed);
			set => SetProperty(ref _exitSpeed, value);
		}

		[Ordinal(4)] 
		[RED("entryTransform")] 
		public Transform EntryTransform
		{
			get => GetProperty(ref _entryTransform);
			set => SetProperty(ref _entryTransform, value);
		}

		[Ordinal(5)] 
		[RED("exitTransform")] 
		public Transform ExitTransform
		{
			get => GetProperty(ref _exitTransform);
			set => SetProperty(ref _exitTransform, value);
		}

		[Ordinal(6)] 
		[RED("entryMarker")] 
		public scnMarker EntryMarker
		{
			get => GetProperty(ref _entryMarker);
			set => SetProperty(ref _entryMarker, value);
		}

		[Ordinal(7)] 
		[RED("exitMarker")] 
		public scnMarker ExitMarker
		{
			get => GetProperty(ref _exitMarker);
			set => SetProperty(ref _exitMarker, value);
		}

		public scnVehicleMoveOnSpline_Overrides(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
