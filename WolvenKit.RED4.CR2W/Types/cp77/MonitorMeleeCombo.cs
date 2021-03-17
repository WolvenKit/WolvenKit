using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MonitorMeleeCombo : AIActionHelperTask
	{
		private CName _exitComboBoolArgumentRef;
		private CName _previousReactionIntArgumentRef;
		private CName _currentAttackIntArgumentRef;
		private CName _comboCountIntArgumentRef;
		private CName _comboToIdleBoolArgumentRef;

		[Ordinal(5)] 
		[RED("ExitComboBoolArgumentRef")] 
		public CName ExitComboBoolArgumentRef
		{
			get => GetProperty(ref _exitComboBoolArgumentRef);
			set => SetProperty(ref _exitComboBoolArgumentRef, value);
		}

		[Ordinal(6)] 
		[RED("PreviousReactionIntArgumentRef")] 
		public CName PreviousReactionIntArgumentRef
		{
			get => GetProperty(ref _previousReactionIntArgumentRef);
			set => SetProperty(ref _previousReactionIntArgumentRef, value);
		}

		[Ordinal(7)] 
		[RED("CurrentAttackIntArgumentRef")] 
		public CName CurrentAttackIntArgumentRef
		{
			get => GetProperty(ref _currentAttackIntArgumentRef);
			set => SetProperty(ref _currentAttackIntArgumentRef, value);
		}

		[Ordinal(8)] 
		[RED("ComboCountIntArgumentRef")] 
		public CName ComboCountIntArgumentRef
		{
			get => GetProperty(ref _comboCountIntArgumentRef);
			set => SetProperty(ref _comboCountIntArgumentRef, value);
		}

		[Ordinal(9)] 
		[RED("ComboToIdleBoolArgumentRef")] 
		public CName ComboToIdleBoolArgumentRef
		{
			get => GetProperty(ref _comboToIdleBoolArgumentRef);
			set => SetProperty(ref _comboToIdleBoolArgumentRef, value);
		}

		public MonitorMeleeCombo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
