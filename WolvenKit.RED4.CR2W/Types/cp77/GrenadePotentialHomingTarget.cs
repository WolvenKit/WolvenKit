using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadePotentialHomingTarget : CVariable
	{
		private wCHandle<ScriptedPuppet> _entity;
		private CName _targetSlot;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<ScriptedPuppet> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get
			{
				if (_targetSlot == null)
				{
					_targetSlot = (CName) CR2WTypeManager.Create("CName", "targetSlot", cr2w, this);
				}
				return _targetSlot;
			}
			set
			{
				if (_targetSlot == value)
				{
					return;
				}
				_targetSlot = value;
				PropertySet(this);
			}
		}

		public GrenadePotentialHomingTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
