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
			get
			{
				if (_exitComboBoolArgumentRef == null)
				{
					_exitComboBoolArgumentRef = (CName) CR2WTypeManager.Create("CName", "ExitComboBoolArgumentRef", cr2w, this);
				}
				return _exitComboBoolArgumentRef;
			}
			set
			{
				if (_exitComboBoolArgumentRef == value)
				{
					return;
				}
				_exitComboBoolArgumentRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("PreviousReactionIntArgumentRef")] 
		public CName PreviousReactionIntArgumentRef
		{
			get
			{
				if (_previousReactionIntArgumentRef == null)
				{
					_previousReactionIntArgumentRef = (CName) CR2WTypeManager.Create("CName", "PreviousReactionIntArgumentRef", cr2w, this);
				}
				return _previousReactionIntArgumentRef;
			}
			set
			{
				if (_previousReactionIntArgumentRef == value)
				{
					return;
				}
				_previousReactionIntArgumentRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("CurrentAttackIntArgumentRef")] 
		public CName CurrentAttackIntArgumentRef
		{
			get
			{
				if (_currentAttackIntArgumentRef == null)
				{
					_currentAttackIntArgumentRef = (CName) CR2WTypeManager.Create("CName", "CurrentAttackIntArgumentRef", cr2w, this);
				}
				return _currentAttackIntArgumentRef;
			}
			set
			{
				if (_currentAttackIntArgumentRef == value)
				{
					return;
				}
				_currentAttackIntArgumentRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ComboCountIntArgumentRef")] 
		public CName ComboCountIntArgumentRef
		{
			get
			{
				if (_comboCountIntArgumentRef == null)
				{
					_comboCountIntArgumentRef = (CName) CR2WTypeManager.Create("CName", "ComboCountIntArgumentRef", cr2w, this);
				}
				return _comboCountIntArgumentRef;
			}
			set
			{
				if (_comboCountIntArgumentRef == value)
				{
					return;
				}
				_comboCountIntArgumentRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ComboToIdleBoolArgumentRef")] 
		public CName ComboToIdleBoolArgumentRef
		{
			get
			{
				if (_comboToIdleBoolArgumentRef == null)
				{
					_comboToIdleBoolArgumentRef = (CName) CR2WTypeManager.Create("CName", "ComboToIdleBoolArgumentRef", cr2w, this);
				}
				return _comboToIdleBoolArgumentRef;
			}
			set
			{
				if (_comboToIdleBoolArgumentRef == value)
				{
					return;
				}
				_comboToIdleBoolArgumentRef = value;
				PropertySet(this);
			}
		}

		public MonitorMeleeCombo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
