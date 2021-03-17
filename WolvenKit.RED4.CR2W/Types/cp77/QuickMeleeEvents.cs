using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickMeleeEvents : WeaponEventsTransition
	{
		private CHandle<gameEffectInstance> _gameEffect;
		private wCHandle<gameObject> _targetObject;
		private CHandle<entIPlacedComponent> _targetComponent;
		private CBool _quickMeleeAttackCreated;
		private QuickMeleeAttackData _quickMeleeAttackData;

		[Ordinal(0)] 
		[RED("gameEffect")] 
		public CHandle<gameEffectInstance> GameEffect
		{
			get => GetProperty(ref _gameEffect);
			set => SetProperty(ref _gameEffect, value);
		}

		[Ordinal(1)] 
		[RED("targetObject")] 
		public wCHandle<gameObject> TargetObject
		{
			get => GetProperty(ref _targetObject);
			set => SetProperty(ref _targetObject, value);
		}

		[Ordinal(2)] 
		[RED("targetComponent")] 
		public CHandle<entIPlacedComponent> TargetComponent
		{
			get => GetProperty(ref _targetComponent);
			set => SetProperty(ref _targetComponent, value);
		}

		[Ordinal(3)] 
		[RED("quickMeleeAttackCreated")] 
		public CBool QuickMeleeAttackCreated
		{
			get => GetProperty(ref _quickMeleeAttackCreated);
			set => SetProperty(ref _quickMeleeAttackCreated, value);
		}

		[Ordinal(4)] 
		[RED("quickMeleeAttackData")] 
		public QuickMeleeAttackData QuickMeleeAttackData
		{
			get => GetProperty(ref _quickMeleeAttackData);
			set => SetProperty(ref _quickMeleeAttackData, value);
		}

		public QuickMeleeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
