using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiDamageInfoUserData : IScriptable
	{
		private CArray<SHitFlag> _flags;
		private CEnum<EHitShapeType> _hitShapeType;

		[Ordinal(0)] 
		[RED("flags")] 
		public CArray<SHitFlag> Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		[Ordinal(1)] 
		[RED("hitShapeType")] 
		public CEnum<EHitShapeType> HitShapeType
		{
			get => GetProperty(ref _hitShapeType);
			set => SetProperty(ref _hitShapeType, value);
		}
	}
}
