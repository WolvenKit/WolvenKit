using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinData : gamemappinsIMappinData
	{
		private TweakDBID _mappinType;
		private CEnum<gamedataMappinVariant> _variant;
		private CBool _active;
		private CString _debugCaption;
		private LocalizationString _localizedCaption;
		private CBool _visibleThroughWalls;
		private CHandle<gamemappinsMappinScriptData> _scriptData;

		[Ordinal(0)] 
		[RED("mappinType")] 
		public TweakDBID MappinType
		{
			get => GetProperty(ref _mappinType);
			set => SetProperty(ref _mappinType, value);
		}

		[Ordinal(1)] 
		[RED("variant")] 
		public CEnum<gamedataMappinVariant> Variant
		{
			get => GetProperty(ref _variant);
			set => SetProperty(ref _variant, value);
		}

		[Ordinal(2)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(3)] 
		[RED("debugCaption")] 
		public CString DebugCaption
		{
			get => GetProperty(ref _debugCaption);
			set => SetProperty(ref _debugCaption, value);
		}

		[Ordinal(4)] 
		[RED("localizedCaption")] 
		public LocalizationString LocalizedCaption
		{
			get => GetProperty(ref _localizedCaption);
			set => SetProperty(ref _localizedCaption, value);
		}

		[Ordinal(5)] 
		[RED("visibleThroughWalls")] 
		public CBool VisibleThroughWalls
		{
			get => GetProperty(ref _visibleThroughWalls);
			set => SetProperty(ref _visibleThroughWalls, value);
		}

		[Ordinal(6)] 
		[RED("scriptData")] 
		public CHandle<gamemappinsMappinScriptData> ScriptData
		{
			get => GetProperty(ref _scriptData);
			set => SetProperty(ref _scriptData, value);
		}

		public gamemappinsMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
