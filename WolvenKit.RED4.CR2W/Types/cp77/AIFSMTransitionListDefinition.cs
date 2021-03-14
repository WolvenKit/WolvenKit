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
			get
			{
				if (_firstTransitionIndex == null)
				{
					_firstTransitionIndex = (CUInt16) CR2WTypeManager.Create("Uint16", "firstTransitionIndex", cr2w, this);
				}
				return _firstTransitionIndex;
			}
			set
			{
				if (_firstTransitionIndex == value)
				{
					return;
				}
				_firstTransitionIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transitionsCount")] 
		public CUInt16 TransitionsCount
		{
			get
			{
				if (_transitionsCount == null)
				{
					_transitionsCount = (CUInt16) CR2WTypeManager.Create("Uint16", "transitionsCount", cr2w, this);
				}
				return _transitionsCount;
			}
			set
			{
				if (_transitionsCount == value)
				{
					return;
				}
				_transitionsCount = value;
				PropertySet(this);
			}
		}

		public AIFSMTransitionListDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
