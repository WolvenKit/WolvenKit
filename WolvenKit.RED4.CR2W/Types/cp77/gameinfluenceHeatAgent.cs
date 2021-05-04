using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceHeatAgent : gameinfluenceIAgent
	{
		private CFloat _timeToNextUpdate;
		private CFloat _heatRadius;
		private CFloat _heatValue;

		[Ordinal(0)] 
		[RED("timeToNextUpdate")] 
		public CFloat TimeToNextUpdate
		{
			get => GetProperty(ref _timeToNextUpdate);
			set => SetProperty(ref _timeToNextUpdate, value);
		}

		[Ordinal(1)] 
		[RED("heatRadius")] 
		public CFloat HeatRadius
		{
			get => GetProperty(ref _heatRadius);
			set => SetProperty(ref _heatRadius, value);
		}

		[Ordinal(2)] 
		[RED("heatValue")] 
		public CFloat HeatValue
		{
			get => GetProperty(ref _heatValue);
			set => SetProperty(ref _heatValue, value);
		}

		public gameinfluenceHeatAgent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
