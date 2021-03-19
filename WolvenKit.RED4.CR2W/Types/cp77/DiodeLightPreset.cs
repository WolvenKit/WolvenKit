using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DiodeLightPreset : CVariable
	{
		private CBool _state;
		private CArray<CInt32> _colorMax;
		private CArray<CInt32> _colorMin;
		private CBool _overrideColorMin;
		private CFloat _strength;
		private CName _curve;
		private CFloat _time;
		private CBool _loop;
		private CFloat _duration;
		private CBool _force;

		[Ordinal(0)] 
		[RED("state")] 
		public CBool State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("colorMax")] 
		public CArray<CInt32> ColorMax
		{
			get => GetProperty(ref _colorMax);
			set => SetProperty(ref _colorMax, value);
		}

		[Ordinal(2)] 
		[RED("colorMin")] 
		public CArray<CInt32> ColorMin
		{
			get => GetProperty(ref _colorMin);
			set => SetProperty(ref _colorMin, value);
		}

		[Ordinal(3)] 
		[RED("overrideColorMin")] 
		public CBool OverrideColorMin
		{
			get => GetProperty(ref _overrideColorMin);
			set => SetProperty(ref _overrideColorMin, value);
		}

		[Ordinal(4)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		[Ordinal(5)] 
		[RED("curve")] 
		public CName Curve
		{
			get => GetProperty(ref _curve);
			set => SetProperty(ref _curve, value);
		}

		[Ordinal(6)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(7)] 
		[RED("loop")] 
		public CBool Loop
		{
			get => GetProperty(ref _loop);
			set => SetProperty(ref _loop, value);
		}

		[Ordinal(8)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(9)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetProperty(ref _force);
			set => SetProperty(ref _force, value);
		}

		public DiodeLightPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
