using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsLookAtPredicate : gameinteractionsIPredicateType
	{
		private CEnum<gameinteractionsELookAtTarget> _testTarget;
		private CEnum<gameinteractionsELookAtTest> _testType;
		private CBool _stopOnTransparent;

		[Ordinal(0)] 
		[RED("testTarget")] 
		public CEnum<gameinteractionsELookAtTarget> TestTarget
		{
			get => GetProperty(ref _testTarget);
			set => SetProperty(ref _testTarget, value);
		}

		[Ordinal(1)] 
		[RED("testType")] 
		public CEnum<gameinteractionsELookAtTest> TestType
		{
			get => GetProperty(ref _testType);
			set => SetProperty(ref _testType, value);
		}

		[Ordinal(2)] 
		[RED("stopOnTransparent")] 
		public CBool StopOnTransparent
		{
			get => GetProperty(ref _stopOnTransparent);
			set => SetProperty(ref _stopOnTransparent, value);
		}

		public gameinteractionsLookAtPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
