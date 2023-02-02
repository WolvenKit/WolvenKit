
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMinigame_Def_Record
	{
		[RED("additionalProgramsList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AdditionalProgramsList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("bufferFullExitText")]
		[REDProperty(IsIgnored = true)]
		public CName BufferFullExitText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("bufferSize")]
		[REDProperty(IsIgnored = true)]
		public CInt32 BufferSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("canceledExitText")]
		[REDProperty(IsIgnored = true)]
		public CName CanceledExitText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("defaultTrap")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DefaultTrap
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("extraDifficulty")]
		[REDProperty(IsIgnored = true)]
		public CFloat ExtraDifficulty
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("failExitText")]
		[REDProperty(IsIgnored = true)]
		public CName FailExitText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("forbiddenProgramsList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ForbiddenProgramsList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("genericExitText")]
		[REDProperty(IsIgnored = true)]
		public CName GenericExitText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("greatSuccessExitText")]
		[REDProperty(IsIgnored = true)]
		public CName GreatSuccessExitText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("gridSize")]
		[REDProperty(IsIgnored = true)]
		public CInt32 GridSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("gridSymbols")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> GridSymbols
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("gridTraps")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> GridTraps
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("noTraps")]
		[REDProperty(IsIgnored = true)]
		public CBool NoTraps
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("overlapProbability")]
		[REDProperty(IsIgnored = true)]
		public CFloat OverlapProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("overrideProgramsList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OverrideProgramsList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("saveSeed")]
		[REDProperty(IsIgnored = true)]
		public CBool SaveSeed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("successExitText")]
		[REDProperty(IsIgnored = true)]
		public CName SuccessExitText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("timeLimit")]
		[REDProperty(IsIgnored = true)]
		public CFloat TimeLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("timeOutExitText")]
		[REDProperty(IsIgnored = true)]
		public CName TimeOutExitText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("trapsProbability")]
		[REDProperty(IsIgnored = true)]
		public CFloat TrapsProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useProgression")]
		[REDProperty(IsIgnored = true)]
		public CBool UseProgression
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
