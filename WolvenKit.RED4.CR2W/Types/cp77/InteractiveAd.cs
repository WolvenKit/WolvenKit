using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveAd : InteractiveDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _triggerComponent;
		private CHandle<gameStaticTriggerAreaComponent> _triggerExitComponent;
		private CHandle<WorldWidgetComponent> _aduiComponent;
		private CBool _showAd;
		private CBool _showVendor;

		[Ordinal(93)] 
		[RED("triggerComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerComponent
		{
			get
			{
				if (_triggerComponent == null)
				{
					_triggerComponent = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "triggerComponent", cr2w, this);
				}
				return _triggerComponent;
			}
			set
			{
				if (_triggerComponent == value)
				{
					return;
				}
				_triggerComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("triggerExitComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerExitComponent
		{
			get
			{
				if (_triggerExitComponent == null)
				{
					_triggerExitComponent = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "triggerExitComponent", cr2w, this);
				}
				return _triggerExitComponent;
			}
			set
			{
				if (_triggerExitComponent == value)
				{
					return;
				}
				_triggerExitComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("aduiComponent")] 
		public CHandle<WorldWidgetComponent> AduiComponent
		{
			get
			{
				if (_aduiComponent == null)
				{
					_aduiComponent = (CHandle<WorldWidgetComponent>) CR2WTypeManager.Create("handle:WorldWidgetComponent", "aduiComponent", cr2w, this);
				}
				return _aduiComponent;
			}
			set
			{
				if (_aduiComponent == value)
				{
					return;
				}
				_aduiComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get
			{
				if (_showAd == null)
				{
					_showAd = (CBool) CR2WTypeManager.Create("Bool", "showAd", cr2w, this);
				}
				return _showAd;
			}
			set
			{
				if (_showAd == value)
				{
					return;
				}
				_showAd = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("showVendor")] 
		public CBool ShowVendor
		{
			get
			{
				if (_showVendor == null)
				{
					_showVendor = (CBool) CR2WTypeManager.Create("Bool", "showVendor", cr2w, this);
				}
				return _showVendor;
			}
			set
			{
				if (_showVendor == value)
				{
					return;
				}
				_showVendor = value;
				PropertySet(this);
			}
		}

		public InteractiveAd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
