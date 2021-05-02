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

		[Ordinal(29)] 
		[RED("meshFractured")] 
		public raRef<CMesh> MeshFractured
		{
			get => GetProperty(ref _meshFractured);
			set => SetProperty(ref _meshFractured, value);
		}

		[Ordinal(30)] 
		[RED("meshFracturedAppearance")] 
		public CName MeshFracturedAppearance
		{
			get => GetProperty(ref _meshFracturedAppearance);
			set => SetProperty(ref _meshFracturedAppearance, value);
		}

		[Ordinal(31)] 
		[RED("numFrames")] 
		public CFloat NumFrames
		{
			get => GetProperty(ref _numFrames);
			set => SetProperty(ref _numFrames, value);
		}

		[Ordinal(32)] 
		[RED("frameRate")] 
		public CFloat FrameRate
		{
			get => GetProperty(ref _frameRate);
			set => SetProperty(ref _frameRate, value);
		}

		[Ordinal(33)] 
		[RED("playOnlyOnce")] 
		public CBool PlayOnlyOnce
		{
			get => GetProperty(ref _playOnlyOnce);
			set => SetProperty(ref _playOnlyOnce, value);
		}

		[Ordinal(34)] 
		[RED("restartOnTrigger")] 
		public CBool RestartOnTrigger
		{
			get => GetProperty(ref _restartOnTrigger);
			set => SetProperty(ref _restartOnTrigger, value);
		}

		[Ordinal(35)] 
		[RED("disableCollidersOnTrigger")] 
		public CBool DisableCollidersOnTrigger
		{
			get => GetProperty(ref _disableCollidersOnTrigger);
			set => SetProperty(ref _disableCollidersOnTrigger, value);
		}

		[Ordinal(36)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get => GetProperty(ref _damageThreshold);
			set => SetProperty(ref _damageThreshold, value);
		}

		[Ordinal(37)] 
		[RED("damageEndurance")] 
		public CFloat DamageEndurance
		{
			get => GetProperty(ref _damageEndurance);
			set => SetProperty(ref _damageEndurance, value);
		}

		[Ordinal(38)] 
		[RED("impulseToDamage")] 
		public CFloat ImpulseToDamage
		{
			get => GetProperty(ref _impulseToDamage);
			set => SetProperty(ref _impulseToDamage, value);
		}

		[Ordinal(39)] 
		[RED("contactToDamage")] 
		public CFloat ContactToDamage
		{
			get => GetProperty(ref _contactToDamage);
			set => SetProperty(ref _contactToDamage, value);
		}

		[Ordinal(40)] 
		[RED("accumulateDamage")] 
		public CBool AccumulateDamage
		{
			get => GetProperty(ref _accumulateDamage);
			set => SetProperty(ref _accumulateDamage, value);
		}

		[Ordinal(41)] 
		[RED("destructionEffect")] 
		public raRef<worldEffect> DestructionEffect
		{
			get => GetProperty(ref _destructionEffect);
			set => SetProperty(ref _destructionEffect, value);
		}

		[Ordinal(42)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetProperty(ref _audioMetadata);
			set => SetProperty(ref _audioMetadata, value);
		}

		[Ordinal(43)] 
		[RED("compiledBufferFractured")] 
		public DataBuffer CompiledBufferFractured
		{
			get => GetProperty(ref _compiledBufferFractured);
			set => SetProperty(ref _compiledBufferFractured, value);
		}

		public entBakedDestructionComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
