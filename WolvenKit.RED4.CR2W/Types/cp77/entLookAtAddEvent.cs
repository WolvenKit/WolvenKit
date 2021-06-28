using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLookAtAddEvent : entAnimTargetAddEvent
	{
		private animLookAtRef _outLookAtRef;
		private animLookAtRequest _request;

		[Ordinal(2)] 
		[RED("outLookAtRef")] 
		public animLookAtRef OutLookAtRef
		{
			get => GetProperty(ref _outLookAtRef);
			set => SetProperty(ref _outLookAtRef, value);
		}

		[Ordinal(3)] 
		[RED("request")] 
		public animLookAtRequest Request
		{
			get => GetProperty(ref _request);
			set => SetProperty(ref _request, value);
		}

		public entLookAtAddEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
