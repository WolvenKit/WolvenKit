using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStartRecording_NodeType : questIRecordingNodeType
	{
		private CBool _enabled;
		private CString _sectionName;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(1)] 
		[RED("sectionName")] 
		public CString SectionName
		{
			get => GetProperty(ref _sectionName);
			set => SetProperty(ref _sectionName, value);
		}

		public questStartRecording_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
