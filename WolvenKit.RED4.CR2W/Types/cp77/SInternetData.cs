using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SInternetData : CVariable
	{
		private CString _startingPage;

		[Ordinal(0)] 
		[RED("startingPage")] 
		public CString StartingPage
		{
			get => GetProperty(ref _startingPage);
			set => SetProperty(ref _startingPage, value);
		}

		public SInternetData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
