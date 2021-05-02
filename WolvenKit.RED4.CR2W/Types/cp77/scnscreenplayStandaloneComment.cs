using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayStandaloneComment : CVariable
	{
		private scnscreenplayItemId _itemId;
		private CString _comment;

		[Ordinal(0)] 
		[RED("itemId")] 
		public scnscreenplayItemId ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(1)] 
		[RED("comment")] 
		public CString Comment
		{
			get => GetProperty(ref _comment);
			set => SetProperty(ref _comment, value);
		}

		public scnscreenplayStandaloneComment(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
