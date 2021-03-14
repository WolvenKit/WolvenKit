using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entShadowMeshChangeEvent : redEvent
	{
		private CEnum<entAppearanceStatus> _requestedState;

		[Ordinal(0)] 
		[RED("requestedState")] 
		public CEnum<entAppearanceStatus> RequestedState
		{
			get
			{
				if (_requestedState == null)
				{
					_requestedState = (CEnum<entAppearanceStatus>) CR2WTypeManager.Create("entAppearanceStatus", "requestedState", cr2w, this);
				}
				return _requestedState;
			}
			set
			{
				if (_requestedState == value)
				{
					return;
				}
				_requestedState = value;
				PropertySet(this);
			}
		}

		public entShadowMeshChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
