using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceContextAnswer : RedBaseClass
	{
		private CName _answerContext;
		private CFloat _radius;

		[Ordinal(0)] 
		[RED("answerContext")] 
		public CName AnswerContext
		{
			get => GetProperty(ref _answerContext);
			set => SetProperty(ref _answerContext, value);
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}
	}
}
