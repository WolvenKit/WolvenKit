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

		[Ordinal(93)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_SimpleDevice>) CR2WTypeManager.Create("handle:AnimFeature_SimpleDevice", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("workspotSideName")] 
		public CName WorkspotSideName
		{
			get
			{
				if (_workspotSideName == null)
				{
					_workspotSideName = (CName) CR2WTypeManager.Create("CName", "workspotSideName", cr2w, this);
				}
				return _workspotSideName;
			}
			set
			{
				if (_workspotSideName == value)
				{
					return;
				}
				_workspotSideName = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("portalLight")] 
		public CHandle<gameLightComponent> PortalLight
		{
			get
			{
				if (_portalLight == null)
				{
					_portalLight = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "portalLight", cr2w, this);
				}
				return _portalLight;
			}
			set
			{
				if (_portalLight == value)
				{
					return;
				}
				_portalLight = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get
			{
				if (_sideTriggerNames == null)
				{
					_sideTriggerNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "sideTriggerNames", cr2w, this);
				}
				return _sideTriggerNames;
			}
			set
			{
				if (_sideTriggerNames == value)
				{
					return;
				}
				_sideTriggerNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get
			{
				if (_triggerComponents == null)
				{
					_triggerComponents = (CArray<CHandle<gameStaticTriggerAreaComponent>>) CR2WTypeManager.Create("array:handle:gameStaticTriggerAreaComponent", "triggerComponents", cr2w, this);
				}
				return _triggerComponents;
			}
			set
			{
				if (_triggerComponents == value)
				{
					return;
				}
				_triggerComponents = value;
				PropertySet(this);
			}
		}

		public WindowBlinders(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
