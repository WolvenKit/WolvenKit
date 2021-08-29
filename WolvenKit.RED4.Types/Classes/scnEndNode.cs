using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnEndNode : scnSceneGraphNode
	{
		private CEnum<scnEndNodeNsType> _type;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<scnEndNodeNsType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
