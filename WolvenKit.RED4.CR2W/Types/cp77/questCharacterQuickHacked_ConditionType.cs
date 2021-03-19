using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterQuickHacked_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _objectRef;
		private CBool _quickHacked;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("quickHacked")] 
		public CBool QuickHacked
		{
			get => GetProperty(ref _quickHacked);
			set => SetProperty(ref _quickHacked, value);
		}

		public questCharacterQuickHacked_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
