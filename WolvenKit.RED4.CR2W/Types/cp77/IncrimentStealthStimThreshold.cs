using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IncrimentStealthStimThreshold : AIbehaviortaskScript
	{
		private CFloat _thresholdTimeout;

		[Ordinal(0)] 
		[RED("thresholdTimeout")] 
		public CFloat ThresholdTimeout
		{
			get => GetProperty(ref _thresholdTimeout);
			set => SetProperty(ref _thresholdTimeout, value);
		}

		public IncrimentStealthStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
