using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeHitEvent : redEvent
	{
		private wCHandle<gameObject> _instigator;
		private wCHandle<gameObject> _target;
		private CBool _isStrongAttack;
		private CBool _hitBlocked;

		[Ordinal(0)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("isStrongAttack")] 
		public CBool IsStrongAttack
		{
			get => GetProperty(ref _isStrongAttack);
			set => SetProperty(ref _isStrongAttack, value);
		}

		[Ordinal(3)] 
		[RED("hitBlocked")] 
		public CBool HitBlocked
		{
			get => GetProperty(ref _hitBlocked);
			set => SetProperty(ref _hitBlocked, value);
		}

		public MeleeHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
