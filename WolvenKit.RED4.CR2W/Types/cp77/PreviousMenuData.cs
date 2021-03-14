using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreviousMenuData : IScriptable
	{
		private CHandle<OpenMenuRequest> _openMenuRequest;

		[Ordinal(0)] 
		[RED("openMenuRequest")] 
		public CHandle<OpenMenuRequest> OpenMenuRequest
		{
			get
			{
				if (_openMenuRequest == null)
				{
					_openMenuRequest = (CHandle<OpenMenuRequest>) CR2WTypeManager.Create("handle:OpenMenuRequest", "openMenuRequest", cr2w, this);
				}
				return _openMenuRequest;
			}
			set
			{
				if (_openMenuRequest == value)
				{
					return;
				}
				_openMenuRequest = value;
				PropertySet(this);
			}
		}

		public PreviousMenuData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
