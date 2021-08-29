using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataSimpleValueNode : gamedataValueDataNode
	{
		private CEnum<gamedataSimpleValueNodeValueType> _type;
		private CString _data;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gamedataSimpleValueNodeValueType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CString Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
