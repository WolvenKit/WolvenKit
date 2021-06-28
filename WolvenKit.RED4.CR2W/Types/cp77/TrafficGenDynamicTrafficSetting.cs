using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrafficGenDynamicTrafficSetting : CVariable
	{
		private CEnum<TrafficGenDynamicImpact> _impact;

		[Ordinal(0)] 
		[RED("impact")] 
		public CEnum<TrafficGenDynamicImpact> Impact
		{
			get => GetProperty(ref _impact);
			set => SetProperty(ref _impact, value);
		}

		public TrafficGenDynamicTrafficSetting(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
