using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RestoreStatPoolEffector : gameEffector
	{
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CFloat _valueToRestore;
		private CBool _percentage;

		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(1)] 
		[RED("valueToRestore")] 
		public CFloat ValueToRestore
		{
			get => GetProperty(ref _valueToRestore);
			set => SetProperty(ref _valueToRestore, value);
		}

		[Ordinal(2)] 
		[RED("percentage")] 
		public CBool Percentage
		{
			get => GetProperty(ref _percentage);
			set => SetProperty(ref _percentage, value);
		}
	}
}
