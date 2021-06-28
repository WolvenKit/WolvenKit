using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceObstacle : CVariable
	{
		private CFloat _interval;
		private CName _dynObjectType;

		[Ordinal(0)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get => GetProperty(ref _interval);
			set => SetProperty(ref _interval, value);
		}

		[Ordinal(1)] 
		[RED("dynObjectType")] 
		public CName DynObjectType
		{
			get => GetProperty(ref _dynObjectType);
			set => SetProperty(ref _dynObjectType, value);
		}

		public gameuiRoachRaceObstacle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
