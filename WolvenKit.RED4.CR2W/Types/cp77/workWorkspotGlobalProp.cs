using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotGlobalProp : CVariable
	{
		private CName _id;
		private CName _boneName;
		private raRef<entEntityTemplate> _prop;

		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetProperty(ref _boneName);
			set => SetProperty(ref _boneName, value);
		}

		[Ordinal(2)] 
		[RED("prop")] 
		public raRef<entEntityTemplate> Prop
		{
			get => GetProperty(ref _prop);
			set => SetProperty(ref _prop, value);
		}

		public workWorkspotGlobalProp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
