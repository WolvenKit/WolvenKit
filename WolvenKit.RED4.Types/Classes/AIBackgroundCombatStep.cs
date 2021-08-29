using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIBackgroundCombatStep : RedBaseClass
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
	}
}
