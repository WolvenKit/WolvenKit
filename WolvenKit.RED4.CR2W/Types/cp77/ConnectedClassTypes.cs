using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConnectedClassTypes : CVariable
	{
		private CBool _surveillanceCamera;
		private CBool _securityTurret;
		private CBool _puppet;

		[Ordinal(0)] 
		[RED("surveillanceCamera")] 
		public CBool SurveillanceCamera
		{
			get => GetProperty(ref _surveillanceCamera);
			set => SetProperty(ref _surveillanceCamera, value);
		}

		[Ordinal(1)] 
		[RED("securityTurret")] 
		public CBool SecurityTurret
		{
			get => GetProperty(ref _securityTurret);
			set => SetProperty(ref _securityTurret, value);
		}

		[Ordinal(2)] 
		[RED("puppet")] 
		public CBool Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		public ConnectedClassTypes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
