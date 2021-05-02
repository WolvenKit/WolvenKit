using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateWeaponChargeEvent : redEvent
	{
		private CFloat _newValue;
		private CFloat _oldValue;

		[Ordinal(0)] 
		[RED("newValue")] 
		public CFloat NewValue
		{
			get => GetProperty(ref _newValue);
			set => SetProperty(ref _newValue, value);
		}

		[Ordinal(1)] 
		[RED("oldValue")] 
		public CFloat OldValue
		{
			get => GetProperty(ref _oldValue);
			set => SetProperty(ref _oldValue, value);
		}

		public UpdateWeaponChargeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
