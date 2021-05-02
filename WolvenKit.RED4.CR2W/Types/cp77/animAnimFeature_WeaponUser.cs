using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_WeaponUser : animAnimFeature
	{
		private Vector4 _ikLeftHandLocalPosition;
		private Vector4 _ikRightHandLocalPosition;

		[Ordinal(0)] 
		[RED("ikLeftHandLocalPosition")] 
		public Vector4 IkLeftHandLocalPosition
		{
			get => GetProperty(ref _ikLeftHandLocalPosition);
			set => SetProperty(ref _ikLeftHandLocalPosition, value);
		}

		[Ordinal(1)] 
		[RED("ikRightHandLocalPosition")] 
		public Vector4 IkRightHandLocalPosition
		{
			get => GetProperty(ref _ikRightHandLocalPosition);
			set => SetProperty(ref _ikRightHandLocalPosition, value);
		}

		public animAnimFeature_WeaponUser(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
