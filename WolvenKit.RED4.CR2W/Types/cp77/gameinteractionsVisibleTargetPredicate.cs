using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsVisibleTargetPredicate : gameinteractionsIPredicateType
	{
		private CBool _stopOnTransparent;

		[Ordinal(0)] 
		[RED("stopOnTransparent")] 
		public CBool StopOnTransparent
		{
			get => GetProperty(ref _stopOnTransparent);
			set => SetProperty(ref _stopOnTransparent, value);
		}

		public gameinteractionsVisibleTargetPredicate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
