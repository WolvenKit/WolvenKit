using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficStaticCollisionSphere : CVariable
	{
		private Vector3 _worldPos;

		[Ordinal(0)] 
		[RED("worldPos")] 
		public Vector3 WorldPos
		{
			get => GetProperty(ref _worldPos);
			set => SetProperty(ref _worldPos, value);
		}

		public worldTrafficStaticCollisionSphere(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
