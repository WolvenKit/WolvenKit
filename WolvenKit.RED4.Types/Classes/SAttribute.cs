using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SAttribute : RedBaseClass
	{
		private CEnum<gamedataStatType> _attributeName;
		private CInt32 _value;
		private TweakDBID _id;

		[Ordinal(0)] 
		[RED("attributeName")] 
		public CEnum<gamedataStatType> AttributeName
		{
			get => GetProperty(ref _attributeName);
			set => SetProperty(ref _attributeName, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}
