using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterKilled_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _objectRef;
		private CHandle<questComparisonParam> _comparisonParams;
		private CBool _killed;
		private CBool _unconscious;
		private CBool _defeated;

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

		[Ordinal(2)] 
		[RED("killed")] 
		public CBool Killed
		{
			get => GetProperty(ref _killed);
			set => SetProperty(ref _killed, value);
		}

		[Ordinal(3)] 
		[RED("unconscious")] 
		public CBool Unconscious
		{
			get => GetProperty(ref _unconscious);
			set => SetProperty(ref _unconscious, value);
		}

		[Ordinal(4)] 
		[RED("defeated")] 
		public CBool Defeated
		{
			get => GetProperty(ref _defeated);
			set => SetProperty(ref _defeated, value);
		}

		public questCharacterKilled_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
