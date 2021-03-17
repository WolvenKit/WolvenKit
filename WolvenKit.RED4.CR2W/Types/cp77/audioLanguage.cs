using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLanguage : CVariable
	{
		private CString _longName;
		private CString _codeName;
		private CBool _hasVO;

		[Ordinal(0)] 
		[RED("longName")] 
		public CString LongName
		{
			get => GetProperty(ref _longName);
			set => SetProperty(ref _longName, value);
		}

		[Ordinal(1)] 
		[RED("codeName")] 
		public CString CodeName
		{
			get => GetProperty(ref _codeName);
			set => SetProperty(ref _codeName, value);
		}

		[Ordinal(2)] 
		[RED("hasVO")] 
		public CBool HasVO
		{
			get => GetProperty(ref _hasVO);
			set => SetProperty(ref _hasVO, value);
		}

		public audioLanguage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
