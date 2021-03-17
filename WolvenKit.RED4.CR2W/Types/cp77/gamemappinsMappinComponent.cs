using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinComponent : entIPlacedComponent
	{
		private gamemappinsMappinData _data;

		[Ordinal(5)] 
		[RED("data")] 
		public gamemappinsMappinData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public gamemappinsMappinComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
