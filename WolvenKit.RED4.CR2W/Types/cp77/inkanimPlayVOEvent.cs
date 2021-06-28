using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimPlayVOEvent : inkanimEvent
	{
		private CString _vOLine;
		private CString _speakerName;

		[Ordinal(1)] 
		[RED("VOLine")] 
		public CString VOLine
		{
			get => GetProperty(ref _vOLine);
			set => SetProperty(ref _vOLine, value);
		}

		[Ordinal(2)] 
		[RED("speakerName")] 
		public CString SpeakerName
		{
			get => GetProperty(ref _speakerName);
			set => SetProperty(ref _speakerName, value);
		}

		public inkanimPlayVOEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
