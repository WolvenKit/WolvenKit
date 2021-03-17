using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipDataRequirements : IScriptable
	{
		private CBool _isLevelRequirementNotMet;
		private CBool _isSmartlinkRequirementNotMet;
		private CBool _isStrengthRequirementNotMet;
		private CBool _isReflexRequirementNotMet;
		private CBool _isAnyStatRequirementNotMet;
		private CString _strengthOrReflexStatName;
		private CString _anyStatName;
		private CString _anyStatColor;
		private CString _anyStatLocKey;
		private CInt32 _strengthOrReflexValue;
		private CInt32 _anyStatValue;
		private CInt32 _requiredLevel;

		[Ordinal(0)] 
		[RED("isLevelRequirementNotMet")] 
		public CBool IsLevelRequirementNotMet
		{
			get => GetProperty(ref _isLevelRequirementNotMet);
			set => SetProperty(ref _isLevelRequirementNotMet, value);
		}

		[Ordinal(1)] 
		[RED("isSmartlinkRequirementNotMet")] 
		public CBool IsSmartlinkRequirementNotMet
		{
			get => GetProperty(ref _isSmartlinkRequirementNotMet);
			set => SetProperty(ref _isSmartlinkRequirementNotMet, value);
		}

		[Ordinal(2)] 
		[RED("isStrengthRequirementNotMet")] 
		public CBool IsStrengthRequirementNotMet
		{
			get => GetProperty(ref _isStrengthRequirementNotMet);
			set => SetProperty(ref _isStrengthRequirementNotMet, value);
		}

		[Ordinal(3)] 
		[RED("isReflexRequirementNotMet")] 
		public CBool IsReflexRequirementNotMet
		{
			get => GetProperty(ref _isReflexRequirementNotMet);
			set => SetProperty(ref _isReflexRequirementNotMet, value);
		}

		[Ordinal(4)] 
		[RED("isAnyStatRequirementNotMet")] 
		public CBool IsAnyStatRequirementNotMet
		{
			get => GetProperty(ref _isAnyStatRequirementNotMet);
			set => SetProperty(ref _isAnyStatRequirementNotMet, value);
		}

		[Ordinal(5)] 
		[RED("strengthOrReflexStatName")] 
		public CString StrengthOrReflexStatName
		{
			get => GetProperty(ref _strengthOrReflexStatName);
			set => SetProperty(ref _strengthOrReflexStatName, value);
		}

		[Ordinal(6)] 
		[RED("anyStatName")] 
		public CString AnyStatName
		{
			get => GetProperty(ref _anyStatName);
			set => SetProperty(ref _anyStatName, value);
		}

		[Ordinal(7)] 
		[RED("anyStatColor")] 
		public CString AnyStatColor
		{
			get => GetProperty(ref _anyStatColor);
			set => SetProperty(ref _anyStatColor, value);
		}

		[Ordinal(8)] 
		[RED("anyStatLocKey")] 
		public CString AnyStatLocKey
		{
			get => GetProperty(ref _anyStatLocKey);
			set => SetProperty(ref _anyStatLocKey, value);
		}

		[Ordinal(9)] 
		[RED("strengthOrReflexValue")] 
		public CInt32 StrengthOrReflexValue
		{
			get => GetProperty(ref _strengthOrReflexValue);
			set => SetProperty(ref _strengthOrReflexValue, value);
		}

		[Ordinal(10)] 
		[RED("anyStatValue")] 
		public CInt32 AnyStatValue
		{
			get => GetProperty(ref _anyStatValue);
			set => SetProperty(ref _anyStatValue, value);
		}

		[Ordinal(11)] 
		[RED("requiredLevel")] 
		public CInt32 RequiredLevel
		{
			get => GetProperty(ref _requiredLevel);
			set => SetProperty(ref _requiredLevel, value);
		}

		public MinimalItemTooltipDataRequirements(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
