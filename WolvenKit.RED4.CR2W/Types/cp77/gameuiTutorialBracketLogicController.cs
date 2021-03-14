using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialBracketLogicController : inkWidgetLogicController
	{
		private CHandle<inkanimProxy> _loopAnim;

		[Ordinal(1)] 
		[RED("loopAnim")] 
		public CHandle<inkanimProxy> LoopAnim
		{
			get
			{
				if (_loopAnim == null)
				{
					_loopAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "loopAnim", cr2w, this);
				}
				return _loopAnim;
			}
			set
			{
				if (_loopAnim == value)
				{
					return;
				}
				_loopAnim = value;
				PropertySet(this);
			}
		}

		public gameuiTutorialBracketLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
