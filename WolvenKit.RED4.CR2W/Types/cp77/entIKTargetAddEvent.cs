using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entIKTargetAddEvent : entAnimTargetAddEvent
	{
		private animIKTargetRef _outIKTargetRef;
		private CHandle<entIOrientationProvider> _orientationProvider;
		private animIKTargetRequest _request;

		[Ordinal(2)] 
		[RED("outIKTargetRef")] 
		public animIKTargetRef OutIKTargetRef
		{
			get => GetProperty(ref _outIKTargetRef);
			set => SetProperty(ref _outIKTargetRef, value);
		}

		[Ordinal(3)] 
		[RED("orientationProvider")] 
		public CHandle<entIOrientationProvider> OrientationProvider
		{
			get => GetProperty(ref _orientationProvider);
			set => SetProperty(ref _orientationProvider, value);
		}

		[Ordinal(4)] 
		[RED("request")] 
		public animIKTargetRequest Request
		{
			get => GetProperty(ref _request);
			set => SetProperty(ref _request, value);
		}

		public entIKTargetAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
