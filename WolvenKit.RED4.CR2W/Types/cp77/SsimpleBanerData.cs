using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SsimpleBanerData : CVariable
	{
		private CString _title;
		private CString _description;
		private redResourceReferenceScriptToken _content;

		[Ordinal(0)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(2)] 
		[RED("content")] 
		public redResourceReferenceScriptToken Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}

		public SsimpleBanerData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
