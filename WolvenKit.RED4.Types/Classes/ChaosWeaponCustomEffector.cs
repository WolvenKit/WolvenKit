using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChaosWeaponCustomEffector : gameEffector
	{
		private entEntityID _effectorOwnerID;
		private gameStatsObjectID _target;
		private TweakDBID _record;
		private CString _applicationTarget;
		private CUInt64 _modGroupID;

		[Ordinal(0)] 
		[RED("effectorOwnerID")] 
		public entEntityID EffectorOwnerID
		{
			get => GetProperty(ref _effectorOwnerID);
			set => SetProperty(ref _effectorOwnerID, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public gameStatsObjectID Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetProperty(ref _record);
			set => SetProperty(ref _record, value);
		}

		[Ordinal(3)] 
		[RED("applicationTarget")] 
		public CString ApplicationTarget
		{
			get => GetProperty(ref _applicationTarget);
			set => SetProperty(ref _applicationTarget, value);
		}

		[Ordinal(4)] 
		[RED("modGroupID")] 
		public CUInt64 ModGroupID
		{
			get => GetProperty(ref _modGroupID);
			set => SetProperty(ref _modGroupID, value);
		}
	}
}
