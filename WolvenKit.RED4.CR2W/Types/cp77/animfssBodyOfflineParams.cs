using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animfssBodyOfflineParams : CVariable
	{
		private CFloat _hipsTilt;
		private CFloat _hipsShift;
		private CFloat _legsPullFactorMin;
		private CFloat _legsPullFactorMax;
		private CFloat _legLengthAdjustment;
		private CFloat _legMaxStretchOffset;
		private CFloat _legMaxStretchAdjustment;

		[Ordinal(0)] 
		[RED("HipsTilt")] 
		public CFloat HipsTilt
		{
			get => GetProperty(ref _hipsTilt);
			set => SetProperty(ref _hipsTilt, value);
		}

		[Ordinal(1)] 
		[RED("HipsShift")] 
		public CFloat HipsShift
		{
			get => GetProperty(ref _hipsShift);
			set => SetProperty(ref _hipsShift, value);
		}

		[Ordinal(2)] 
		[RED("LegsPullFactorMin")] 
		public CFloat LegsPullFactorMin
		{
			get => GetProperty(ref _legsPullFactorMin);
			set => SetProperty(ref _legsPullFactorMin, value);
		}

		[Ordinal(3)] 
		[RED("LegsPullFactorMax")] 
		public CFloat LegsPullFactorMax
		{
			get => GetProperty(ref _legsPullFactorMax);
			set => SetProperty(ref _legsPullFactorMax, value);
		}

		[Ordinal(4)] 
		[RED("LegLengthAdjustment")] 
		public CFloat LegLengthAdjustment
		{
			get => GetProperty(ref _legLengthAdjustment);
			set => SetProperty(ref _legLengthAdjustment, value);
		}

		[Ordinal(5)] 
		[RED("LegMaxStretchOffset")] 
		public CFloat LegMaxStretchOffset
		{
			get => GetProperty(ref _legMaxStretchOffset);
			set => SetProperty(ref _legMaxStretchOffset, value);
		}

		[Ordinal(6)] 
		[RED("LegMaxStretchAdjustment")] 
		public CFloat LegMaxStretchAdjustment
		{
			get => GetProperty(ref _legMaxStretchAdjustment);
			set => SetProperty(ref _legMaxStretchAdjustment, value);
		}

		public animfssBodyOfflineParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
