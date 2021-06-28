using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWeaponShootParams : CVariable
	{
		private Vector4 _fromWorldPosition;
		private Vector4 _forward;

		[Ordinal(0)] 
		[RED("fromWorldPosition")] 
		public Vector4 FromWorldPosition
		{
			get => GetProperty(ref _fromWorldPosition);
			set => SetProperty(ref _fromWorldPosition, value);
		}

		[Ordinal(1)] 
		[RED("forward")] 
		public Vector4 Forward
		{
			get => GetProperty(ref _forward);
			set => SetProperty(ref _forward, value);
		}

		public gameuiWeaponShootParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
