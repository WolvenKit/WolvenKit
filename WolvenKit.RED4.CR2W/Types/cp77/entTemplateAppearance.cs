using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTemplateAppearance : CVariable
	{
		private CName _name;
		private raRef<appearanceAppearanceResource> _appearanceResource;
		private CName _appearanceName;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("appearanceResource")] 
		public raRef<appearanceAppearanceResource> AppearanceResource
		{
			get => GetProperty(ref _appearanceResource);
			set => SetProperty(ref _appearanceResource, value);
		}

		[Ordinal(2)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}

		public entTemplateAppearance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
