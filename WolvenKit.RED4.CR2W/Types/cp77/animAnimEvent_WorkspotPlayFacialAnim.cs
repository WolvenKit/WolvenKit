using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_WorkspotPlayFacialAnim : animAnimEvent
	{
		private CName _facialAnimName;

		[Ordinal(3)] 
		[RED("facialAnimName")] 
		public CName FacialAnimName
		{
			get => GetProperty(ref _facialAnimName);
			set => SetProperty(ref _facialAnimName, value);
		}

		public animAnimEvent_WorkspotPlayFacialAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
