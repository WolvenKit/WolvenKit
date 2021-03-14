using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubCharacterSystem : gameScriptableSystem
	{
		private CArray<SSubCharacter> _uniqueSubCharacters;
		private CBool _scriptSpawnedFlathead;
		private CBool _isDespawningFlathead;

		[Ordinal(0)] 
		[RED("uniqueSubCharacters")] 
		public CArray<SSubCharacter> UniqueSubCharacters
		{
			get
			{
				if (_uniqueSubCharacters == null)
				{
					_uniqueSubCharacters = (CArray<SSubCharacter>) CR2WTypeManager.Create("array:SSubCharacter", "uniqueSubCharacters", cr2w, this);
				}
				return _uniqueSubCharacters;
			}
			set
			{
				if (_uniqueSubCharacters == value)
				{
					return;
				}
				_uniqueSubCharacters = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("scriptSpawnedFlathead")] 
		public CBool ScriptSpawnedFlathead
		{
			get
			{
				if (_scriptSpawnedFlathead == null)
				{
					_scriptSpawnedFlathead = (CBool) CR2WTypeManager.Create("Bool", "scriptSpawnedFlathead", cr2w, this);
				}
				return _scriptSpawnedFlathead;
			}
			set
			{
				if (_scriptSpawnedFlathead == value)
				{
					return;
				}
				_scriptSpawnedFlathead = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isDespawningFlathead")] 
		public CBool IsDespawningFlathead
		{
			get
			{
				if (_isDespawningFlathead == null)
				{
					_isDespawningFlathead = (CBool) CR2WTypeManager.Create("Bool", "isDespawningFlathead", cr2w, this);
				}
				return _isDespawningFlathead;
			}
			set
			{
				if (_isDespawningFlathead == value)
				{
					return;
				}
				_isDespawningFlathead = value;
				PropertySet(this);
			}
		}

		public SubCharacterSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
