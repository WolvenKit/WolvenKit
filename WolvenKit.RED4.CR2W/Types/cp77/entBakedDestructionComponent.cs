using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entBakedDestructionComponent : entPhysicalMeshComponent
	{
		private raRef<CMesh> _meshFractured;
		private CName _meshFracturedAppearance;
		private CFloat _numFrames;
		private CFloat _frameRate;
		private CBool _playOnlyOnce;
		private CBool _restartOnTrigger;
		private CBool _disableCollidersOnTrigger;
		private CFloat _damageThreshold;
		private CFloat _damageEndurance;
		private CFloat _impulseToDamage;
		private CFloat _contactToDamage;
		private CBool _accumulateDamage;
		private raRef<worldEffect> _destructionEffect;
		private CName _audioMetadata;
		private DataBuffer _compiledBufferFractured;

		[Ordinal(28)] 
		[RED("meshFractured")] 
		public raRef<CMesh> MeshFractured
		{
			get
			{
				if (_meshFractured == null)
				{
					_meshFractured = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "meshFractured", cr2w, this);
				}
				return _meshFractured;
			}
			set
			{
				if (_meshFractured == value)
				{
					return;
				}
				_meshFractured = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("meshFracturedAppearance")] 
		public CName MeshFracturedAppearance
		{
			get
			{
				if (_meshFracturedAppearance == null)
				{
					_meshFracturedAppearance = (CName) CR2WTypeManager.Create("CName", "meshFracturedAppearance", cr2w, this);
				}
				return _meshFracturedAppearance;
			}
			set
			{
				if (_meshFracturedAppearance == value)
				{
					return;
				}
				_meshFracturedAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("numFrames")] 
		public CFloat NumFrames
		{
			get
			{
				if (_numFrames == null)
				{
					_numFrames = (CFloat) CR2WTypeManager.Create("Float", "numFrames", cr2w, this);
				}
				return _numFrames;
			}
			set
			{
				if (_numFrames == value)
				{
					return;
				}
				_numFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("frameRate")] 
		public CFloat FrameRate
		{
			get
			{
				if (_frameRate == null)
				{
					_frameRate = (CFloat) CR2WTypeManager.Create("Float", "frameRate", cr2w, this);
				}
				return _frameRate;
			}
			set
			{
				if (_frameRate == value)
				{
					return;
				}
				_frameRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("playOnlyOnce")] 
		public CBool PlayOnlyOnce
		{
			get
			{
				if (_playOnlyOnce == null)
				{
					_playOnlyOnce = (CBool) CR2WTypeManager.Create("Bool", "playOnlyOnce", cr2w, this);
				}
				return _playOnlyOnce;
			}
			set
			{
				if (_playOnlyOnce == value)
				{
					return;
				}
				_playOnlyOnce = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("restartOnTrigger")] 
		public CBool RestartOnTrigger
		{
			get
			{
				if (_restartOnTrigger == null)
				{
					_restartOnTrigger = (CBool) CR2WTypeManager.Create("Bool", "restartOnTrigger", cr2w, this);
				}
				return _restartOnTrigger;
			}
			set
			{
				if (_restartOnTrigger == value)
				{
					return;
				}
				_restartOnTrigger = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("disableCollidersOnTrigger")] 
		public CBool DisableCollidersOnTrigger
		{
			get
			{
				if (_disableCollidersOnTrigger == null)
				{
					_disableCollidersOnTrigger = (CBool) CR2WTypeManager.Create("Bool", "disableCollidersOnTrigger", cr2w, this);
				}
				return _disableCollidersOnTrigger;
			}
			set
			{
				if (_disableCollidersOnTrigger == value)
				{
					return;
				}
				_disableCollidersOnTrigger = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get
			{
				if (_damageThreshold == null)
				{
					_damageThreshold = (CFloat) CR2WTypeManager.Create("Float", "damageThreshold", cr2w, this);
				}
				return _damageThreshold;
			}
			set
			{
				if (_damageThreshold == value)
				{
					return;
				}
				_damageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("damageEndurance")] 
		public CFloat DamageEndurance
		{
			get
			{
				if (_damageEndurance == null)
				{
					_damageEndurance = (CFloat) CR2WTypeManager.Create("Float", "damageEndurance", cr2w, this);
				}
				return _damageEndurance;
			}
			set
			{
				if (_damageEndurance == value)
				{
					return;
				}
				_damageEndurance = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("impulseToDamage")] 
		public CFloat ImpulseToDamage
		{
			get
			{
				if (_impulseToDamage == null)
				{
					_impulseToDamage = (CFloat) CR2WTypeManager.Create("Float", "impulseToDamage", cr2w, this);
				}
				return _impulseToDamage;
			}
			set
			{
				if (_impulseToDamage == value)
				{
					return;
				}
				_impulseToDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("contactToDamage")] 
		public CFloat ContactToDamage
		{
			get
			{
				if (_contactToDamage == null)
				{
					_contactToDamage = (CFloat) CR2WTypeManager.Create("Float", "contactToDamage", cr2w, this);
				}
				return _contactToDamage;
			}
			set
			{
				if (_contactToDamage == value)
				{
					return;
				}
				_contactToDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("accumulateDamage")] 
		public CBool AccumulateDamage
		{
			get
			{
				if (_accumulateDamage == null)
				{
					_accumulateDamage = (CBool) CR2WTypeManager.Create("Bool", "accumulateDamage", cr2w, this);
				}
				return _accumulateDamage;
			}
			set
			{
				if (_accumulateDamage == value)
				{
					return;
				}
				_accumulateDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("destructionEffect")] 
		public raRef<worldEffect> DestructionEffect
		{
			get
			{
				if (_destructionEffect == null)
				{
					_destructionEffect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "destructionEffect", cr2w, this);
				}
				return _destructionEffect;
			}
			set
			{
				if (_destructionEffect == value)
				{
					return;
				}
				_destructionEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get
			{
				if (_audioMetadata == null)
				{
					_audioMetadata = (CName) CR2WTypeManager.Create("CName", "audioMetadata", cr2w, this);
				}
				return _audioMetadata;
			}
			set
			{
				if (_audioMetadata == value)
				{
					return;
				}
				_audioMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("compiledBufferFractured")] 
		public DataBuffer CompiledBufferFractured
		{
			get
			{
				if (_compiledBufferFractured == null)
				{
					_compiledBufferFractured = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "compiledBufferFractured", cr2w, this);
				}
				return _compiledBufferFractured;
			}
			set
			{
				if (_compiledBufferFractured == value)
				{
					return;
				}
				_compiledBufferFractured = value;
				PropertySet(this);
			}
		}

		public entBakedDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
