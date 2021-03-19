using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameShapeData : CVariable
	{
		private gameHitResult _result;
		private CHandle<gameHitShapeUserData> _userData;
		private CName _physicsMaterial;
		private CName _hitShapeName;

		[Ordinal(0)] 
		[RED("result")] 
		public gameHitResult Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}

		[Ordinal(1)] 
		[RED("userData")] 
		public CHandle<gameHitShapeUserData> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		[Ordinal(2)] 
		[RED("physicsMaterial")] 
		public CName PhysicsMaterial
		{
			get => GetProperty(ref _physicsMaterial);
			set => SetProperty(ref _physicsMaterial, value);
		}

		[Ordinal(3)] 
		[RED("hitShapeName")] 
		public CName HitShapeName
		{
			get => GetProperty(ref _hitShapeName);
			set => SetProperty(ref _hitShapeName, value);
		}

		public gameShapeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
