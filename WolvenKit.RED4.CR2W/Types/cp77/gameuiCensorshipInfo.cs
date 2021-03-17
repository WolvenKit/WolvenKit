using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCensorshipInfo : CVariable
	{
		private CEnum<CensorshipFlags> _censorFlag;
		private CEnum<gameuiCharacterCustomizationActionType> _censorFlagAction;

		[Ordinal(0)] 
		[RED("censorFlag")] 
		public CEnum<CensorshipFlags> CensorFlag
		{
			get => GetProperty(ref _censorFlag);
			set => SetProperty(ref _censorFlag, value);
		}

		[Ordinal(1)] 
		[RED("censorFlagAction")] 
		public CEnum<gameuiCharacterCustomizationActionType> CensorFlagAction
		{
			get => GetProperty(ref _censorFlagAction);
			set => SetProperty(ref _censorFlagAction, value);
		}

		public gameuiCensorshipInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
