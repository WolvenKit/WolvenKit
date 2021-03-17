using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyStatusEffectDeviceOperation : DeviceOperationBase
	{
		private CArray<SStatusEffectOperationData> _statusEffects;

		[Ordinal(5)] 
		[RED("statusEffects")] 
		public CArray<SStatusEffectOperationData> StatusEffects
		{
			get => GetProperty(ref _statusEffects);
			set => SetProperty(ref _statusEffects, value);
		}

		public ApplyStatusEffectDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
