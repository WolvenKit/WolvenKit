using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLookAtEvent : scnSceneEvent
	{
		private scnLookAtBasicEventData _basicData;

		[Ordinal(6)] 
		[RED("basicData")] 
		public scnLookAtBasicEventData BasicData
		{
			get => GetProperty(ref _basicData);
			set => SetProperty(ref _basicData, value);
		}

		public scnLookAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
