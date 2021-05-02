using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLightComponent : entLightComponent
	{
		private CBool _emissiveOnly;
		private CEnum<gameEMaterialZone> _materialZone;
		private CName _meshBrokenAppearance;
		private CFloat _onStrength;
		private CBool _turnOnByDefault;
		private CFloat _turnOnTime;
		private CName _turnOnCurve;
		private CFloat _turnOffTime;
		private CName _turnOffCurve;
		private CFloat _loopTime;
		private CName _loopCurve;
		private CBool _isDestructible;
		private CName _colliderName;
		private CName _colliderTag;
		private raRef<worldEffect> _destructionEffect;

		[Ordinal(54)] 
		[RED("emissiveOnly")] 
		public CBool EmissiveOnly
		{
			get => GetProperty(ref _emissiveOnly);
			set => SetProperty(ref _emissiveOnly, value);
		}

		[Ordinal(55)] 
		[RED("materialZone")] 
		public CEnum<gameEMaterialZone> MaterialZone
		{
			get => GetProperty(ref _materialZone);
			set => SetProperty(ref _materialZone, value);
		}

		[Ordinal(56)] 
		[RED("meshBrokenAppearance")] 
		public CName MeshBrokenAppearance
		{
			get => GetProperty(ref _meshBrokenAppearance);
			set => SetProperty(ref _meshBrokenAppearance, value);
		}

		[Ordinal(57)] 
		[RED("onStrength")] 
		public CFloat OnStrength
		{
			get => GetProperty(ref _onStrength);
			set => SetProperty(ref _onStrength, value);
		}

		[Ordinal(58)] 
		[RED("turnOnByDefault")] 
		public CBool TurnOnByDefault
		{
			get => GetProperty(ref _turnOnByDefault);
			set => SetProperty(ref _turnOnByDefault, value);
		}

		[Ordinal(59)] 
		[RED("turnOnTime")] 
		public CFloat TurnOnTime
		{
			get => GetProperty(ref _turnOnTime);
			set => SetProperty(ref _turnOnTime, value);
		}

		[Ordinal(60)] 
		[RED("turnOnCurve")] 
		public CName TurnOnCurve
		{
			get => GetProperty(ref _turnOnCurve);
			set => SetProperty(ref _turnOnCurve, value);
		}

		[Ordinal(61)] 
		[RED("turnOffTime")] 
		public CFloat TurnOffTime
		{
			get => GetProperty(ref _turnOffTime);
			set => SetProperty(ref _turnOffTime, value);
		}

		[Ordinal(62)] 
		[RED("turnOffCurve")] 
		public CName TurnOffCurve
		{
			get => GetProperty(ref _turnOffCurve);
			set => SetProperty(ref _turnOffCurve, value);
		}

		[Ordinal(63)] 
		[RED("loopTime")] 
		public CFloat LoopTime
		{
			get => GetProperty(ref _loopTime);
			set => SetProperty(ref _loopTime, value);
		}

		[Ordinal(64)] 
		[RED("loopCurve")] 
		public CName LoopCurve
		{
			get => GetProperty(ref _loopCurve);
			set => SetProperty(ref _loopCurve, value);
		}

		[Ordinal(65)] 
		[RED("isDestructible")] 
		public CBool IsDestructible
		{
			get => GetProperty(ref _isDestructible);
			set => SetProperty(ref _isDestructible, value);
		}

		[Ordinal(66)] 
		[RED("colliderName")] 
		public CName ColliderName
		{
			get => GetProperty(ref _colliderName);
			set => SetProperty(ref _colliderName, value);
		}

		[Ordinal(67)] 
		[RED("colliderTag")] 
		public CName ColliderTag
		{
			get => GetProperty(ref _colliderTag);
			set => SetProperty(ref _colliderTag, value);
		}

		[Ordinal(68)] 
		[RED("destructionEffect")] 
		public raRef<worldEffect> DestructionEffect
		{
			get => GetProperty(ref _destructionEffect);
			set => SetProperty(ref _destructionEffect, value);
		}

		public gameLightComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
