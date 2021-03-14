using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BossHealthBarGameController : gameuiHUDGameController
	{
		private inkWidgetReference _healthControllerRef;
		private inkTextWidgetReference _healthPersentage;
		private inkTextWidgetReference _bossName;
		private CHandle<BossHealthStatListener> _statListener;
		private wCHandle<NPCPuppet> _boss;
		private wCHandle<NameplateBarLogicController> _healthController;
		private CHandle<inkWidget> _root;
		private CHandle<inkanimProxy> _foldAnimation;
		private CArray<wCHandle<NPCPuppet>> _bossPuppets;

		[Ordinal(9)] 
		[RED("healthControllerRef")] 
		public inkWidgetReference HealthControllerRef
		{
			get
			{
				if (_healthControllerRef == null)
				{
					_healthControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "healthControllerRef", cr2w, this);
				}
				return _healthControllerRef;
			}
			set
			{
				if (_healthControllerRef == value)
				{
					return;
				}
				_healthControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("healthPersentage")] 
		public inkTextWidgetReference HealthPersentage
		{
			get
			{
				if (_healthPersentage == null)
				{
					_healthPersentage = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "healthPersentage", cr2w, this);
				}
				return _healthPersentage;
			}
			set
			{
				if (_healthPersentage == value)
				{
					return;
				}
				_healthPersentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("bossName")] 
		public inkTextWidgetReference BossName
		{
			get
			{
				if (_bossName == null)
				{
					_bossName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "bossName", cr2w, this);
				}
				return _bossName;
			}
			set
			{
				if (_bossName == value)
				{
					return;
				}
				_bossName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("statListener")] 
		public CHandle<BossHealthStatListener> StatListener
		{
			get
			{
				if (_statListener == null)
				{
					_statListener = (CHandle<BossHealthStatListener>) CR2WTypeManager.Create("handle:BossHealthStatListener", "statListener", cr2w, this);
				}
				return _statListener;
			}
			set
			{
				if (_statListener == value)
				{
					return;
				}
				_statListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("boss")] 
		public wCHandle<NPCPuppet> Boss
		{
			get
			{
				if (_boss == null)
				{
					_boss = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "boss", cr2w, this);
				}
				return _boss;
			}
			set
			{
				if (_boss == value)
				{
					return;
				}
				_boss = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("healthController")] 
		public wCHandle<NameplateBarLogicController> HealthController
		{
			get
			{
				if (_healthController == null)
				{
					_healthController = (wCHandle<NameplateBarLogicController>) CR2WTypeManager.Create("whandle:NameplateBarLogicController", "healthController", cr2w, this);
				}
				return _healthController;
			}
			set
			{
				if (_healthController == value)
				{
					return;
				}
				_healthController = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("foldAnimation")] 
		public CHandle<inkanimProxy> FoldAnimation
		{
			get
			{
				if (_foldAnimation == null)
				{
					_foldAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "foldAnimation", cr2w, this);
				}
				return _foldAnimation;
			}
			set
			{
				if (_foldAnimation == value)
				{
					return;
				}
				_foldAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("bossPuppets")] 
		public CArray<wCHandle<NPCPuppet>> BossPuppets
		{
			get
			{
				if (_bossPuppets == null)
				{
					_bossPuppets = (CArray<wCHandle<NPCPuppet>>) CR2WTypeManager.Create("array:whandle:NPCPuppet", "bossPuppets", cr2w, this);
				}
				return _bossPuppets;
			}
			set
			{
				if (_bossPuppets == value)
				{
					return;
				}
				_bossPuppets = value;
				PropertySet(this);
			}
		}

		public BossHealthBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
