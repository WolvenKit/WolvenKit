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
			get => GetProperty(ref _armouryItemID);
			set => SetProperty(ref _armouryItemID, value);
		}

		public gameCpoArmouryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
