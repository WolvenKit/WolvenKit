using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTppRepItemAppearanceInfo : CVariable
	{
		private TweakDBID _itemID;
		private CName _appearance;

		[Ordinal(0)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetProperty(ref _appearance);
			set => SetProperty(ref _appearance, value);
		}

		public gameTppRepItemAppearanceInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
