using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpawnerAttachExistingEvent : redEvent
	{
		private wCHandle<gameObject> _projectile;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("projectile")] 
		public wCHandle<gameObject> Projectile
		{
			get => GetProperty(ref _projectile);
			set => SetProperty(ref _projectile, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public gameprojectileSpawnerAttachExistingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
