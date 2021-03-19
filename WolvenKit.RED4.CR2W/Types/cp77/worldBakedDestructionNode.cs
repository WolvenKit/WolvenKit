using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBakedDestructionNode : worldMeshNode
	{
		private raRef<CMesh> _meshFractured;
		private CName _meshFracturedAppearance;
		private CFloat _numFrames;
		private CFloat _frameRate;
		private CBool _playOnlyOnce;
		private CBool _restartOnTrigger;
		private CBool _disableCollidersOnTrigger;
		private CEnum<physicsFilterDataSource> _filterDataSource;
		private CHandle<physicsFilterData> _filterData;
		private CFloat _damageThreshold;
		private CFloat _damageEndurance;
		private CFloat _impulseToDamage;
		private CFloat _contactToDamage;
		private CBool _accumulateDamage;
		private raRef<worldEffect> _destructionEffect;
		private CName _audioMetadata;
		private NavGenNavigationSetting _navigationSetting;
		private CBool _useMeshNavmeshSettings;

		[Ordinal(15)] 
		[RED("meshFractured")] 
		public raRef<CMesh> MeshFractured
		{
			get => GetProperty(ref _meshFractured);
			set => SetProperty(ref _meshFractured, value);
		}

		[Ordinal(16)] 
		[RED("meshFracturedAppearance")] 
		public CName MeshFracturedAppearance
		{
			get => GetProperty(ref _meshFracturedAppearance);
			set => SetProperty(ref _meshFracturedAppearance, value);
		}

		[Ordinal(17)] 
		[RED("numFrames")] 
		public CFloat NumFrames
		{
			get => GetProperty(ref _numFrames);
			set => SetProperty(ref _numFrames, value);
		}

		[Ordinal(18)] 
		[RED("frameRate")] 
		public CFloat FrameRate
		{
			get => GetProperty(ref _frameRate);
			set => SetProperty(ref _frameRate, value);
		}

		[Ordinal(19)] 
		[RED("playOnlyOnce")] 
		public CBool PlayOnlyOnce
		{
			get => GetProperty(ref _playOnlyOnce);
			set => SetProperty(ref _playOnlyOnce, value);
		}

		[Ordinal(20)] 
		[RED("restartOnTrigger")] 
		public CBool RestartOnTrigger
		{
			get => GetProperty(ref _restartOnTrigger);
			set => SetProperty(ref _restartOnTrigger, value);
		}

		[Ordinal(21)] 
		[RED("disableCollidersOnTrigger")] 
		public CBool DisableCollidersOnTrigger
		{
			get => GetProperty(ref _disableCollidersOnTrigger);
			set => SetProperty(ref _disableCollidersOnTrigger, value);
		}

		[Ordinal(22)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get => GetProperty(ref _filterDataSource);
			set => SetProperty(ref _filterDataSource, value);
		}

		[Ordinal(23)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(24)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get => GetProperty(ref _damageThreshold);
			set => SetProperty(ref _damageThreshold, value);
		}

		[Ordinal(25)] 
		[RED("damageEndurance")] 
		public CFloat DamageEndurance
		{
			get => GetProperty(ref _damageEndurance);
			set => SetProperty(ref _damageEndurance, value);
		}

		[Ordinal(26)] 
		[RED("impulseToDamage")] 
		public CFloat ImpulseToDamage
		{
			get => GetProperty(ref _impulseToDamage);
			set => SetProperty(ref _impulseToDamage, value);
		}

		[Ordinal(27)] 
		[RED("contactToDamage")] 
		public CFloat ContactToDamage
		{
			get => GetProperty(ref _contactToDamage);
			set => SetProperty(ref _contactToDamage, value);
		}

		[Ordinal(28)] 
		[RED("accumulateDamage")] 
		public CBool AccumulateDamage
		{
			get => GetProperty(ref _accumulateDamage);
			set => SetProperty(ref _accumulateDamage, value);
		}

		[Ordinal(29)] 
		[RED("destructionEffect")] 
		public raRef<worldEffect> DestructionEffect
		{
			get => GetProperty(ref _destructionEffect);
			set => SetProperty(ref _destructionEffect, value);
		}

		[Ordinal(30)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get => GetProperty(ref _audioMetadata);
			set => SetProperty(ref _audioMetadata, value);
		}

		[Ordinal(31)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetProperty(ref _navigationSetting);
			set => SetProperty(ref _navigationSetting, value);
		}

		[Ordinal(32)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get => GetProperty(ref _useMeshNavmeshSettings);
			set => SetProperty(ref _useMeshNavmeshSettings, value);
		}

		public worldBakedDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
