using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SSFXOperationData : RedBaseClass
	{
		private CName _sfxName;
		private CEnum<EEffectOperationType> _operationType;

		[Ordinal(0)] 
		[RED("sfxName")] 
		public CName SfxName
		{
			get => GetProperty(ref _sfxName);
			set => SetProperty(ref _sfxName, value);
		}

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<EEffectOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}
	}
}
