using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPerkArea : CVariable
	{
		private CEnum<gamedataPerkArea> _type;
		private CBool _unlocked;
		private CArray<SPerk> _boughtPerks;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataPerkArea> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("unlocked")] 
		public CBool Unlocked
		{
			get => GetProperty(ref _unlocked);
			set => SetProperty(ref _unlocked, value);
		}

		[Ordinal(2)] 
		[RED("boughtPerks")] 
		public CArray<SPerk> BoughtPerks
		{
			get => GetProperty(ref _boughtPerks);
			set => SetProperty(ref _boughtPerks, value);
		}

		public SPerkArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
