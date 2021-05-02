using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PostponedCursorContext : CVariable
	{
		private CName _context;
		private CHandle<inkUserData> _data;

		[Ordinal(0)] 
		[RED("context")] 
		public CName Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<inkUserData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public PostponedCursorContext(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
