using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasePerkDisplayData : IDisplayData
	{
		private TweakDBID _attributeId;
		private CName _name;
		private CString _localizedName;
		private CString _localizedDescription;
		private CName _iconID;
		private redResourceReferenceScriptToken _binkRef;
		private CInt32 _level;
		private CInt32 _maxLevel;
		private CBool _locked;
		private CEnum<gamedataProficiencyType> _proficiency;

		[Ordinal(0)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetProperty(ref _attributeId);
			set => SetProperty(ref _attributeId, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(2)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		[Ordinal(3)] 
		[RED("localizedDescription")] 
		public CString LocalizedDescription
		{
			get => GetProperty(ref _localizedDescription);
			set => SetProperty(ref _localizedDescription, value);
		}

		[Ordinal(4)] 
		[RED("iconID")] 
		public CName IconID
		{
			get => GetProperty(ref _iconID);
			set => SetProperty(ref _iconID, value);
		}

		[Ordinal(5)] 
		[RED("binkRef")] 
		public redResourceReferenceScriptToken BinkRef
		{
			get => GetProperty(ref _binkRef);
			set => SetProperty(ref _binkRef, value);
		}

		[Ordinal(6)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(7)] 
		[RED("maxLevel")] 
		public CInt32 MaxLevel
		{
			get => GetProperty(ref _maxLevel);
			set => SetProperty(ref _maxLevel, value);
		}

		[Ordinal(8)] 
		[RED("locked")] 
		public CBool Locked
		{
			get => GetProperty(ref _locked);
			set => SetProperty(ref _locked, value);
		}

		[Ordinal(9)] 
		[RED("proficiency")] 
		public CEnum<gamedataProficiencyType> Proficiency
		{
			get => GetProperty(ref _proficiency);
			set => SetProperty(ref _proficiency, value);
		}

		public BasePerkDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
