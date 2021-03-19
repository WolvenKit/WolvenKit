using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_EffectDuration : animAnimEvent
	{
		private CName _effectName;
		private CUInt32 _sequenceShift;
		private CBool _breakAllLoopsOnStop;

		[Ordinal(3)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(4)] 
		[RED("sequenceShift")] 
		public CUInt32 SequenceShift
		{
			get => GetProperty(ref _sequenceShift);
			set => SetProperty(ref _sequenceShift, value);
		}

		[Ordinal(5)] 
		[RED("breakAllLoopsOnStop")] 
		public CBool BreakAllLoopsOnStop
		{
			get => GetProperty(ref _breakAllLoopsOnStop);
			set => SetProperty(ref _breakAllLoopsOnStop, value);
		}

		public animAnimEvent_EffectDuration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
