using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalPath : IScriptable
	{
		private CString _realPath;
		private CInt32 _fileEntryIndex;
		private CName _className;

		[Ordinal(0)] 
		[RED("realPath")] 
		public CString RealPath
		{
			get => GetProperty(ref _realPath);
			set => SetProperty(ref _realPath, value);
		}

		[Ordinal(1)] 
		[RED("fileEntryIndex")] 
		public CInt32 FileEntryIndex
		{
			get => GetProperty(ref _fileEntryIndex);
			set => SetProperty(ref _fileEntryIndex, value);
		}

		[Ordinal(2)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		public gameJournalPath(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
