using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerPerkDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Uint32 _woundedInstigated;
		private gamebbScriptID_Uint32 _dismembermentInstigated;
		private gamebbScriptID_Uint32 _entityNoticedPlayer;
		private gamebbScriptID_Float _combatStateTime;

		[Ordinal(0)] 
		[RED("WoundedInstigated")] 
		public gamebbScriptID_Uint32 WoundedInstigated
		{
			get
			{
				if (_woundedInstigated == null)
				{
					_woundedInstigated = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "WoundedInstigated", cr2w, this);
				}
				return _woundedInstigated;
			}
			set
			{
				if (_woundedInstigated == value)
				{
					return;
				}
				_woundedInstigated = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("DismembermentInstigated")] 
		public gamebbScriptID_Uint32 DismembermentInstigated
		{
			get
			{
				if (_dismembermentInstigated == null)
				{
					_dismembermentInstigated = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "DismembermentInstigated", cr2w, this);
				}
				return _dismembermentInstigated;
			}
			set
			{
				if (_dismembermentInstigated == value)
				{
					return;
				}
				_dismembermentInstigated = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("EntityNoticedPlayer")] 
		public gamebbScriptID_Uint32 EntityNoticedPlayer
		{
			get
			{
				if (_entityNoticedPlayer == null)
				{
					_entityNoticedPlayer = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "EntityNoticedPlayer", cr2w, this);
				}
				return _entityNoticedPlayer;
			}
			set
			{
				if (_entityNoticedPlayer == value)
				{
					return;
				}
				_entityNoticedPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("CombatStateTime")] 
		public gamebbScriptID_Float CombatStateTime
		{
			get
			{
				if (_combatStateTime == null)
				{
					_combatStateTime = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "CombatStateTime", cr2w, this);
				}
				return _combatStateTime;
			}
			set
			{
				if (_combatStateTime == value)
				{
					return;
				}
				_combatStateTime = value;
				PropertySet(this);
			}
		}

		public PlayerPerkDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
