using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDClueData : CVariable
	{
		private CBool _isClue;
		private CName _clueGroupID;

		[Ordinal(0)] 
		[RED("isClue")] 
		public CBool IsClue
		{
			get => GetProperty(ref _isClue);
			set => SetProperty(ref _isClue, value);
		}

		[Ordinal(1)] 
		[RED("clueGroupID")] 
		public CName ClueGroupID
		{
			get => GetProperty(ref _clueGroupID);
			set => SetProperty(ref _clueGroupID, value);
		}

		public HUDClueData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
