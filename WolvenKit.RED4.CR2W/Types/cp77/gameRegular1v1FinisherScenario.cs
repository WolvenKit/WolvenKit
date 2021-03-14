using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRegular1v1FinisherScenario : gameIFinisherScenario
	{
		private raRef<workWorkspotResource> _attackerWorkspot;
		private raRef<workWorkspotResource> _targetWorkspot;
		private CName _syncAnimSlotName;
		private CFloat _targetPlaybackDelay;
		private CFloat _targetBlendTime;
		private CFloat _attackerPlaybackDelay;
		private CFloat _attackerBlendTime;
		private CEnum<gameRegular1v1FinisherScenarioPivotSetting> _pivotSettings;
		private CBool _attackerIsMaster;

		[Ordinal(0)] 
		[RED("attackerWorkspot")] 
		public raRef<workWorkspotResource> AttackerWorkspot
		{
			get
			{
				if (_attackerWorkspot == null)
				{
					_attackerWorkspot = (raRef<workWorkspotResource>) CR2WTypeManager.Create("raRef:workWorkspotResource", "attackerWorkspot", cr2w, this);
				}
				return _attackerWorkspot;
			}
			set
			{
				if (_attackerWorkspot == value)
				{
					return;
				}
				_attackerWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetWorkspot")] 
		public raRef<workWorkspotResource> TargetWorkspot
		{
			get
			{
				if (_targetWorkspot == null)
				{
					_targetWorkspot = (raRef<workWorkspotResource>) CR2WTypeManager.Create("raRef:workWorkspotResource", "targetWorkspot", cr2w, this);
				}
				return _targetWorkspot;
			}
			set
			{
				if (_targetWorkspot == value)
				{
					return;
				}
				_targetWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("syncAnimSlotName")] 
		public CName SyncAnimSlotName
		{
			get
			{
				if (_syncAnimSlotName == null)
				{
					_syncAnimSlotName = (CName) CR2WTypeManager.Create("CName", "syncAnimSlotName", cr2w, this);
				}
				return _syncAnimSlotName;
			}
			set
			{
				if (_syncAnimSlotName == value)
				{
					return;
				}
				_syncAnimSlotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("targetPlaybackDelay")] 
		public CFloat TargetPlaybackDelay
		{
			get
			{
				if (_targetPlaybackDelay == null)
				{
					_targetPlaybackDelay = (CFloat) CR2WTypeManager.Create("Float", "targetPlaybackDelay", cr2w, this);
				}
				return _targetPlaybackDelay;
			}
			set
			{
				if (_targetPlaybackDelay == value)
				{
					return;
				}
				_targetPlaybackDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("targetBlendTime")] 
		public CFloat TargetBlendTime
		{
			get
			{
				if (_targetBlendTime == null)
				{
					_targetBlendTime = (CFloat) CR2WTypeManager.Create("Float", "targetBlendTime", cr2w, this);
				}
				return _targetBlendTime;
			}
			set
			{
				if (_targetBlendTime == value)
				{
					return;
				}
				_targetBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("attackerPlaybackDelay")] 
		public CFloat AttackerPlaybackDelay
		{
			get
			{
				if (_attackerPlaybackDelay == null)
				{
					_attackerPlaybackDelay = (CFloat) CR2WTypeManager.Create("Float", "attackerPlaybackDelay", cr2w, this);
				}
				return _attackerPlaybackDelay;
			}
			set
			{
				if (_attackerPlaybackDelay == value)
				{
					return;
				}
				_attackerPlaybackDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("attackerBlendTime")] 
		public CFloat AttackerBlendTime
		{
			get
			{
				if (_attackerBlendTime == null)
				{
					_attackerBlendTime = (CFloat) CR2WTypeManager.Create("Float", "attackerBlendTime", cr2w, this);
				}
				return _attackerBlendTime;
			}
			set
			{
				if (_attackerBlendTime == value)
				{
					return;
				}
				_attackerBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("pivotSettings")] 
		public CEnum<gameRegular1v1FinisherScenarioPivotSetting> PivotSettings
		{
			get
			{
				if (_pivotSettings == null)
				{
					_pivotSettings = (CEnum<gameRegular1v1FinisherScenarioPivotSetting>) CR2WTypeManager.Create("gameRegular1v1FinisherScenarioPivotSetting", "pivotSettings", cr2w, this);
				}
				return _pivotSettings;
			}
			set
			{
				if (_pivotSettings == value)
				{
					return;
				}
				_pivotSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("attackerIsMaster")] 
		public CBool AttackerIsMaster
		{
			get
			{
				if (_attackerIsMaster == null)
				{
					_attackerIsMaster = (CBool) CR2WTypeManager.Create("Bool", "attackerIsMaster", cr2w, this);
				}
				return _attackerIsMaster;
			}
			set
			{
				if (_attackerIsMaster == value)
				{
					return;
				}
				_attackerIsMaster = value;
				PropertySet(this);
			}
		}

		public gameRegular1v1FinisherScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
