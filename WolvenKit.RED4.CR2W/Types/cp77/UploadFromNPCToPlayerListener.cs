using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UploadFromNPCToPlayerListener : QuickHackUploadListener
	{
		private wCHandle<ScriptedPuppet> _playerPuppet;
		private wCHandle<ScriptedPuppet> _npcPuppet;
		private HUDProgressBarData _variantHud;
		private CHandle<gameIBlackboard> _hudBlackboard;
		private CBool _ssAction;

		[Ordinal(2)] 
		[RED("playerPuppet")] 
		public wCHandle<ScriptedPuppet> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("npcPuppet")] 
		public wCHandle<ScriptedPuppet> NpcPuppet
		{
			get
			{
				if (_npcPuppet == null)
				{
					_npcPuppet = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "npcPuppet", cr2w, this);
				}
				return _npcPuppet;
			}
			set
			{
				if (_npcPuppet == value)
				{
					return;
				}
				_npcPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("variantHud")] 
		public HUDProgressBarData VariantHud
		{
			get
			{
				if (_variantHud == null)
				{
					_variantHud = (HUDProgressBarData) CR2WTypeManager.Create("HUDProgressBarData", "variantHud", cr2w, this);
				}
				return _variantHud;
			}
			set
			{
				if (_variantHud == value)
				{
					return;
				}
				_variantHud = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hudBlackboard")] 
		public CHandle<gameIBlackboard> HudBlackboard
		{
			get
			{
				if (_hudBlackboard == null)
				{
					_hudBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "hudBlackboard", cr2w, this);
				}
				return _hudBlackboard;
			}
			set
			{
				if (_hudBlackboard == value)
				{
					return;
				}
				_hudBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ssAction")] 
		public CBool SsAction
		{
			get
			{
				if (_ssAction == null)
				{
					_ssAction = (CBool) CR2WTypeManager.Create("Bool", "ssAction", cr2w, this);
				}
				return _ssAction;
			}
			set
			{
				if (_ssAction == value)
				{
					return;
				}
				_ssAction = value;
				PropertySet(this);
			}
		}

		public UploadFromNPCToPlayerListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
