using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedamageServerHitData : IScriptable
	{
		private CUInt32 _id;
		private CArray<gameuiDamageInfo> _damageInfos;
		private CWeakHandle<gameObject> _instigator;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("damageInfos")] 
		public CArray<gameuiDamageInfo> DamageInfos
		{
			get => GetProperty(ref _damageInfos);
			set => SetProperty(ref _damageInfos, value);
		}

		[Ordinal(2)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}
	}
}
