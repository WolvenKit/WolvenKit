using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleHornProbsEvent : redEvent
	{
		private CFloat _honkMinTime;
		private CFloat _honkMaxTime;
		private CFloat _probability;

		[Ordinal(0)] 
		[RED("honkMinTime")] 
		public CFloat HonkMinTime
		{
			get => GetProperty(ref _honkMinTime);
			set => SetProperty(ref _honkMinTime, value);
		}

		[Ordinal(1)] 
		[RED("honkMaxTime")] 
		public CFloat HonkMaxTime
		{
			get => GetProperty(ref _honkMaxTime);
			set => SetProperty(ref _honkMaxTime, value);
		}

		[Ordinal(2)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}

		public VehicleHornProbsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
