using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisualTagsAppearanceNamesPreset_Entity : ISerializable
	{
		private CUInt64 _entityPathHash;
		private CName _debugEntityPath;
		private CArray<gameVisualTagsAppearanceNamesPreset_TagsAppearances> _tagsToAppearances;

		[Ordinal(0)] 
		[RED("entityPathHash")] 
		public CUInt64 EntityPathHash
		{
			get
			{
				if (_entityPathHash == null)
				{
					_entityPathHash = (CUInt64) CR2WTypeManager.Create("Uint64", "entityPathHash", cr2w, this);
				}
				return _entityPathHash;
			}
			set
			{
				if (_entityPathHash == value)
				{
					return;
				}
				_entityPathHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("debugEntityPath")] 
		public CName DebugEntityPath
		{
			get
			{
				if (_debugEntityPath == null)
				{
					_debugEntityPath = (CName) CR2WTypeManager.Create("CName", "debugEntityPath", cr2w, this);
				}
				return _debugEntityPath;
			}
			set
			{
				if (_debugEntityPath == value)
				{
					return;
				}
				_debugEntityPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tagsToAppearances")] 
		public CArray<gameVisualTagsAppearanceNamesPreset_TagsAppearances> TagsToAppearances
		{
			get
			{
				if (_tagsToAppearances == null)
				{
					_tagsToAppearances = (CArray<gameVisualTagsAppearanceNamesPreset_TagsAppearances>) CR2WTypeManager.Create("array:gameVisualTagsAppearanceNamesPreset_TagsAppearances", "tagsToAppearances", cr2w, this);
				}
				return _tagsToAppearances;
			}
			set
			{
				if (_tagsToAppearances == value)
				{
					return;
				}
				_tagsToAppearances = value;
				PropertySet(this);
			}
		}

		public gameVisualTagsAppearanceNamesPreset_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
