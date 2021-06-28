using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RagdollDamagePollData : CVariable
	{
		private WorldPosition _worldPosition;
		private Vector4 _worldNormal;
		private CFloat _maxForceMagnitude;
		private CFloat _maxImpulseMagnitude;
		private CFloat _maxVelocityChange;
		private CFloat _maxZDiff;

		[Ordinal(0)] 
		[RED("worldPosition")] 
		public WorldPosition WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(1)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get => GetProperty(ref _worldNormal);
			set => SetProperty(ref _worldNormal, value);
		}

		[Ordinal(2)] 
		[RED("maxForceMagnitude")] 
		public CFloat MaxForceMagnitude
		{
			get => GetProperty(ref _maxForceMagnitude);
			set => SetProperty(ref _maxForceMagnitude, value);
		}

		[Ordinal(3)] 
		[RED("maxImpulseMagnitude")] 
		public CFloat MaxImpulseMagnitude
		{
			get => GetProperty(ref _maxImpulseMagnitude);
			set => SetProperty(ref _maxImpulseMagnitude, value);
		}

		[Ordinal(4)] 
		[RED("maxVelocityChange")] 
		public CFloat MaxVelocityChange
		{
			get => GetProperty(ref _maxVelocityChange);
			set => SetProperty(ref _maxVelocityChange, value);
		}

		[Ordinal(5)] 
		[RED("maxZDiff")] 
		public CFloat MaxZDiff
		{
			get => GetProperty(ref _maxZDiff);
			set => SetProperty(ref _maxZDiff, value);
		}

		public RagdollDamagePollData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
