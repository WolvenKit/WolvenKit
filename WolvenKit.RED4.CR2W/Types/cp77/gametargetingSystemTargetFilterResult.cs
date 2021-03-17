using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gametargetingSystemTargetFilterResult : IScriptable
	{
		private entEntityID _hitEntId;
		private wCHandle<entIComponent> _hitComponent;

		[Ordinal(0)] 
		[RED("hitEntId")] 
		public entEntityID HitEntId
		{
			get => GetProperty(ref _hitEntId);
			set => SetProperty(ref _hitEntId, value);
		}

		[Ordinal(1)] 
		[RED("hitComponent")] 
		public wCHandle<entIComponent> HitComponent
		{
			get => GetProperty(ref _hitComponent);
			set => SetProperty(ref _hitComponent, value);
		}

		public gametargetingSystemTargetFilterResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
