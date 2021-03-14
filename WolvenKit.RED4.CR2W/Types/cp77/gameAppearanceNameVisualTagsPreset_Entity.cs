using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAppearanceNameVisualTagsPreset_Entity : ISerializable
	{
		private CUInt64 _entityPathHash;
		private CName _debugEntityPath;
		private CUInt64 _entityRigPathHash;
		private CName _debugEntityRigPath;
		private redTagList _commonVisualTags;
		private CArray<gameAppearanceNameVisualTagsPreset_AppearanceTags> _appearancesToTags;

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
		[RED("entityRigPathHash")] 
		public CUInt64 EntityRigPathHash
		{
			get
			{
				if (_entityRigPathHash == null)
				{
					_entityRigPathHash = (CUInt64) CR2WTypeManager.Create("Uint64", "entityRigPathHash", cr2w, this);
				}
				return _entityRigPathHash;
			}
			set
			{
				if (_entityRigPathHash == value)
				{
					return;
				}
				_entityRigPathHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("debugEntityRigPath")] 
		public CName DebugEntityRigPath
		{
			get
			{
				if (_debugEntityRigPath == null)
				{
					_debugEntityRigPath = (CName) CR2WTypeManager.Create("CName", "debugEntityRigPath", cr2w, this);
				}
				return _debugEntityRigPath;
			}
			set
			{
				if (_debugEntityRigPath == value)
				{
					return;
				}
				_debugEntityRigPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("commonVisualTags")] 
		public redTagList CommonVisualTags
		{
			get
			{
				if (_commonVisualTags == null)
				{
					_commonVisualTags = (redTagList) CR2WTypeManager.Create("redTagList", "commonVisualTags", cr2w, this);
				}
				return _commonVisualTags;
			}
			set
			{
				if (_commonVisualTags == value)
				{
					return;
				}
				_commonVisualTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("appearancesToTags")] 
		public CArray<gameAppearanceNameVisualTagsPreset_AppearanceTags> AppearancesToTags
		{
			get
			{
				if (_appearancesToTags == null)
				{
					_appearancesToTags = (CArray<gameAppearanceNameVisualTagsPreset_AppearanceTags>) CR2WTypeManager.Create("array:gameAppearanceNameVisualTagsPreset_AppearanceTags", "appearancesToTags", cr2w, this);
				}
				return _appearancesToTags;
			}
			set
			{
				if (_appearancesToTags == value)
				{
					return;
				}
				_appearancesToTags = value;
				PropertySet(this);
			}
		}

		public gameAppearanceNameVisualTagsPreset_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
