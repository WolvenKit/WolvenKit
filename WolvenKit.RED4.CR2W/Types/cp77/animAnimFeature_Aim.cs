using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Aim : animAnimFeature_BasicAim
	{
		private Vector4 _aimPoint;

		[Ordinal(2)] 
		[RED("aimPoint")] 
		public Vector4 AimPoint
		{
			get => GetProperty(ref _aimPoint);
			set => SetProperty(ref _aimPoint, value);
		}

		public animAnimFeature_Aim(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
