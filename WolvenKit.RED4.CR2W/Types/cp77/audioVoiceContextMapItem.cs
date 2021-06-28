using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceContextMapItem : audioAudioMetadata
	{
		private CName _voTrigger;
		private CEnum<audioVoBarkType> _bark;
		private CEnum<audioVoGruntType> _grunt;
		private audioVoiceContextAnswer _answer;
		private CEnum<locVoiceoverContext> _overridingVoContext;
		private CEnum<audioVoGruntInterruptMode> _gruntInterruptMode;

		[Ordinal(1)] 
		[RED("voTrigger")] 
		public CName VoTrigger
		{
			get => GetProperty(ref _voTrigger);
			set => SetProperty(ref _voTrigger, value);
		}

		[Ordinal(2)] 
		[RED("bark")] 
		public CEnum<audioVoBarkType> Bark
		{
			get => GetProperty(ref _bark);
			set => SetProperty(ref _bark, value);
		}

		[Ordinal(3)] 
		[RED("grunt")] 
		public CEnum<audioVoGruntType> Grunt
		{
			get => GetProperty(ref _grunt);
			set => SetProperty(ref _grunt, value);
		}

		[Ordinal(4)] 
		[RED("answer")] 
		public audioVoiceContextAnswer Answer
		{
			get => GetProperty(ref _answer);
			set => SetProperty(ref _answer, value);
		}

		[Ordinal(5)] 
		[RED("overridingVoContext")] 
		public CEnum<locVoiceoverContext> OverridingVoContext
		{
			get => GetProperty(ref _overridingVoContext);
			set => SetProperty(ref _overridingVoContext, value);
		}

		[Ordinal(6)] 
		[RED("gruntInterruptMode")] 
		public CEnum<audioVoGruntInterruptMode> GruntInterruptMode
		{
			get => GetProperty(ref _gruntInterruptMode);
			set => SetProperty(ref _gruntInterruptMode, value);
		}

		public audioVoiceContextMapItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
