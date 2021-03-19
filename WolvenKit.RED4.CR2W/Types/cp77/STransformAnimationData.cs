using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STransformAnimationData : CVariable
	{
		private CName _animationName;
		private CEnum<ETransformAnimationOperationType> _operationType;
		private STransformAnimationPlayEventData _playData;
		private STransformAnimationSkipEventData _skipData;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<ETransformAnimationOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(2)] 
		[RED("playData")] 
		public STransformAnimationPlayEventData PlayData
		{
			get => GetProperty(ref _playData);
			set => SetProperty(ref _playData, value);
		}

		[Ordinal(3)] 
		[RED("skipData")] 
		public STransformAnimationSkipEventData SkipData
		{
			get => GetProperty(ref _skipData);
			set => SetProperty(ref _skipData, value);
		}

		public STransformAnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
