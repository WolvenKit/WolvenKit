using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorTypeRef : RedBaseClass
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
	}
}
