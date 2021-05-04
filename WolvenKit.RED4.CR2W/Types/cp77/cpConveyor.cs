using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpConveyor : gameObject
	{
		private CArray<cpConveyorLine> _lines;
		private curveData<CFloat> _movementCurve;
		private CFloat _entityDistance;
		private CFloat _entitySpawnOffset;
		private CName _audioParameterLineActive;
		private CName _audioParameterLineCycle;
		private CName _audioParameterLineSpeed;

		[Ordinal(40)] 
		[RED("lines")] 
		public CArray<cpConveyorLine> Lines
		{
			get => GetProperty(ref _lines);
			set => SetProperty(ref _lines, value);
		}

		[Ordinal(41)] 
		[RED("movementCurve")] 
		public curveData<CFloat> MovementCurve
		{
			get => GetProperty(ref _movementCurve);
			set => SetProperty(ref _movementCurve, value);
		}

		[Ordinal(42)] 
		[RED("entityDistance")] 
		public CFloat EntityDistance
		{
			get => GetProperty(ref _entityDistance);
			set => SetProperty(ref _entityDistance, value);
		}

		[Ordinal(43)] 
		[RED("entitySpawnOffset")] 
		public CFloat EntitySpawnOffset
		{
			get => GetProperty(ref _entitySpawnOffset);
			set => SetProperty(ref _entitySpawnOffset, value);
		}

		[Ordinal(44)] 
		[RED("audioParameterLineActive")] 
		public CName AudioParameterLineActive
		{
			get => GetProperty(ref _audioParameterLineActive);
			set => SetProperty(ref _audioParameterLineActive, value);
		}

		[Ordinal(45)] 
		[RED("audioParameterLineCycle")] 
		public CName AudioParameterLineCycle
		{
			get => GetProperty(ref _audioParameterLineCycle);
			set => SetProperty(ref _audioParameterLineCycle, value);
		}

		[Ordinal(46)] 
		[RED("audioParameterLineSpeed")] 
		public CName AudioParameterLineSpeed
		{
			get => GetProperty(ref _audioParameterLineSpeed);
			set => SetProperty(ref _audioParameterLineSpeed, value);
		}

		public cpConveyor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
