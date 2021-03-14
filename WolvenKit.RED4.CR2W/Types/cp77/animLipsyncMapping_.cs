using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLipsyncMapping_ : CResource
	{
		private CName _languageCodeName;
		private CArray<CUInt64> _scenePaths;
		private CArray<animLipsyncMappingSceneEntry> _sceneEntries;

		[Ordinal(1)] 
		[RED("languageCodeName")] 
		public CName LanguageCodeName
		{
			get
			{
				if (_languageCodeName == null)
				{
					_languageCodeName = (CName) CR2WTypeManager.Create("CName", "languageCodeName", cr2w, this);
				}
				return _languageCodeName;
			}
			set
			{
				if (_languageCodeName == value)
				{
					return;
				}
				_languageCodeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scenePaths")] 
		public CArray<CUInt64> ScenePaths
		{
			get
			{
				if (_scenePaths == null)
				{
					_scenePaths = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "scenePaths", cr2w, this);
				}
				return _scenePaths;
			}
			set
			{
				if (_scenePaths == value)
				{
					return;
				}
				_scenePaths = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("sceneEntries")] 
		public CArray<animLipsyncMappingSceneEntry> SceneEntries
		{
			get
			{
				if (_sceneEntries == null)
				{
					_sceneEntries = (CArray<animLipsyncMappingSceneEntry>) CR2WTypeManager.Create("array:animLipsyncMappingSceneEntry", "sceneEntries", cr2w, this);
				}
				return _sceneEntries;
			}
			set
			{
				if (_sceneEntries == value)
				{
					return;
				}
				_sceneEntries = value;
				PropertySet(this);
			}
		}

		public animLipsyncMapping_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
