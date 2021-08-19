using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindowBlinders : InteractiveDevice
	{
		private CHandle<AnimFeature_SimpleDevice> _animFeature;
		private CName _workspotSideName;
		private CHandle<gameLightComponent> _portalLight;
		private CArray<CName> _sideTriggerNames;
		private CArray<CHandle<gameStaticTriggerAreaComponent>> _triggerComponents;

		[Ordinal(97)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(98)] 
		[RED("workspotSideName")] 
		public CName WorkspotSideName
		{
			get => GetProperty(ref _workspotSideName);
			set => SetProperty(ref _workspotSideName, value);
		}

		[Ordinal(99)] 
		[RED("portalLight")] 
		public CHandle<gameLightComponent> PortalLight
		{
			get => GetProperty(ref _portalLight);
			set => SetProperty(ref _portalLight, value);
		}

		[Ordinal(100)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetProperty(ref _sideTriggerNames);
			set => SetProperty(ref _sideTriggerNames, value);
		}

		[Ordinal(101)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetProperty(ref _triggerComponents);
			set => SetProperty(ref _triggerComponents, value);
		}

		public WindowBlinders(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
