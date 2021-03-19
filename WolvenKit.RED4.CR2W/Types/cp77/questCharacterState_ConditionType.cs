using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterState_ConditionType : questICharacterConditionType
	{
		private CHandle<questICharacterConditionSubType> _subType;

		[Ordinal(0)] 
		[RED("subType")] 
		public CHandle<questICharacterConditionSubType> SubType
		{
			get => GetProperty(ref _subType);
			set => SetProperty(ref _subType, value);
		}

		public questCharacterState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
