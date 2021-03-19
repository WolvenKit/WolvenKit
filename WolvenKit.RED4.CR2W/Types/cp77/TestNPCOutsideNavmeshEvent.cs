using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestNPCOutsideNavmeshEvent : redEvent
	{
		private wCHandle<gameObject> _activator;
		private wCHandle<gameObject> _target;
		private CBool _enable;

		[Ordinal(0)] 
		[RED("activator")] 
		public wCHandle<gameObject> Activator
		{
			get => GetProperty(ref _activator);
			set => SetProperty(ref _activator, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		public TestNPCOutsideNavmeshEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
