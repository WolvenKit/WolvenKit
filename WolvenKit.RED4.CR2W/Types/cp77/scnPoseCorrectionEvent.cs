using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPoseCorrectionEvent : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private animPoseCorrectionGroup _poseCorrectionGroup;

		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(7)] 
		[RED("poseCorrectionGroup")] 
		public animPoseCorrectionGroup PoseCorrectionGroup
		{
			get => GetProperty(ref _poseCorrectionGroup);
			set => SetProperty(ref _poseCorrectionGroup, value);
		}

		public scnPoseCorrectionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
