using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceQuestInfo : CVariable
	{
		private CBool _isHighlighted;
		private CName _factName;

		[Ordinal(0)] 
		[RED("isHighlighted")] 
		public CBool IsHighlighted
		{
			get => GetProperty(ref _isHighlighted);
			set => SetProperty(ref _isHighlighted, value);
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		public gamedeviceQuestInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
