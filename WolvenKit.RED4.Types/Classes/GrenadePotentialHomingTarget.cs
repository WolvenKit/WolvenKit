using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadePotentialHomingTarget : RedBaseClass
	{
		private CWeakHandle<ScriptedPuppet> _entity;
		private CName _targetSlot;

		[Ordinal(0)] 
		[RED("entity")] 
		public CWeakHandle<ScriptedPuppet> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(1)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get => GetProperty(ref _targetSlot);
			set => SetProperty(ref _targetSlot, value);
		}
	}
}
