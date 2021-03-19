using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetedObjectDeathListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<SensorDevice> _lsitener;
		private wCHandle<gameObject> _lsitenTarget;

		[Ordinal(0)] 
		[RED("lsitener")] 
		public wCHandle<SensorDevice> Lsitener
		{
			get => GetProperty(ref _lsitener);
			set => SetProperty(ref _lsitener, value);
		}

		[Ordinal(1)] 
		[RED("lsitenTarget")] 
		public wCHandle<gameObject> LsitenTarget
		{
			get => GetProperty(ref _lsitenTarget);
			set => SetProperty(ref _lsitenTarget, value);
		}

		public TargetedObjectDeathListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
