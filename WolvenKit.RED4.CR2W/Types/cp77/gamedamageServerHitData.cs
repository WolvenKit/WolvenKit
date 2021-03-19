using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedamageServerHitData : IScriptable
	{
		private CUInt32 _id;
		private CArray<gameuiDamageInfo> _damageInfos;
		private wCHandle<gameObject> _instigator;

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
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		public gamedamageServerHitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
