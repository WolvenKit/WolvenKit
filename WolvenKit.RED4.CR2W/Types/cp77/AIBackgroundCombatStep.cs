using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBackgroundCombatStep : CVariable
	{
		private CFloat _timeMin;
		private CFloat _timeMax;
		private CEnum<EAIBackgroundCombatStep> _type;
		private gameEntityReference _argument;
		private CEnum<AICoverExposureMethod> _exposureMethod;

		[Ordinal(0)] 
		[RED("timeMin")] 
		public CFloat TimeMin
		{
			get => GetProperty(ref _timeMin);
			set => SetProperty(ref _timeMin, value);
		}

		[Ordinal(1)] 
		[RED("timeMax")] 
		public CFloat TimeMax
		{
			get => GetProperty(ref _timeMax);
			set => SetProperty(ref _timeMax, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<EAIBackgroundCombatStep> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(3)] 
		[RED("argument")] 
		public gameEntityReference Argument
		{
			get => GetProperty(ref _argument);
			set => SetProperty(ref _argument, value);
		}

		[Ordinal(4)] 
		[RED("exposureMethod")] 
		public CEnum<AICoverExposureMethod> ExposureMethod
		{
			get => GetProperty(ref _exposureMethod);
			set => SetProperty(ref _exposureMethod, value);
		}

		public AIBackgroundCombatStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
