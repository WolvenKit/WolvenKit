using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiStaticIconLogicController : gameuiDynamicIconLogicController
	{
		private TweakDBID _iconReference;

		[Ordinal(1)] 
		[RED("iconReference")] 
		public TweakDBID IconReference
		{
			get
			{
				if (_iconReference == null)
				{
					_iconReference = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "iconReference", cr2w, this);
				}
				return _iconReference;
			}
			set
			{
				if (_iconReference == value)
				{
					return;
				}
				_iconReference = value;
				PropertySet(this);
			}
		}

		public gameuiStaticIconLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
