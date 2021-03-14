using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableInventoryListenerCallback : gameInventoryScriptCallback
	{
		private CHandle<UIScriptableSystem> _uiScriptableSystem;

		[Ordinal(1)] 
		[RED("uiScriptableSystem")] 
		public CHandle<UIScriptableSystem> UiScriptableSystem
		{
			get
			{
				if (_uiScriptableSystem == null)
				{
					_uiScriptableSystem = (CHandle<UIScriptableSystem>) CR2WTypeManager.Create("handle:UIScriptableSystem", "uiScriptableSystem", cr2w, this);
				}
				return _uiScriptableSystem;
			}
			set
			{
				if (_uiScriptableSystem == value)
				{
					return;
				}
				_uiScriptableSystem = value;
				PropertySet(this);
			}
		}

		public UIScriptableInventoryListenerCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
