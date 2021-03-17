using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCRecordHasVisualTag : gameIScriptablePrereq
	{
		private CName _visualTag;
		private CBool _hasTag;

		[Ordinal(0)] 
		[RED("visualTag")] 
		public CName VisualTag
		{
			get => GetProperty(ref _visualTag);
			set => SetProperty(ref _visualTag, value);
		}

		[Ordinal(1)] 
		[RED("hasTag")] 
		public CBool HasTag
		{
			get => GetProperty(ref _hasTag);
			set => SetProperty(ref _hasTag, value);
		}

		public NPCRecordHasVisualTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
