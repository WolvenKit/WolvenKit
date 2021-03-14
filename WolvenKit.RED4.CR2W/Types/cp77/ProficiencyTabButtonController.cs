using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProficiencyTabButtonController : TabButtonController
	{
		private CHandle<inkanimProxy> _proxy;
		private CBool _isToggledState;

		[Ordinal(18)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get
			{
				if (_proxy == null)
				{
					_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "proxy", cr2w, this);
				}
				return _proxy;
			}
			set
			{
				if (_proxy == value)
				{
					return;
				}
				_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("isToggledState")] 
		public CBool IsToggledState
		{
			get
			{
				if (_isToggledState == null)
				{
					_isToggledState = (CBool) CR2WTypeManager.Create("Bool", "isToggledState", cr2w, this);
				}
				return _isToggledState;
			}
			set
			{
				if (_isToggledState == value)
				{
					return;
				}
				_isToggledState = value;
				PropertySet(this);
			}
		}

		public ProficiencyTabButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
