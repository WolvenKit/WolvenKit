using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTypeRef : CVariable
	{
		private CBool _isSet;
		private CName _customType;
		private CEnum<AIArgumentType> _enumeratedType;

		[Ordinal(0)] 
		[RED("isSet")] 
		public CBool IsSet
		{
			get => GetProperty(ref _isSet);
			set => SetProperty(ref _isSet, value);
		}

		[Ordinal(1)] 
		[RED("customType")] 
		public CName CustomType
		{
			get => GetProperty(ref _customType);
			set => SetProperty(ref _customType, value);
		}

		[Ordinal(2)] 
		[RED("enumeratedType")] 
		public CEnum<AIArgumentType> EnumeratedType
		{
			get => GetProperty(ref _enumeratedType);
			set => SetProperty(ref _enumeratedType, value);
		}

		public AIbehaviorTypeRef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
