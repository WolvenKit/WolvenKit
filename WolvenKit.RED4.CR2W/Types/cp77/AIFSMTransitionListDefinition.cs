using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFSMTransitionListDefinition : CVariable
	{
		private CUInt16 _firstTransitionIndex;
		private CUInt16 _transitionsCount;

		[Ordinal(0)] 
		[RED("firstTransitionIndex")] 
		public CUInt16 FirstTransitionIndex
		{
			get => GetProperty(ref _firstTransitionIndex);
			set => SetProperty(ref _firstTransitionIndex, value);
		}

		[Ordinal(1)] 
		[RED("transitionsCount")] 
		public CUInt16 TransitionsCount
		{
			get => GetProperty(ref _transitionsCount);
			set => SetProperty(ref _transitionsCount, value);
		}

		public AIFSMTransitionListDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
