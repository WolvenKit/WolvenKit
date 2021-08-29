using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationOption : IScriptable
	{
		private CHandle<gameuiCharacterCustomizationInfo> _info;
		private CEnum<gameuiCharacterCustomizationPart> _bodyPart;
		private CUInt32 _prevIndex;
		private CUInt32 _currIndex;
		private CBool _isActive;
		private CBool _isCensored;

		[Ordinal(0)] 
		[RED("info")] 
		public CHandle<gameuiCharacterCustomizationInfo> Info
		{
			get => GetProperty(ref _info);
			set => SetProperty(ref _info, value);
		}

		[Ordinal(1)] 
		[RED("bodyPart")] 
		public CEnum<gameuiCharacterCustomizationPart> BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(2)] 
		[RED("prevIndex")] 
		public CUInt32 PrevIndex
		{
			get => GetProperty(ref _prevIndex);
			set => SetProperty(ref _prevIndex, value);
		}

		[Ordinal(3)] 
		[RED("currIndex")] 
		public CUInt32 CurrIndex
		{
			get => GetProperty(ref _currIndex);
			set => SetProperty(ref _currIndex, value);
		}

		[Ordinal(4)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(5)] 
		[RED("isCensored")] 
		public CBool IsCensored
		{
			get => GetProperty(ref _isCensored);
			set => SetProperty(ref _isCensored, value);
		}
	}
}
