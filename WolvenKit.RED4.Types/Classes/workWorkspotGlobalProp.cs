using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workWorkspotGlobalProp : RedBaseClass
	{
		private CName _id;
		private CName _boneName;
		private CResourceAsyncReference<entEntityTemplate> _prop;

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
		public CResourceAsyncReference<entEntityTemplate> Prop
		{
			get => GetProperty(ref _prop);
			set => SetProperty(ref _prop, value);
		}
	}
}
