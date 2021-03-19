using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SInspectableClue : CVariable
	{
		private CName _clueName;
		private CBool _isScanned;

		[Ordinal(0)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get => GetProperty(ref _clueName);
			set => SetProperty(ref _clueName, value);
		}

		[Ordinal(1)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetProperty(ref _isScanned);
			set => SetProperty(ref _isScanned, value);
		}

		public SInspectableClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
