using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileShootEvent : gameprojectileSetUpEvent
	{
		private CMatrix _localToWorld;
		private Vector4 _startPoint;
		private Vector4 _startVelocity;
		private Vector4 _weaponVelocity;
		private gameprojectileWeaponParams _params;

		[Ordinal(4)] 
		[RED("localToWorld")] 
		public CMatrix LocalToWorld
		{
			get => GetProperty(ref _localToWorld);
			set => SetProperty(ref _localToWorld, value);
		}

		[Ordinal(5)] 
		[RED("startPoint")] 
		public Vector4 StartPoint
		{
			get => GetProperty(ref _startPoint);
			set => SetProperty(ref _startPoint, value);
		}

		[Ordinal(6)] 
		[RED("startVelocity")] 
		public Vector4 StartVelocity
		{
			get => GetProperty(ref _startVelocity);
			set => SetProperty(ref _startVelocity, value);
		}

		[Ordinal(7)] 
		[RED("weaponVelocity")] 
		public Vector4 WeaponVelocity
		{
			get => GetProperty(ref _weaponVelocity);
			set => SetProperty(ref _weaponVelocity, value);
		}

		[Ordinal(8)] 
		[RED("params")] 
		public gameprojectileWeaponParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public gameprojectileShootEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
