using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTweakDBIconReference : inkIconReference
	{
		private TweakDBID _iconID;

		[Ordinal(0)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get
			{
				if (_iconID == null)
				{
					_iconID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "iconID", cr2w, this);
				}
				return _iconID;
			}
			set
			{
				if (_iconID == value)
				{
					return;
				}
				_iconID = value;
				PropertySet(this);
			}
		}

		public gameuiTweakDBIconReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
