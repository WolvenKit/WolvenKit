using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsControllerHit : CVariable
	{
		private Vector4 _worldPos;
		private Vector4 _worldNormal;

		[Ordinal(0)] 
		[RED("worldPos")] 
		public Vector4 WorldPos
		{
			get => GetProperty(ref _worldPos);
			set => SetProperty(ref _worldPos, value);
		}

		[Ordinal(1)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get => GetProperty(ref _worldNormal);
			set => SetProperty(ref _worldNormal, value);
		}

		public physicsControllerHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
