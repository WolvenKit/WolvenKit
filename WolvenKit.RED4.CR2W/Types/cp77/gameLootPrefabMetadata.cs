using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootPrefabMetadata : worldPrefabMetadata
	{
		private CArray<TweakDBID> _lootTableTDBIDs;
		private CBool _ignoreParentPrefabs;
		private TweakDBID _contentAssignment;

		[Ordinal(0)] 
		[RED("lootTableTDBIDs")] 
		public CArray<TweakDBID> LootTableTDBIDs
		{
			get
			{
				if (_lootTableTDBIDs == null)
				{
					_lootTableTDBIDs = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "lootTableTDBIDs", cr2w, this);
				}
				return _lootTableTDBIDs;
			}
			set
			{
				if (_lootTableTDBIDs == value)
				{
					return;
				}
				_lootTableTDBIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ignoreParentPrefabs")] 
		public CBool IgnoreParentPrefabs
		{
			get
			{
				if (_ignoreParentPrefabs == null)
				{
					_ignoreParentPrefabs = (CBool) CR2WTypeManager.Create("Bool", "ignoreParentPrefabs", cr2w, this);
				}
				return _ignoreParentPrefabs;
			}
			set
			{
				if (_ignoreParentPrefabs == value)
				{
					return;
				}
				_ignoreParentPrefabs = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("contentAssignment")] 
		public TweakDBID ContentAssignment
		{
			get
			{
				if (_contentAssignment == null)
				{
					_contentAssignment = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "contentAssignment", cr2w, this);
				}
				return _contentAssignment;
			}
			set
			{
				if (_contentAssignment == value)
				{
					return;
				}
				_contentAssignment = value;
				PropertySet(this);
			}
		}

		public gameLootPrefabMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
