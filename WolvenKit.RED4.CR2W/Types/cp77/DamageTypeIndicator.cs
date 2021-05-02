using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageTypeIndicator : inkWidgetLogicController
	{
		private inkImageWidgetReference _damageIconRef;
		private inkTextWidgetReference _damageTypeLabelRef;

		[Ordinal(1)] 
		[RED("DamageIconRef")] 
		public inkImageWidgetReference DamageIconRef
		{
			get => GetProperty(ref _damageIconRef);
			set => SetProperty(ref _damageIconRef, value);
		}

		[Ordinal(2)] 
		[RED("DamageTypeLabelRef")] 
		public inkTextWidgetReference DamageTypeLabelRef
		{
			get => GetProperty(ref _damageTypeLabelRef);
			set => SetProperty(ref _damageTypeLabelRef, value);
		}

		public DamageTypeIndicator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
