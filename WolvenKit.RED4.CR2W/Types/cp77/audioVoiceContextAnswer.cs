using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceContextAnswer : CVariable
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

		public audioVoiceContextAnswer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
