using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsTimeChangeEvent : redEvent
	{
		private CUInt32 _listenerId;

		[Ordinal(0)] 
		[RED("listenerId")] 
		public CUInt32 ListenerId
		{
			get => GetProperty(ref _listenerId);
			set => SetProperty(ref _listenerId, value);
		}

		public FunctionalTestsTimeChangeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
