using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVertexAnimationMapperSource : RedBaseClass
	{
		private CEnum<entVertexAnimationMapperSourceType> _type;
		private CName _name;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<entVertexAnimationMapperSourceType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}
	}
}
