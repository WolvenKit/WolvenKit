using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLookAtRemoveEvent : redEvent
	{
		private animLookAtRef _lookAtRef;
		private CBool _hasOutTransition;
		private CFloat _outTransitionSpeed;

		[Ordinal(0)] 
		[RED("lookAtRef")] 
		public animLookAtRef LookAtRef
		{
			get => GetProperty(ref _lookAtRef);
			set => SetProperty(ref _lookAtRef, value);
		}

		[Ordinal(1)] 
		[RED("hasOutTransition")] 
		public CBool HasOutTransition
		{
			get => GetProperty(ref _hasOutTransition);
			set => SetProperty(ref _hasOutTransition, value);
		}

		[Ordinal(2)] 
		[RED("outTransitionSpeed")] 
		public CFloat OutTransitionSpeed
		{
			get => GetProperty(ref _outTransitionSpeed);
			set => SetProperty(ref _outTransitionSpeed, value);
		}

		public entLookAtRemoveEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
