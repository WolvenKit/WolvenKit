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
			get => GetProperty(ref _healthControllerRef);
			set => SetProperty(ref _healthControllerRef, value);
		}

		[Ordinal(10)] 
		[RED("healthPersentage")] 
		public inkTextWidgetReference HealthPersentage
		{
			get => GetProperty(ref _healthPersentage);
			set => SetProperty(ref _healthPersentage, value);
		}

		[Ordinal(11)] 
		[RED("bossName")] 
		public inkTextWidgetReference BossName
		{
			get => GetProperty(ref _bossName);
			set => SetProperty(ref _bossName, value);
		}

		[Ordinal(12)] 
		[RED("statListener")] 
		public CHandle<BossHealthStatListener> StatListener
		{
			get => GetProperty(ref _statListener);
			set => SetProperty(ref _statListener, value);
		}

		[Ordinal(13)] 
		[RED("boss")] 
		public wCHandle<NPCPuppet> Boss
		{
			get => GetProperty(ref _boss);
			set => SetProperty(ref _boss, value);
		}

		[Ordinal(14)] 
		[RED("healthController")] 
		public wCHandle<NameplateBarLogicController> HealthController
		{
			get => GetProperty(ref _healthController);
			set => SetProperty(ref _healthController, value);
		}

		[Ordinal(15)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(16)] 
		[RED("foldAnimation")] 
		public CHandle<inkanimProxy> FoldAnimation
		{
			get => GetProperty(ref _foldAnimation);
			set => SetProperty(ref _foldAnimation, value);
		}

		[Ordinal(17)] 
		[RED("bossPuppets")] 
		public CArray<wCHandle<NPCPuppet>> BossPuppets
		{
			get => GetProperty(ref _bossPuppets);
			set => SetProperty(ref _bossPuppets, value);
		}

		public BossHealthBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
