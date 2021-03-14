using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCpoArmouryItem : gameObject
	{
		private TweakDBID _armouryItemID;

		[Ordinal(40)] 
		[RED("armouryItemID")] 
		public TweakDBID ArmouryItemID
		{
			get
			{
				if (_armouryItemID == null)
				{
					_armouryItemID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "armouryItemID", cr2w, this);
				}
				return _armouryItemID;
			}
			set
			{
				if (_armouryItemID == value)
				{
					return;
				}
				_armouryItemID = value;
				PropertySet(this);
			}
		}

		public gameCpoArmouryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
