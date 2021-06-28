using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnIKEvent : scnSceneEvent
	{
		private scnIKEventData _ikData;

		[Ordinal(6)] 
		[RED("ikData")] 
		public scnIKEventData IkData
		{
			get => GetProperty(ref _ikData);
			set => SetProperty(ref _ikData, value);
		}

		public scnIKEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
