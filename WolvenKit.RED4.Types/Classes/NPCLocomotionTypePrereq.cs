using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCLocomotionTypePrereq : gameIScriptablePrereq
	{
		private CArray<CEnum<gamedataLocomotionMode>> _locomotionMode;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("locomotionMode")] 
		public CArray<CEnum<gamedataLocomotionMode>> LocomotionMode
		{
			get => GetProperty(ref _locomotionMode);
			set => SetProperty(ref _locomotionMode, value);
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
