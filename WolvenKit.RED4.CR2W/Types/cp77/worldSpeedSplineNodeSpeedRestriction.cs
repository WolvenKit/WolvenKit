using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeSpeedRestriction : CVariable
	{
		private CFloat _speed;
		private CFloat _from;
		private CFloat _adjustTime;

		[Ordinal(0)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(1)] 
		[RED("from")] 
		public CFloat From
		{
			get => GetProperty(ref _from);
			set => SetProperty(ref _from, value);
		}

		[Ordinal(2)] 
		[RED("adjustTime")] 
		public CFloat AdjustTime
		{
			get => GetProperty(ref _adjustTime);
			set => SetProperty(ref _adjustTime, value);
		}

		public worldSpeedSplineNodeSpeedRestriction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
