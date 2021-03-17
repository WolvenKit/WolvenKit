using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartBulletDeflectedEvent : redEvent
	{
		private CMatrix _localToWorld;
		private wCHandle<gameObject> _instigator;
		private wCHandle<gameObject> _weapon;

		[Ordinal(0)] 
		[RED("localToWorld")] 
		public CMatrix LocalToWorld
		{
			get => GetProperty(ref _localToWorld);
			set => SetProperty(ref _localToWorld, value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(2)] 
		[RED("weapon")] 
		public wCHandle<gameObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		public SmartBulletDeflectedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
