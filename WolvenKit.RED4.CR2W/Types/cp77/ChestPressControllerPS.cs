using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChestPressControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<EngDemoContainer> _chestPressSkillChecks;
		private CName _factOnQHack;
		private CBool _wasWeighHacked;

		[Ordinal(103)] 
		[RED("chestPressSkillChecks")] 
		public CHandle<EngDemoContainer> ChestPressSkillChecks
		{
			get
			{
				if (_chestPressSkillChecks == null)
				{
					_chestPressSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "chestPressSkillChecks", cr2w, this);
				}
				return _chestPressSkillChecks;
			}
			set
			{
				if (_chestPressSkillChecks == value)
				{
					return;
				}
				_chestPressSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("factOnQHack")] 
		public CName FactOnQHack
		{
			get
			{
				if (_factOnQHack == null)
				{
					_factOnQHack = (CName) CR2WTypeManager.Create("CName", "factOnQHack", cr2w, this);
				}
				return _factOnQHack;
			}
			set
			{
				if (_factOnQHack == value)
				{
					return;
				}
				_factOnQHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("wasWeighHacked")] 
		public CBool WasWeighHacked
		{
			get
			{
				if (_wasWeighHacked == null)
				{
					_wasWeighHacked = (CBool) CR2WTypeManager.Create("Bool", "wasWeighHacked", cr2w, this);
				}
				return _wasWeighHacked;
			}
			set
			{
				if (_wasWeighHacked == value)
				{
					return;
				}
				_wasWeighHacked = value;
				PropertySet(this);
			}
		}

		public ChestPressControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
