using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextValueProgressAnimationController : inkTextAnimationController
	{
		private CFloat _baseValue;
		private CFloat _targetValue;
		private CInt32 _numbersAfterDot;
		private CFloat _stepValue;
		private CString _suffix;

		[Ordinal(8)] 
		[RED("baseValue")] 
		public CFloat BaseValue
		{
			get => GetProperty(ref _baseValue);
			set => SetProperty(ref _baseValue, value);
		}

		[Ordinal(9)] 
		[RED("targetValue")] 
		public CFloat TargetValue
		{
			get => GetProperty(ref _targetValue);
			set => SetProperty(ref _targetValue, value);
		}

		[Ordinal(10)] 
		[RED("numbersAfterDot")] 
		public CInt32 NumbersAfterDot
		{
			get => GetProperty(ref _numbersAfterDot);
			set => SetProperty(ref _numbersAfterDot, value);
		}

		[Ordinal(11)] 
		[RED("stepValue")] 
		public CFloat StepValue
		{
			get => GetProperty(ref _stepValue);
			set => SetProperty(ref _stepValue, value);
		}

		[Ordinal(12)] 
		[RED("suffix")] 
		public CString Suffix
		{
			get => GetProperty(ref _suffix);
			set => SetProperty(ref _suffix, value);
		}

		public inkTextValueProgressAnimationController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
