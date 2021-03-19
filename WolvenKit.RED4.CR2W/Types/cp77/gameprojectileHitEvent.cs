using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileHitEvent : redEvent
	{
		private CArray<gameprojectileHitInstance> _hitInstances;

		[Ordinal(0)] 
		[RED("hitInstances")] 
		public CArray<gameprojectileHitInstance> HitInstances
		{
			get => GetProperty(ref _hitInstances);
			set => SetProperty(ref _hitInstances, value);
		}

		public gameprojectileHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
