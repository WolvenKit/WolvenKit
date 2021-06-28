using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAcousticZoneParameterMapItem : audioAudioMetadata
	{
		private CName _param;
		private CFloat _value;
		private CFloat _enterCurveTime;
		private CFloat _exitCurveTime;

		[Ordinal(1)] 
		[RED("param")] 
		public CName Param
		{
			get => GetProperty(ref _param);
			set => SetProperty(ref _param, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(3)] 
		[RED("enterCurveTime")] 
		public CFloat EnterCurveTime
		{
			get => GetProperty(ref _enterCurveTime);
			set => SetProperty(ref _enterCurveTime, value);
		}

		[Ordinal(4)] 
		[RED("exitCurveTime")] 
		public CFloat ExitCurveTime
		{
			get => GetProperty(ref _exitCurveTime);
			set => SetProperty(ref _exitCurveTime, value);
		}

		public audioAcousticZoneParameterMapItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
