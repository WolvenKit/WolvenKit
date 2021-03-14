using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEffectDesc : ISerializable
	{
		private CRUID _id;
		private CName _effectName;
		private raRef<worldEffect> _effect;
		private worldCompiledEffectInfo _compiledEffectInfo;
		private CName _autoSpawnTag;
		private CBool _isAutoSpawn;
		private CUInt8 _randomWeight;

		[Ordinal(0)] 
		[RED("id")] 
		public CRUID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CRUID) CR2WTypeManager.Create("CRUID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("effect")] 
		public raRef<worldEffect> Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("compiledEffectInfo")] 
		public worldCompiledEffectInfo CompiledEffectInfo
		{
			get
			{
				if (_compiledEffectInfo == null)
				{
					_compiledEffectInfo = (worldCompiledEffectInfo) CR2WTypeManager.Create("worldCompiledEffectInfo", "compiledEffectInfo", cr2w, this);
				}
				return _compiledEffectInfo;
			}
			set
			{
				if (_compiledEffectInfo == value)
				{
					return;
				}
				_compiledEffectInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("autoSpawnTag")] 
		public CName AutoSpawnTag
		{
			get
			{
				if (_autoSpawnTag == null)
				{
					_autoSpawnTag = (CName) CR2WTypeManager.Create("CName", "autoSpawnTag", cr2w, this);
				}
				return _autoSpawnTag;
			}
			set
			{
				if (_autoSpawnTag == value)
				{
					return;
				}
				_autoSpawnTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isAutoSpawn")] 
		public CBool IsAutoSpawn
		{
			get
			{
				if (_isAutoSpawn == null)
				{
					_isAutoSpawn = (CBool) CR2WTypeManager.Create("Bool", "isAutoSpawn", cr2w, this);
				}
				return _isAutoSpawn;
			}
			set
			{
				if (_isAutoSpawn == value)
				{
					return;
				}
				_isAutoSpawn = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("randomWeight")] 
		public CUInt8 RandomWeight
		{
			get
			{
				if (_randomWeight == null)
				{
					_randomWeight = (CUInt8) CR2WTypeManager.Create("Uint8", "randomWeight", cr2w, this);
				}
				return _randomWeight;
			}
			set
			{
				if (_randomWeight == value)
				{
					return;
				}
				_randomWeight = value;
				PropertySet(this);
			}
		}

		public entEffectDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
