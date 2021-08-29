using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CooldownStorageID : RedBaseClass
	{
		private CUInt32 _iD;
		private CEnum<EBOOL> _isValid;

		[Ordinal(0)] 
		[RED("ID")] 
		public CUInt32 ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}

		[Ordinal(1)] 
		[RED("isValid")] 
		public CEnum<EBOOL> IsValid
		{
			get => GetProperty(ref _isValid);
			set => SetProperty(ref _isValid, value);
		}
	}
}
