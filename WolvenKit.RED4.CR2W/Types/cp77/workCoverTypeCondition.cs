using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workCoverTypeCondition : workIWorkspotCondition
	{
		private CBool _isHighCover;

		[Ordinal(2)] 
		[RED("isHighCover")] 
		public CBool IsHighCover
		{
			get => GetProperty(ref _isHighCover);
			set => SetProperty(ref _isHighCover, value);
		}

		public workCoverTypeCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
