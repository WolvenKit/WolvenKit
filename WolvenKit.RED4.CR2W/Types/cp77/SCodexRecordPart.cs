using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCodexRecordPart : CVariable
	{
		private CName _partName;
		private CString _partContent;
		private CBool _unlocked;

		[Ordinal(0)] 
		[RED("PartName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		[Ordinal(1)] 
		[RED("PartContent")] 
		public CString PartContent
		{
			get => GetProperty(ref _partContent);
			set => SetProperty(ref _partContent, value);
		}

		[Ordinal(2)] 
		[RED("Unlocked")] 
		public CBool Unlocked
		{
			get => GetProperty(ref _unlocked);
			set => SetProperty(ref _unlocked, value);
		}

		public SCodexRecordPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
