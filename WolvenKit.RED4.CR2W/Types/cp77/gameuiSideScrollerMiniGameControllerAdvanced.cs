using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameControllerAdvanced : gameuiWidgetGameController
	{
		private inkWidgetReference _gameplayCanvas;

		[Ordinal(2)] 
		[RED("gameplayCanvas")] 
		public inkWidgetReference GameplayCanvas
		{
			get
			{
				if (_gameplayCanvas == null)
				{
					_gameplayCanvas = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "gameplayCanvas", cr2w, this);
				}
				return _gameplayCanvas;
			}
			set
			{
				if (_gameplayCanvas == value)
				{
					return;
				}
				_gameplayCanvas = value;
				PropertySet(this);
			}
		}

		public gameuiSideScrollerMiniGameControllerAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
