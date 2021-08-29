using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCTypePrereq : gameIScriptablePrereq
	{
		private CArray<CEnum<gamedataNPCType>> _allowedTypes;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("allowedTypes")] 
		public CArray<CEnum<gamedataNPCType>> AllowedTypes
		{
			get => GetProperty(ref _allowedTypes);
			set => SetProperty(ref _allowedTypes, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}
	}
}
