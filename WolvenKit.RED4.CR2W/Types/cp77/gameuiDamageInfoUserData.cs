using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageInfoUserData : IScriptable
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

		public gameuiDamageInfoUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
