
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHackingMiniGame_Record
	{
		[RED("allowedTraps")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AllowedTraps
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("bufferModifier")]
		[REDProperty(IsIgnored = true)]
		public CInt32 BufferModifier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("dimension")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Dimension
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("enemyNetrunnerLevel")]
		[REDProperty(IsIgnored = true)]
		public CInt32 EnemyNetrunnerLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("gameType")]
		[REDProperty(IsIgnored = true)]
		public CInt32 GameType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hasEnemyNetrunner")]
		[REDProperty(IsIgnored = true)]
		public CBool HasEnemyNetrunner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hasHiddenCells")]
		[REDProperty(IsIgnored = true)]
		public CBool HasHiddenCells
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hasInitialTimer")]
		[REDProperty(IsIgnored = true)]
		public CBool HasInitialTimer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hiddenCellsProbability")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HiddenCellsProbability
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("initialTimer")]
		[REDProperty(IsIgnored = true)]
		public CInt32 InitialTimer
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("networkLevel")]
		[REDProperty(IsIgnored = true)]
		public CInt32 NetworkLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("officer")]
		[REDProperty(IsIgnored = true)]
		public CBool Officer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("predefinedBasicAccess")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> PredefinedBasicAccess
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("predefinedCyberdeckPrograms")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> PredefinedCyberdeckPrograms
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("predefinedEnemyPrograms")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> PredefinedEnemyPrograms
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("predefinedGrid")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> PredefinedGrid
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("predefinedNetworkPrograms")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> PredefinedNetworkPrograms
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("symbolProbabilities")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> SymbolProbabilities
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("symbolProbabilitiesAlternative")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> SymbolProbabilitiesAlternative
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("symbols")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> Symbols
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
	}
}
