using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StealthStimThreshold : AIbehaviorconditionScript
	{
		private CInt32 _stealthThresholdNumber;

		[Ordinal(0)] 
		[RED("stealthThresholdNumber")] 
		public CInt32 StealthThresholdNumber
		{
			get => GetProperty(ref _stealthThresholdNumber);
			set => SetProperty(ref _stealthThresholdNumber, value);
		}

		public StealthStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
