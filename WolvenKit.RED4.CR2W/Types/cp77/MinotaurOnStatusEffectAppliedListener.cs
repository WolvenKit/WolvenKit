using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinotaurOnStatusEffectAppliedListener : gameScriptStatusEffectListener
	{
		private wCHandle<NPCPuppet> _owner;
		private CHandle<MinotaurMechComponent> _minotaurMechComponent;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("minotaurMechComponent")] 
		public CHandle<MinotaurMechComponent> MinotaurMechComponent
		{
			get
			{
				if (_minotaurMechComponent == null)
				{
					_minotaurMechComponent = (CHandle<MinotaurMechComponent>) CR2WTypeManager.Create("handle:MinotaurMechComponent", "minotaurMechComponent", cr2w, this);
				}
				return _minotaurMechComponent;
			}
			set
			{
				if (_minotaurMechComponent == value)
				{
					return;
				}
				_minotaurMechComponent = value;
				PropertySet(this);
			}
		}

		public MinotaurOnStatusEffectAppliedListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
