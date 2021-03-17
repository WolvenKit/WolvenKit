using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterSpawned_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _objectRef;
		private CHandle<questComparisonParam> _comparisonParams;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("comparisonParams")] 
		public CHandle<questComparisonParam> ComparisonParams
		{
			get => GetProperty(ref _comparisonParams);
			set => SetProperty(ref _comparisonParams, value);
		}

		public questCharacterSpawned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
